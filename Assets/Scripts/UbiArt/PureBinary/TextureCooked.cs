using UbiArt.FileFormat.Texture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using System.Diagnostics;

namespace UbiArt {
	public class TextureCooked : ICSerializable {
		public static uint staticSignature = 0x54455800; // TEX\0
		public uint version; // 0xD for legends, 0x11 for adventures
		public uint signature;
		public uint hdrSize;
		public uint texSize;
		public ushort width;
		public ushort height;
		public ushort unk_x; // tiling flags?
		public ushort unk_y;
		public uint unkAdventures;
		public uint texSize2;
		public uint unk0;
		public uint unk1;
		public uint unk2;
		public uint unk3;
		public uint unk4;
		public uint unk5;
		public byte[] texData;
		
		public UV.UVAtlas atlas = null;

		public void Serialize(CSerializerObject s, string name) {
			if (Settings.s.engineVersion > Settings.EngineVersion.RO) {
				version = s.Serialize<uint>(version);
				signature = s.Serialize<uint>(signature);
				hdrSize = s.Serialize<uint>(hdrSize);
				texSize = s.Serialize<uint>(texSize);
				width = s.Serialize<ushort>(width);
				height = s.Serialize<ushort>(height);
				unk_x = s.Serialize<ushort>(unk_x);
				unk_y = s.Serialize<ushort>(unk_y);
				if (Settings.s.game == Settings.Game.RA) {
					unkAdventures = s.Serialize<uint>(unkAdventures);
				}
				texSize2 = s.Serialize<uint>(texSize2);
				unk0 = s.Serialize<uint>(unk0);
				unk1 = s.Serialize<uint>(unk1);
				unk2 = s.Serialize<uint>(unk2);
				unk3 = s.Serialize<uint>(unk3);
				unk4 = s.Serialize<uint>(unk4);
				unk5 = s.Serialize<uint>(unk5);
			} else {
				s.SerializeFileSize(ref texSize);
			}
			s.SerializeBytes(ref texData, (int)texSize);
		}

		private Texture2D texture;
		private Texture2D squareTexture;
		private Texture2D[] subtextures;
		public Texture2D Texture {
			get {
				if (texture == null && texData != null) {
					//texture = new Texture2D(width, height);
					using (DDSImage dds = new DDSImage(texData)) {
						texture = dds.BitmapImage;
						/*if (texture.width != width || texture.height != height) {
							MapLoader.Loader.print("Width: " + texture.width + " - " + width);
							MapLoader.Loader.print("Height: " + texture.height + " - " + height);
						}*/
					}
					//texture = LoadTextureDXT(texData);
				}
				return texture;
			}
		}
		public Texture2D SquareTexture {
			get {
				Texture2D tex = Texture;
				if (squareTexture == null && tex != null) {
					if (tex.width == tex.height) return tex;
					int size = Math.Max(tex.width, tex.height);
					squareTexture = new Texture2D(size, size);
					squareTexture.SetPixels(0, 0, tex.width, tex.height, tex.GetPixels(0,0,tex.width, tex.height));
					squareTexture.Apply();
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

			int height = ddsBytes[13] * 256 + ddsBytes[12];
			int width = ddsBytes[17] * 256 + ddsBytes[16];

			int DDS_HEADER_SIZE = 128;
			byte[] dxtBytes = new byte[ddsBytes.Length - DDS_HEADER_SIZE];
			Buffer.BlockCopy(ddsBytes, DDS_HEADER_SIZE, dxtBytes, 0, ddsBytes.Length - DDS_HEADER_SIZE);

			Texture2D texture = new Texture2D(width, height, format, false);
			texture.LoadRawTextureData(dxtBytes);
			texture.Apply();

			return (texture);
		}
	}
}
