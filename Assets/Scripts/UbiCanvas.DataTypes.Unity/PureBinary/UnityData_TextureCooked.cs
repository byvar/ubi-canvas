using System;
using UbiArt;
using UbiCanvas.Helpers;
using UnityEngine;

namespace UbiCanvas {
	public class UnityData_TextureCooked : UnityData<TextureCooked> {
		private Texture2D texture;
		private Texture2D squareTexture;
		private Texture2D[] subtextures;
		public Texture2D Texture {
			get {
				if (texture == null && LinkedObject.texData != null) {
					// For jpg & png:
					/*texture = new Texture2D(width, height, TextureFormat.ARGB32, false);
					texture.LoadImage(texData);
					texture.Apply();*/
					// Other formats:
					/*using (var img = new MagickImage(texData, MagickFormat.Dds)) {
						var pixels = img.GetPixels().GetValues();
						texture = new Texture2D(img.Width, img.Height, TextureFormat.ARGB32, false);
						texture.LoadImage(img.ToByteArray(MagickFormat.Png32));
						texture.Apply();
					}*/
					//UnityEngine.Debug.Log($"Texture - {texData.Length} - {width} - {height}");
					texture = LoadTextureDXT(LinkedObject.texData);
					if (texture == null) {
						using (DDSImage dds = new DDSImage(LinkedObject.texData)) {
							texture = dds.BitmapImage;
						}
					}
					//texture = LoadDDS(texData);
					//if (FileSystem.mode == FileSystem.Mode.Web) LinkedObject.texData = null;
				}
				return texture;
			}
		}

		/*private Texture2D LoadDDS(byte[] ddsBytes, bool updateMipMaps = false, bool makeNoLongerReadable = true) {
			PfimConfig pfimConfig = new PfimConfig();
			Dds dds = Dds.Create(ddsBytes, pfimConfig);
			dds.Decompress(); // Might not be needed, could do pfim config outside this in a Pfim class with Decompress set to true.
			TextureFormat fmt = GetTextureFormat(dds);
			Texture2D texture = new Texture2D(dds.Width, dds.Height, fmt, dds.Header.MipMapCount != 0);
			
			texture.LoadRawTextureData(dds.Data);
			texture.Apply(updateMipMaps, makeNoLongerReadable);
			return texture;
		}

		private TextureFormat GetTextureFormat(Dds dds) {
			switch (dds.Format) {
				case ImageFormat.Rgba16:
					return TextureFormat.RGBAHalf;
				case ImageFormat.Rgb24:
					return TextureFormat.RGB24;
				case ImageFormat.Rgba32:
					return TextureFormat.RGBA32;
				default:
					throw new NotImplementedException("ImageFormat " + dds.Format.ToString() + " to TextureFormat is not implemented.");
			}
		}*/

		public Texture2D SquareTexture {
			get {
				Texture2D tex = Texture;
				if (squareTexture == null && tex != null) {
					if (tex.width == tex.height) return tex;
					// TODO: This is only correct if width > height!
					// If height < width, UVs are still multiplied with width to get coordinate in pixels.
					// In other words. V can be over 1 and still inside the texture!
					int size = Math.Max(tex.width, tex.height);
					squareTexture = new Texture2D(size, size);
					squareTexture.SetPixels(0, 0, tex.width, tex.height, tex.GetPixels(0, 0, tex.width, tex.height));
					squareTexture.Apply(true, true);
				}
				return squareTexture;
			}
		}

		private static Texture2D LoadTextureDXT(byte[] ddsBytes) {
			TextureFormat format = TextureFormat.DXT5;
			switch (ddsBytes[87]) { // 84 - 87: DXT1 or DXT5 in ASCII
				case 0x31: // DXT1
					format = TextureFormat.DXT1;
					break;
				case 0x35: // DXT5
					format = TextureFormat.DXT5;
					break;
				default:
					return null;
					/*Debug.Log("Invalid TextureFormat. Only DXT1 and DXT5 formats are supported by this method.");
					throw new Exception("Invalid TextureFormat. Only DXT1 and DXT5 formats are supported by this method.");*/
			}

			byte ddsSizeCheck = ddsBytes[4];
			if (ddsSizeCheck != 124)
				throw new Exception("Invalid DDS DXTn texture. Unable to read");  //this header byte should be 124 for DDS image files

			int height = ddsBytes[13] << 8 | ddsBytes[12];
			int width = ddsBytes[17] << 8 | ddsBytes[16];

			int DDS_HEADER_SIZE = 128;
			byte[] dxtBytes = new byte[ddsBytes.Length - DDS_HEADER_SIZE];
			Array.Copy(ddsBytes, DDS_HEADER_SIZE, dxtBytes, 0, ddsBytes.Length - DDS_HEADER_SIZE);

			Texture2D texture = new Texture2D(width, height, format, false);
			texture.LoadRawTextureData(dxtBytes);
			if (width == height) {
				texture.Apply(true, true);
			} else {
				texture.Apply(true, false);
			}

			return (texture);
		}
	}
}