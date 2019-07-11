using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.IO;

namespace UbiArt.Bundle {
	public class BundleFile : ICSerializable {
		public BundleBootHeader bootHeader;
		public FilePackMaster packMaster;
		private Dictionary<Path, ICSerializable> files = new Dictionary<Path, ICSerializable>();

		public void Serialize(CSerializerObject s, string name) {
			s.Serialize(ref bootHeader);
			s.Serialize(ref packMaster);
		}

		public BundleFile() {
			bootHeader = new BundleBootHeader();
			packMaster = new FilePackMaster();
		}

		public void AddFile(Path path, ICSerializable data) {
			files[path] = data;
		}
		public async Task WriteBundle(string path) {
			bootHeader.numFiles = (uint)files.Keys.Count;
			List<byte[]> data = new List<byte[]>();
			uint curOffset = 0;
			byte[] serializedData = null;
			foreach (KeyValuePair<Path, ICSerializable> kv in files) {
				using (MemoryStream stream = new MemoryStream()) {
					using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
						CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
						MapLoader.Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, kv.Key.GetExtension(removeCooked: true));
						object toWrite = kv.Value;
						w.Serialize(ref toWrite, kv.Value.GetType(), name: kv.Key.filename, defaultValue: null);
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
				await MapLoader.WaitFrame();
			}
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
					MapLoader.Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, "ipk");
					object toWrite = this;
					w.Serialize(ref toWrite, GetType(), name: "Bundle", defaultValue: null);
					serializedData = stream.ToArray();
				}
			}
			await MapLoader.WaitFrame();
			bootHeader.baseOffset = (uint)serializedData.Length;
			using (MemoryStream stream = new MemoryStream()) {
				using (Writer writer = new Writer(stream, Settings.s.IsLittleEndian)) {
					CSerializerObjectBinaryWriter w = new CSerializerObjectBinaryWriter(writer);
					MapLoader.Loader.ConfigureSerializeFlagsForExtension(ref w.flags, ref w.flagsOwn, "ipk");
					object toWrite = this;
					w.Serialize(ref toWrite, GetType(), name: "Bundle", defaultValue: null);
					serializedData = stream.ToArray();
				}
			}
			await MapLoader.WaitFrame();
			using (BinaryWriter bw = new BinaryWriter(new FileStream(path, FileMode.Create))) {
				bw.Write(serializedData);
				for (int i = 0; i < data.Count; i++) {
					bw.Write(data[i]);
				}
			}
		}
	}
}
