
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PVRImageWrapper {

	public static class PVRUnityExtensions {
		public static TextureFormat GetTextureFormat(this PVRImage image) {
			switch (image.pixelFormat) {
				case PVRImage.PixelFormat.PVRTC_2bpp_RGB: return TextureFormat.PVRTC_RGB2;
				case PVRImage.PixelFormat.PVRTC_2bpp_RGBA: return TextureFormat.PVRTC_RGBA2;
				case PVRImage.PixelFormat.PVRTC_4bpp_RGB: return TextureFormat.PVRTC_RGB4;
				case PVRImage.PixelFormat.PVRTC_4bpp_RGBA: return TextureFormat.PVRTC_RGBA4;
				//case PVRImage.PixelFormat.PVRTCII_2bpp: return TextureFormat.
				//case PVRImage.PixelFormat.PVRTCII_4bpp: return TextureFormat.
				case PVRImage.PixelFormat.ETC1: return TextureFormat.ETC_RGB4;
				case PVRImage.PixelFormat.DXT1: return TextureFormat.DXT1;
				//case PVRImage.PixelFormat.DXT2: return TextureFormat.
				//case PVRImage.PixelFormat.DXT3: return TextureFormat.
				//case PVRImage.PixelFormat.DXT4: return TextureFormat.
				case PVRImage.PixelFormat.DXT5: return TextureFormat.DXT5;
				case PVRImage.PixelFormat.BC4: return TextureFormat.BC4;
				case PVRImage.PixelFormat.BC5: return TextureFormat.BC5;
				//case PVRImage.PixelFormat.BC6: return TextureFormat.BC6H;  //not sure about this
				case PVRImage.PixelFormat.BC7: return TextureFormat.BC7;
				//case PVRImage.PixelFormat.UYVY: return TextureFormat.
				case PVRImage.PixelFormat.YUY2: return TextureFormat.YUY2;
				//case PVRImage.PixelFormat.BW1bpp: return TextureFormat.
				//case PVRImage.PixelFormat.R9G9B9E5_Shared_Exponent: return TextureFormat.
				//case PVRImage.PixelFormat.RGBG8888: return TextureFormat.
				//case PVRImage.PixelFormat.GRGB8888: return TextureFormat.
				case PVRImage.PixelFormat.ETC2_RGB: return TextureFormat.ETC2_RGB;
				case PVRImage.PixelFormat.ETC2_RGBA: return TextureFormat.ETC2_RGBA8;
				case PVRImage.PixelFormat.ETC2_RGB_A1: return TextureFormat.ETC2_RGBA1;
				//case PVRImage.PixelFormat.EAC_R11: return TextureFormat.
				//case PVRImage.PixelFormat.EAC_RG11: return TextureFormat.
				case PVRImage.PixelFormat.ASTC_4x4: return TextureFormat.ASTC_4x4;
				//case PVRImage.PixelFormat.ASTC_5x4: return TextureFormat.ASTC
				case PVRImage.PixelFormat.ASTC_5x5: return TextureFormat.ASTC_5x5;
				//case PVRImage.PixelFormat.ASTC_6x5: return TextureFormat.
				case PVRImage.PixelFormat.ASTC_6x6: return TextureFormat.ASTC_6x6;
				//case PVRImage.PixelFormat.ASTC_8x5: return TextureFormat.
				//case PVRImage.PixelFormat.ASTC_8x6: return TextureFormat.
				case PVRImage.PixelFormat.ASTC_8x8: return TextureFormat.ASTC_8x8;
				//case PVRImage.PixelFormat.ASTC_10x5: return TextureFormat.
				//case PVRImage.PixelFormat.ASTC_10x6: return TextureFormat.
				//case PVRImage.PixelFormat.ASTC_10x8: return TextureFormat.
				case PVRImage.PixelFormat.ASTC_10x10: return TextureFormat.ASTC_10x10;
				//case PVRImage.PixelFormat.ASTC_12x10: return TextureFormat.
				case PVRImage.PixelFormat.ASTC_12x12: return TextureFormat.ASTC_12x12;
					/* case PVRImage.PixelFormat.ASTC_3x3x3: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_4x3x3: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_4x4x3: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_4x4x4: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_5x4x4: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_5x5x4: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_5x5x5: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_6x5x5: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_6x6x5: return TextureFormat.
					case PVRImage.PixelFormat.ASTC_6x6x6: return TextureFormat. */
			}
			throw new UnityException("Unsupported PixelFormat! " + image.pixelFormat.ToString());
		}

		public static bool IsValidTextureFormat(this PVRImage image) {
			//it's either this or just catch an exception.
			switch ((int)image.pixelFormat) {
				case 0:
				case 1:
				case 2:
				case 3:
				case 6:
				case 7:
				case 11:
				case 12:
				case 13:
				case 15:
				case 17:
				case 22:
				case 23:
				case 24:
				case 27:
				case 29:
				case 31:
				case 34:
				case 38:
				case 40:
					return true;
				default:
					return false;
			}

		}

		public static Texture2D LoadIntoTexture(this PVRImage image) {
			Texture2D texture = new Texture2D(image.Width, image.Height, image.GetTextureFormat(), image.MipMapCount, image.isLinear);
			image.LoadIntoTexture(texture);
			return texture;
		}
		public static void LoadIntoTexture(this PVRImage image, Texture2D texture) {

			texture.LoadRawTextureData(image.GetTextureData());
		}
	}

}