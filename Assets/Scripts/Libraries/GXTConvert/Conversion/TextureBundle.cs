using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using UnityEngine;

using GXTConvert.Exceptions;
using GXTConvert.FileFormat;
using BinarySerializer;

namespace GXTConvert.Conversion
{
    // For convenience sake, to bundle (most of) the essential texture information
    public class TextureBundle
    {
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int PaletteIndex { get; private set; }
        public int RawLineSize { get; private set; }
        public SceGxmTextureFormat TextureFormat { get; private set; }

        public UnityEngine.TextureFormat PixelFormat { get; private set; }
		public uint BPP { get; private set; }
        public byte[] PixelData { get; private set; }
        public int RoundedWidth { get; private set; }
        public int RoundedHeight { get; private set; }

        bool isCompressed;

        public TextureBundle(BinaryReader reader, SceGxtHeader header, SceGxtTextureInfo info)
        {
            reader.BaseStream.Seek(info.DataOffset, SeekOrigin.Begin);

            Width = info.GetWidth();
            Height = info.GetHeight();
            PaletteIndex = info.PaletteIndex;
            RawLineSize = (int)(info.DataSize / info.GetHeightRounded());
            TextureFormat = info.GetTextureFormat();

			if (!PixelDataProviders.BPPMap.ContainsKey(TextureFormat) || !PixelDataProviders.ProviderFunctions.ContainsKey(TextureFormat)) {
				UnityEngine.Debug.Log(TextureFormat);
				throw new FormatNotImplementedException(TextureFormat);
			}
            BPP = PixelDataProviders.BPPMap[TextureFormat];
            PixelData = PixelDataProviders.ProviderFunctions[TextureFormat](reader, info);

            SceGxmTextureBaseFormat textureBaseFormat = info.GetTextureBaseFormat();

            // TODO, taken from Scarlet: verify me! Compressed formats need rounded dimensions (PuyoTet misc leftovers), uncompressed do not (DB:FC special illust)?

            isCompressed = (textureBaseFormat == SceGxmTextureBaseFormat.UBC1 || textureBaseFormat == SceGxmTextureBaseFormat.UBC2 || textureBaseFormat == SceGxmTextureBaseFormat.UBC3 ||
                textureBaseFormat == SceGxmTextureBaseFormat.PVRT2BPP || textureBaseFormat == SceGxmTextureBaseFormat.PVRT4BPP ||
                textureBaseFormat == SceGxmTextureBaseFormat.PVRTII2BPP || textureBaseFormat == SceGxmTextureBaseFormat.PVRTII4BPP);

            if (isCompressed)
            {
                RoundedWidth = info.GetWidthRounded();
                RoundedHeight = info.GetHeightRounded();
            }
            else
            {
                RoundedWidth = Width;
                RoundedHeight = Height;
            }

            // TODO: is this right? PVRTC/PVRTC2 doesn't need this, but everything else does?
            if (textureBaseFormat != SceGxmTextureBaseFormat.PVRT2BPP && textureBaseFormat != SceGxmTextureBaseFormat.PVRT4BPP &&
                textureBaseFormat != SceGxmTextureBaseFormat.PVRTII2BPP && textureBaseFormat != SceGxmTextureBaseFormat.PVRTII4BPP)
            {
                SceGxmTextureType textureType = info.GetTextureType();
                switch (textureType)
                {
                    case SceGxmTextureType.Linear:
                        // Nothing to be done!
                        break;

                    case SceGxmTextureType.Tiled:
                        // TODO: verify me!
                        PixelData = PostProcessing.UntileTexture(PixelData, RoundedWidth, RoundedHeight, BPP);
                        break;

                    case SceGxmTextureType.Swizzled:
                    case SceGxmTextureType.Cube:
                        // TODO: is cube really the same as swizzled? seems that way from CS' *env* files...
                        PixelData = PostProcessing.UnswizzleTexture(PixelData, RoundedWidth, RoundedHeight, BPP);
                        break;

                    case (SceGxmTextureType)0xA0000000:
                        // TODO: mehhhhh
                        PixelData = PostProcessing.UnswizzleTexture(PixelData, RoundedWidth, RoundedHeight, BPP);
                        break;

                    default:
                        throw new TypeNotImplementedException(textureType);
                }
            }
        }

        public Texture2D CreateTexture(Color[] palette = null)
        {
			Texture2D texture = new Texture2D(Width, Height);
			// DRL: Some variables because I took this from Ray1Map
			var imgData = PixelData;
			var imgDataOffset = 0;
			var flipRegionY = false;
			var flipRegionX = false;
			var reverseOrder = false;
			var regionHeight = Height;
			var regionWidth = Width;
			if (palette != null) {
				switch (BPP) {
					case 4:
						for (int y = 0; y < regionHeight; y++) {
							for (int x = 0; x < regionWidth; x++) {
								Color? c = null;
								int index = imgDataOffset + (((flipRegionY ? (regionHeight - y - 1) : y) * regionWidth + (flipRegionX ? (regionWidth - x - 1) : x)) / 2);

								var b = imgData[index];
								var v = (flipRegionX ^ reverseOrder) ?
									BitHelpers.ExtractBits(b, 4, x % 2 == 1 ? 0 : 4) :
									BitHelpers.ExtractBits(b, 4, x % 2 == 0 ? 0 : 4);

								c = palette[v];

								if (c.HasValue) {
									texture.SetPixel(x, y, c.Value);
								}
							}
						}
						break;
					case 8:
						for (int y = 0; y < regionHeight; y++) {
							for (int x = 0; x < regionWidth; x++) {
								Color? c = null;
								int index = imgDataOffset + (((flipRegionY ? (regionHeight - y - 1) : y) * regionWidth + (flipRegionX ? (regionWidth - x - 1) : x)) / 2);

								var b = imgData[index];

								c = palette[b];
								if (c.HasValue) {
									texture.SetPixel(x, y, c.Value);
								}
							}
						}
						break;
				}
			} else {

				for (int y = 0; y < regionHeight; y++) {
					for (int x = 0; x < regionWidth; x++) {
						Color? c = null;
						int index = imgDataOffset + (((flipRegionY ? (regionHeight - y - 1) : y) * regionWidth + (flipRegionX ? (regionWidth - x - 1) : x))) * ((int)BPP / 8);

						switch (BPP) {
							case 32:
								if (TextureFormat == SceGxmTextureFormat.U8U8U8X8_RGB1 /*|| TextureFormat == SceGxmTextureFormat.UBC1_1BGR*/) {
									c = GxtBinary.ColorFromArgb(255 /*imgData[0]*/, imgData[index + 2], imgData[index + 1], imgData[index + 0]);
								} else {
									c = GxtBinary.ColorFromArgb(imgData[index+3], imgData[index + 2], imgData[index + 1], imgData[index + 0]);
								}
								break;
							case 24:
								c = GxtBinary.ColorFromArgb(255, imgData[index + 0], imgData[index + 1], imgData[index + 2]);
								break;
							case 16:
								break;
						}

						if (c.HasValue) {
							texture.SetPixel(x, y, c.Value);
						}
					}
				}
			}
			texture.Apply();
            return texture;
        }
    }
}
