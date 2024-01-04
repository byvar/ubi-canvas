using ImageMagick;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;

namespace UbiCanvas.Conversion {
	public class TexturesBuilder : ProjectBuilder {

		public TexturesBuilder(string path) : base(path) { }

		public override string ID => "textures";

		protected override async Task BuildInternal() {
			await Task.CompletedTask;
			var inPath = System.IO.Path.Combine(ProjectPath, "textures");

			// Use alphabetical order. To prioritize a file being added, prefix the mod name with _
			foreach (var dir in System.IO.Directory.EnumerateDirectories(inPath).OrderBy(p => p)) {
				//string dirPath = dir.Substring(inputPath.Length).Replace('\\', '/').Trim('/');
				string dirPath = dir.Replace('\\', '/').Trim('/');
				foreach (string file in System.IO.Directory.GetFiles(dir, "*.*", System.IO.SearchOption.AllDirectories)) {
					string relativePath = file.Substring(dirPath.Length).Replace('\\', '/').TrimStart('/');

					string uncookedPath = relativePath;
					bool isDDS = uncookedPath.ToLowerInvariant().EndsWith(".dds");
					uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));

					// Check if this is a RGB texture that should be combined with an alpha texture
					if(uncookedPath.ToLowerInvariant().EndsWith(".a"))
						continue;
					bool isRGB = uncookedPath.ToLowerInvariant().EndsWith(".rgb");
					string alphaPath = null;
					if (isRGB) {
						alphaPath = file.Replace(".rgb", ".a");
						if (!System.IO.File.Exists(alphaPath)) {
							// .rgb and .a files might not have the same extension - workaround
							var newAlphaPath = alphaPath.ToLowerInvariant();
							newAlphaPath = newAlphaPath.Substring(0, newAlphaPath.LastIndexOf('.'));
							var matchingFile = System.IO.Directory
								.EnumerateFiles(dir, "*.*", System.IO.SearchOption.AllDirectories)
								.FirstOrDefault(f => f.Substring(0, f.LastIndexOf('.')).ToLowerInvariant() == newAlphaPath);
							if(matchingFile != null)
								alphaPath = matchingFile;
						}
						uncookedPath = uncookedPath.Substring(0, uncookedPath.LastIndexOf('.'));
					}

					if (!uncookedPath.ToLowerInvariant().EndsWith(".png") && !uncookedPath.ToLowerInvariant().EndsWith(".tga"))
						uncookedPath = $"{uncookedPath}.tga";
					var cookedPath = new Path(uncookedPath).CookedPath(TargetContext);

					if (!FileIsAlreadyBuilt(cookedPath)) {
						byte[] data = null;

						// Process texture
						ushort w, h;
						uint pixelsCountAlpha0 = 0, pixelsCountAlpha1 = 0;

						void CountPixels(MagickImage img) {
							if (img.HasAlpha) {
								using (var pc = img.GetPixels()) {
									int channelsCount = pc.Channels;
									for (int y = 0; y < img.Height; y++) {
										var pcv = pc.GetArea(0, y, img.Width, 1);
										for (int x = 0; x < pcv.Length; x += channelsCount) {
											switch (pcv[x + channelsCount - 1]) {
												case 0x00:
													pixelsCountAlpha0++; break;
												case 0xFF:
													pixelsCountAlpha1++; break;
											}
										}
									}
								}

								// Below: easier code, but super slow
								/*var pixels = img.GetPixels();
								foreach (var pixel in pixels) {
									var col = pixel.ToColor();
									if (col.A == 0xFF) {
										pixelsCountAlpha1++;
									} else if (col.A == 0) {
										pixelsCountAlpha0++;
									}
								}*/
							} else {
								pixelsCountAlpha0 = 0;
								pixelsCountAlpha1 = (uint)w * h;
							}
						}

						if (isDDS) {
							data = System.IO.File.ReadAllBytes(file);
							using (var img = new MagickImage(data, MagickFormat.Dds)) {
								w = (ushort)img.Width;
								h = (ushort)img.Height;

								CountPixels(img);
							}
						} else {
							if (isRGB && alphaPath != null) {
								// Separate RGB and A texture to be combined!
								using (var img = new MagickImage(file)) {
									using (var img_a = (System.IO.File.Exists(alphaPath) ? new MagickImage(alphaPath)
										: new MagickImage(Enumerable.Repeat((byte)0, img.Width * img.Height * 4).ToArray(), new PixelReadSettings(img.Width, img.Height, StorageType.Char, PixelMapping.ABGR)))) {
										img.Format = MagickFormat.Dds;
										img.Settings.SetDefine(MagickFormat.Dds, "compression", "none");
										img.AutoOrient(); // Orient TGA based on origin point
										w = (ushort)img.Width;
										h = (ushort)img.Height;

										img_a.Format = MagickFormat.Dds;
										img_a.Settings.SetDefine(MagickFormat.Dds, "compression", "none");
										img_a.AutoOrient(); // Orient TGA based on origin point
										if (w != (ushort)img_a.Width || h != (ushort)img_a.Height) {
											throw new Exception("Wrong alpha image dimensions");
										}
										// Step 1: Turn off the alpha channel for both input images
										img.Alpha(AlphaOption.Off);
										img_a.Alpha(AlphaOption.Off);

										// Step 2: Composite with the CopyAlpha operator
										img.Composite(img_a, CompositeOperator.CopyAlpha);


										CountPixels(img);
										data = img.ToByteArray();
									}
								}
							} else {
								using (var img = new MagickImage(file)) {
									img.Format = MagickFormat.Dds;
									img.Settings.SetDefine(MagickFormat.Dds, "compression", "none");
									img.AutoOrient(); // Orient TGA based on origin point
									w = (ushort)img.Width;
									h = (ushort)img.Height;
									CountPixels(img);
									data = img.ToByteArray();
								}
							}
						}
						var tex = new TextureCooked(TargetContext) {
							Data = data,
							Header = new TextureCookedHeader(TargetContext) {
								BPP = 32,
								CompressionType = 0,
								DataSize = (uint)data.Length,
								DataSize2 = (uint)data.Length,
								ImagesCount = 1,
								WrapModeU = TextureCookedHeader.WrapMode.Repeat,
								WrapModeV = TextureCookedHeader.WrapMode.Repeat,
								UnknownCRC = 0xFFFFFFFF,
								Width = w,
								Height = h,
								PixelsCountAlpha0 = pixelsCountAlpha0,
								PixelsCountAlpha1 = pixelsCountAlpha1
							}
						};
						Bundle.AddFile(cookedPath, tex);
					}
				}
			}
		}
	}
}
