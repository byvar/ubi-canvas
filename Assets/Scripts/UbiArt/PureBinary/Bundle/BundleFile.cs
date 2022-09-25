using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;
using Cysharp.Threading.Tasks;
using Ionic.Zlib;
using UbiCanvas.Helpers;

namespace UbiArt.Bundle {
	public class BundleFile : ICSerializable {
		public BundleBootHeader bootHeader;
		public FilePackMaster packMaster;
		private Dictionary<Path, ICSerializable> files = new Dictionary<Path, ICSerializable>();

		private Dictionary<Path, byte[]> readFileData = new Dictionary<Path, byte[]>();

		public void Serialize(CSerializerObject s, string name) {
			bootHeader = s.SerializeObject<BundleBootHeader>(bootHeader, name: nameof(bootHeader));
			packMaster = s.SerializeObject<FilePackMaster>(packMaster, name: nameof(packMaster));
		}

		public async UniTask SerializeAsync(CSerializerObject s, string name) {
			await s.FillCacheForRead(11 * 4);
			bootHeader = s.SerializeObject<BundleBootHeader>(bootHeader, name: nameof(bootHeader));
			await s.FillCacheForRead(bootHeader.baseOffset);
			packMaster = s.SerializeObject<FilePackMaster>(packMaster, name: nameof(packMaster));
		}

		public BundleFile() {
			bootHeader = new BundleBootHeader();
			packMaster = new FilePackMaster();
		}
		public Stream GetFileStream(Path path) {
			if (readFileData.ContainsKey(path)) return new MemoryStream(readFileData[path]);
			return null;
		}

		public async UniTask<byte[]> GetFile(Reader reader, Path path) {
			if (readFileData.ContainsKey(path)) return readFileData[path];
			if (packMaster != null) {
				FileHeaderRuntime h = packMaster.files.FirstOrDefault(f => f.Item2 == path)?.Item1;
				if (h != null) {
					ulong off = h.offsets[0];
					uint size = h.zSize != 0 ? h.zSize : h.size;
					reader.BaseStream.Position = (long)off + bootHeader.baseOffset;
					if (reader.BaseStream is UbiCanvas.Helpers.PartialHttpStream p) {
						await p.FillCacheForRead((int)size);
					}
					byte[] fileBytes = reader.ReadBytes((int)size);
					if (fileBytes != null) {
						if (h.zSize != 0) {
							byte[] decompressedData = new byte[(int)h.size];
							using (var zlibStream = new ZlibStream(new MemoryStream(fileBytes), CompressionMode.Decompress))
								zlibStream.Read(decompressedData, 0, decompressedData.Length);
							fileBytes = decompressedData;
						}
						readFileData[path] = fileBytes;
					}
					return fileBytes;
				}
			}
			return null;
		}

		public bool HasReadFile(Path path) {
			return readFileData.ContainsKey(path);
		}

		public void AddFile(Path path, ICSerializable data) {
			files[path] = data;
		}
		public async UniTask WriteBundle(string path) {
			bootHeader.numFiles = (uint)files.Keys.Count;
			List<byte[]> data = new List<byte[]>();
			uint curOffset = 0;
			byte[] serializedData = null;
			foreach (KeyValuePair<Path, ICSerializable> kv in files) {
				using (MemoryStream stream = new MemoryStream()) {
					using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
						CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
						MapLoader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, kv.Key.GetExtension(removeCooked: true));
						object toWrite = kv.Value;
						w.Serialize(ref toWrite, kv.Value.GetType(), name: kv.Key.filename);
						serializedData = stream.ToArray();
					}
				}
				FileHeaderRuntime fhr = new FileHeaderRuntime {
					numOffsets = 1,
					offsets = new ulong[1] { curOffset },
					size = (uint)serializedData.Length,
					zSize = 0,
					timeStamp = 0
				};
				packMaster.files.Add(new Pair<FileHeaderRuntime, Path>(fhr, kv.Key));
				data.Add(serializedData);
				curOffset += (uint)serializedData.Length;
				await TimeController.WaitIfNecessary();
			}
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
					MapLoader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, "ipk");
					object toWrite = this;
					w.Serialize(ref toWrite, GetType(), name: "Bundle");
					serializedData = stream.ToArray();
				}
			}
			await TimeController.WaitIfNecessary();
			bootHeader.baseOffset = (uint)serializedData.Length;
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
					MapLoader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, "ipk");
					object toWrite = this;
					w.Serialize(ref toWrite, GetType(), name: "Bundle");
					serializedData = stream.ToArray();
				}
			}
			await TimeController.WaitIfNecessary();
			using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create))) {
				bw.Write(serializedData);
				for (int i = 0; i < data.Count; i++) {
					bw.Write(data[i]);
				}
			}
		}
	}
}
