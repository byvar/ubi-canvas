using ImageMagick;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;

namespace UbiCanvas.Conversion {
	public class SoundsBuilder : ProjectBuilder {

		public SoundsBuilder(string path) : base(path) { }

		public override string ID => "sounds";

		protected class WavChunk {
			public string ID { get; set; }
			public uint Size { get; set; }
			public byte[] Data { get; set; }

			public uint OffsetInRAKI { get; set; }
		}

		protected override async Task BuildInternal() {
			await Task.CompletedTask;
			var inPath = System.IO.Path.Combine(ProjectPath, "sounds");

			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in System.IO.Directory.GetFiles(dir, "*.*", System.IO.SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');

					string uncookedPath = relativePath;
					bool isWAV = uncookedPath.ToLowerInvariant().EndsWith(".wav");
					uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));
					uint soundFlags = 0;
					if (uncookedPath.EndsWith(".mus") || uncookedPath.EndsWith(".sfx") || uncookedPath.EndsWith(".amb")) {
						 soundFlags = uncookedPath.Substring(uncookedPath.Length - 3, 3) switch {
							 "mus" => 3,
							 "amb" => 1,
							 _ => 0
						 };
						uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));
					}
					uncookedPath = $"{uncookedPath}.wav";
					var cookedPath = new Path(uncookedPath).CookedPath(TargetContext);

					if (!FileIsAlreadyBuilt(cookedPath)) {
						byte[] data = null;

						/*byte[] pcmData = null;
						uint pcmDataSize = 0;
						uint headerDataSize = 76;
						ushort channelsCount = 2;
						uint sampleRate = 48000;
						ushort bitsPerSample = 16;
						ushort blockAlign = (ushort)((bitsPerSample * channelsCount) / 8);
						uint byteRate = (sampleRate * bitsPerSample * channelsCount) / 8;*/

						List<WavChunk> readChunks = new List<WavChunk>();

						using (var readMS = new System.IO.FileStream(file, System.IO.FileMode.Open)) {
							using (var r = new Reader(readMS, isLittleEndian: true)) {
								void ReadMagic(string magic) {
									if(r.ReadString(4, Encoding.UTF8) != magic)
										throw new Exception($"Magic not matched in wave file: {magic}");
								}

								ReadMagic("RIFF");
								r.ReadUInt32(); // file size - 8
								ReadMagic("WAVE");
								while (r.BaseStream.Position < r.BaseStream.Length) {
									var chunk = new WavChunk();
									chunk.ID = r.ReadString(4, Encoding.UTF8);
									chunk.Size = r.ReadUInt32();
									chunk.Data = r.ReadBytes((int)chunk.Size);
									readChunks.Add(chunk);
								}
							}
						}

						List<WavChunk> usedChunks = new List<WavChunk>() {
							readChunks.FirstOrDefault(c => c.ID == "fmt "),
							readChunks.FirstOrDefault(c => c.ID == "data")
						};

						uint headerDataSize = 9*4;
						headerDataSize += (uint)usedChunks.Count * 3 * 4;
						foreach (var c in usedChunks) {
							c.OffsetInRAKI = headerDataSize;
							if(c.ID != "data") headerDataSize += c.Size;
						}

						using (var ms = new System.IO.MemoryStream()) {
							using (var w = new Writer(ms, isLittleEndian: false)) {
								w.Write((uint)11);
								w.IsLittleEndian = true;

								w.WriteString("RAKI", 4, Encoding.UTF8);
								w.Write((uint)0);
								w.WriteString("Win ", 4, Encoding.UTF8);
								w.WriteString("pcm ", 4, Encoding.UTF8);
								w.Write((uint)headerDataSize); // Header size
								w.Write((uint)headerDataSize); // Start offset
								w.Write((uint)usedChunks.Count); // Chunks count
								w.Write((uint)soundFlags); // ??? Seems to be flags related to sound type. 0 = sfx, 1 = amb, 3 = mus
								foreach(var c in usedChunks) WriteChunkHeader(c);
								foreach(var c in usedChunks) WriteChunkData(c);



								void WriteChunkHeader(WavChunk c) {
									w.WriteString(c.ID, 4, Encoding.UTF8);
									w.Write((uint)c.OffsetInRAKI);
									w.Write((uint)c.Size);
								}
								void WriteChunkData(WavChunk c) {
									w.Write(c.Data);
								}

								/*
								// For each chunk: ID, chunk offset, chunk size.
								w.WriteString("fmt ", 4, Encoding.UTF8);
								w.Write((uint)60); // Format chunk offset
								w.Write((uint)16); // Format chunk size

								w.WriteString("data", 4, Encoding.UTF8);
								w.Write((uint)headerDataSize);
								w.Write((uint)pcmDataSize);

								// v Format chunk data. Same as in RIFF pcm header.
								w.Write((ushort)1); // PCM format
								w.Write((ushort)channelsCount);
								w.Write((uint)sampleRate);
								w.Write((uint)byteRate);
								w.Write((ushort)blockAlign);
								w.Write((ushort)bitsPerSample);
								// ^ format chunk data

								// v Data chunk data
								w.Write(pcmData);
								// ^ Data chunk data
								*/
								data = ms.ToArray();
							}
						}

						Bundle.AddFile(cookedPath, data);
					}
				}
			}
		}
	}
}
