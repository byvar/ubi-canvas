using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using GXTConvert.FileFormat;

namespace GXTConvert.Conversion
{
    public static class PixelDataProviders
    {
        public static readonly Dictionary<SceGxmTextureFormat, uint> BPPMap = new Dictionary<SceGxmTextureFormat, uint>()
        {
            /* L8       */ { SceGxmTextureFormat.U8_1RRR, 32 },
            /* A8       */ { SceGxmTextureFormat.U8_R000, 32 },
            /* A8——111       */ { SceGxmTextureFormat.U8_R111, 32 },
            /* LA88     */ { SceGxmTextureFormat.U8U8_RGGG, 32 },
            /* RG88     */ { SceGxmTextureFormat.U8U8_00GR, 32 },
            /* ARGB1555 */ { SceGxmTextureFormat.U1U5U5U5_ARGB, 16 },
            /* ARGB4444 */ { SceGxmTextureFormat.U4U4U4U4_ARGB, 32 },
            /* RGB565   */ { SceGxmTextureFormat.U5U6U5_RGB, 16 },
            // RGBA8888 */ { SceGxmTextureFormat.U8U8U8U8_ABGR, PixelFormat.Undefined },
            /* ARGB8888 */ { SceGxmTextureFormat.U8U8U8U8_ARGB, 32 },
            /* DXT1     */ { SceGxmTextureFormat.UBC1_ABGR, 32 },
            /* DXT3     */ { SceGxmTextureFormat.UBC2_ABGR, 32 },
            /* DXT5     */ { SceGxmTextureFormat.UBC3_ABGR, 32 },
            /* DXT1     */ { SceGxmTextureFormat.UBC1_1BGR, 32 },
            /* PVRT2    */ { SceGxmTextureFormat.PVRT2BPP_ABGR, 32 },
            // PVRT2    */ { SceGxmTextureFormat.PVRT2BPP_1BGR, PixelFormat.Undefined },
            /* PVRT4    */ { SceGxmTextureFormat.PVRT4BPP_ABGR, 32 },
            // PVRT4    */ { SceGxmTextureFormat.PVRT4BPP_1BGR, PixelFormat.Undefined },
            // PVRTII2  */ { SceGxmTextureFormat.PVRTII2BPP_ABGR, PixelFormat.Undefined },
            // PVRTII2  */ { SceGxmTextureFormat.PVRTII2BPP_1BGR, PixelFormat.Undefined },
            // PVRTII4  */ { SceGxmTextureFormat.PVRTII4BPP_ABGR, PixelFormat.Undefined },
            // PVRTII4  */ { SceGxmTextureFormat.PVRTII4BPP_1BGR, PixelFormat.Undefined },
            /* RGB888   */ { SceGxmTextureFormat.U8U8U8_RGB, 24 },
            /* RGB888X  */ { SceGxmTextureFormat.U8U8U8X8_RGB1, 32 },
            /* P4       */ { SceGxmTextureFormat.P4_ABGR, 4 },
            /*          */ { SceGxmTextureFormat.P4_ARGB, 4 },
            /*          */ { SceGxmTextureFormat.P4_RGBA, 4 },
            /*          */ { SceGxmTextureFormat.P4_BGRA, 4 },
            /*          */ { SceGxmTextureFormat.P4_1BGR, 4 },
            /*          */ { SceGxmTextureFormat.P4_1RGB, 4 },
            /*          */ { SceGxmTextureFormat.P4_RGB1, 4 },
            /*          */ { SceGxmTextureFormat.P4_BGR1, 4 },
            /* P8       */ { SceGxmTextureFormat.P8_ABGR, 8 },
            /*          */ { SceGxmTextureFormat.P8_ARGB, 8 },
            /*          */ { SceGxmTextureFormat.P8_RGBA, 8 },
            /*          */ { SceGxmTextureFormat.P8_BGRA, 8 },
            /*          */ { SceGxmTextureFormat.P8_1BGR, 8 },
            /*          */ { SceGxmTextureFormat.P8_1RGB, 8 },
            /*          */ { SceGxmTextureFormat.P8_RGB1, 8 },
            /*          */ { SceGxmTextureFormat.P8_BGR1, 8 },
        };

        public delegate byte[] ProviderFunctionDelegate(BinaryReader reader, SceGxtTextureInfo info);

        public static readonly Dictionary<SceGxmTextureFormat, ProviderFunctionDelegate> ProviderFunctions = new Dictionary<SceGxmTextureFormat, ProviderFunctionDelegate>()
        {
            { SceGxmTextureFormat.U8_1RRR, new ProviderFunctionDelegate(PixelProviderU8_1RRR) },
            { SceGxmTextureFormat.U8_R000, new ProviderFunctionDelegate(PixelProviderU8_R000) }, // TODO: verify me!
            { SceGxmTextureFormat.U8_R111, new ProviderFunctionDelegate(PixelProviderU8_R111) }, // TODO: verify me!
            { SceGxmTextureFormat.U8U8_RGGG, new ProviderFunctionDelegate(PixelProviderU8U8_RGGG) }, // TODO: verify me!
            { SceGxmTextureFormat.U8U8_00GR, new ProviderFunctionDelegate(PixelProviderU8U8_00GR) }, // TODO: verify me!
            { SceGxmTextureFormat.U1U5U5U5_ARGB, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.U4U4U4U4_ARGB, new ProviderFunctionDelegate(PixelProviderU4U4U4U4_ARGB) }, // TODO: verify me!
            { SceGxmTextureFormat.U5U6U5_RGB, new ProviderFunctionDelegate(PixelProviderDirect) }, // TODO: verify me!
            { SceGxmTextureFormat.U8U8U8U8_ARGB, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.UBC1_ABGR, new ProviderFunctionDelegate(PixelProviderDXTx) },
            { SceGxmTextureFormat.UBC2_ABGR, new ProviderFunctionDelegate(PixelProviderDXTx) },
            { SceGxmTextureFormat.UBC3_ABGR, new ProviderFunctionDelegate(PixelProviderDXTx) },
			{ SceGxmTextureFormat.UBC1_1BGR, new ProviderFunctionDelegate(PixelProviderDXTx) },
			{ SceGxmTextureFormat.PVRT2BPP_ABGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            //{ SceGxmTextureFormat.PVRT2BPP_1BGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            { SceGxmTextureFormat.PVRT4BPP_ABGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            //{ SceGxmTextureFormat.PVRT4BPP_1BGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            //{ SceGxmTextureFormat.PVRTII2BPP_ABGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            //{ SceGxmTextureFormat.PVRTII2BPP_1BGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            //{ SceGxmTextureFormat.PVRTII4BPP_ABGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            //{ SceGxmTextureFormat.PVRTII4BPP_1BGR, new ProviderFunctionDelegate(PixelProviderPVRTC) },
            { SceGxmTextureFormat.U8U8U8_RGB, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.U8U8U8X8_RGB1, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P4_ABGR, new ProviderFunctionDelegate(PixelProviderP4) }, // TODO: verify ALL these once files or bug reports come in!
            { SceGxmTextureFormat.P4_ARGB, new ProviderFunctionDelegate(PixelProviderP4) },
            { SceGxmTextureFormat.P4_RGBA, new ProviderFunctionDelegate(PixelProviderP4) },
            { SceGxmTextureFormat.P4_BGRA, new ProviderFunctionDelegate(PixelProviderP4) },
            { SceGxmTextureFormat.P4_1BGR, new ProviderFunctionDelegate(PixelProviderP4) },
            { SceGxmTextureFormat.P4_1RGB, new ProviderFunctionDelegate(PixelProviderP4) },
            { SceGxmTextureFormat.P4_RGB1, new ProviderFunctionDelegate(PixelProviderP4) },
            { SceGxmTextureFormat.P4_BGR1, new ProviderFunctionDelegate(PixelProviderP4) },
            { SceGxmTextureFormat.P8_ABGR, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P8_ARGB, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P8_RGBA, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P8_BGRA, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P8_1BGR, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P8_1RGB, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P8_RGB1, new ProviderFunctionDelegate(PixelProviderDirect) },
            { SceGxmTextureFormat.P8_BGR1, new ProviderFunctionDelegate(PixelProviderDirect) },
        };

        private static byte[] PixelProviderDirect(BinaryReader reader, SceGxtTextureInfo info)
        {
            return reader.ReadBytes((int)info.DataSize);
        }

        private static byte[] PixelProviderDXTx(BinaryReader reader, SceGxtTextureInfo info)
        {
            return Compression.DXTx.Decompress(reader, info);
        }

        private static byte[] PixelProviderPVRTC(BinaryReader reader, SceGxtTextureInfo info)
        {
            return Compression.PVRTC.Decompress(reader, info);
        }

        private static byte[] PixelProviderP4(BinaryReader reader, SceGxtTextureInfo info)
        {
            byte[] pixelData = new byte[info.DataSize];
            for (int i = 0; i < pixelData.Length; i++)
            {
                byte idx = reader.ReadByte();
                pixelData[i] = (byte)(idx >> 4 | idx << 4);
            }
            return pixelData;
        }

        private static byte[] PixelProviderU8_1RRR(BinaryReader reader, SceGxtTextureInfo info)
        {
            byte[] pixelData = new byte[info.DataSize * 4];
            for (int i = 0; i < pixelData.Length; i += 4)
            {
                pixelData[i + 0] = pixelData[i + 1] = pixelData[i + 2] = reader.ReadByte();
                pixelData[i + 3] = 0xFF;
            };
            return pixelData;
        }

        private static byte[] PixelProviderU8_R000(BinaryReader reader, SceGxtTextureInfo info)
        {
            byte[] pixelData = new byte[info.DataSize * 4];
            for (int i = 0; i < pixelData.Length; i += 4)
            {
                pixelData[i + 0] = pixelData[i + 1] = pixelData[i + 2] = 0x00;
                pixelData[i + 3] = reader.ReadByte();
            };
            return pixelData;
        }

        private static byte[] PixelProviderU8_R111(BinaryReader reader, SceGxtTextureInfo info)
        {
            byte[] pixelData = new byte[info.DataSize * 4];
            for (int i = 0; i < pixelData.Length; i += 4)
            {
                pixelData[i + 0] = pixelData[i + 1] = pixelData[i + 2] = 0xff;
                pixelData[i + 3] = reader.ReadByte();
            };
            return pixelData;
        }

        private static byte[] PixelProviderU8U8_RGGG(BinaryReader reader, SceGxtTextureInfo info)
        {
            byte[] pixelData = new byte[info.DataSize * 4];
            for (int i = 0; i < pixelData.Length; i += 4)
            {
                pixelData[i + 3] = reader.ReadByte();
                pixelData[i + 0] = pixelData[i + 1] = pixelData[i + 2] = reader.ReadByte();
            };
            return pixelData;
        }

        private static byte[] PixelProviderU8U8_00GR(BinaryReader reader, SceGxtTextureInfo info)
        {
            byte[] pixelData = new byte[info.DataSize * 4];
            for (int i = 0; i < pixelData.Length; i += 4)
            {
                pixelData[i + 1] = reader.ReadByte();
                pixelData[i + 2] = reader.ReadByte();
                pixelData[i + 0] = pixelData[i + 3] = 0x00;
            };
            return pixelData;
        }

        private static byte[] PixelProviderU4U4U4U4_ARGB(BinaryReader reader, SceGxtTextureInfo info)
        {
            byte[] pixelData = new byte[info.DataSize * 4];
            for (int i = 0; i < pixelData.Length; i += 4)
            {
                ushort rgba = reader.ReadUInt16();
                pixelData[i + 0] = (byte)(((rgba >> 4) << 4) & 0xFF);
                pixelData[i + 1] = (byte)(((rgba >> 8) << 4) & 0xFF);
                pixelData[i + 2] = (byte)(((rgba >> 12) << 4) & 0xFF);
                pixelData[i + 3] = (byte)((rgba << 4) & 0xFF);
            };
            return pixelData;
        }
    }
}
