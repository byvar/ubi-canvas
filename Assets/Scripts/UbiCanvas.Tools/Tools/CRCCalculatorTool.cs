using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.CRC;
using UbiArt.ITF;
using UbiCanvas.Helpers;
using Path = UbiArt.Path;
using Stream = System.IO.Stream;

namespace UbiCanvas.Tools
{
	public class CRCCalculatorTool : GameTool
	{
		public CRCCalculatorTool() { }

        public override string Name => "UbiArt StringCRC Calculator";
		public override string Description => "Useful for all kinds of CRC calculations";

		public uint CalculateStringCRC(string str) => new StringID(str).stringID;
		public uint CalculateCRC(string str, uint? classType) => GetCRC(str, classTypeInt: classType);

		protected uint GetCRC(string str, uint? classTypeInt) {
			byte[] stringBytes = ASCIIEncoding.ASCII.GetBytes(str);
			Crc crc = new Crc(new Parameters("CRC-32", 32, 0x04C11DB7, 0xFFFFFFFF, false, false, 0xFFFFFFFF, 0xCBF43926));
			uint computedCRC = CrcHelper.ToUInt32(crc.ComputeHash(stringBytes));
			if (classTypeInt.HasValue) {
				byte[] classType = BitConverter.GetBytes(classTypeInt.Value);
				crc = new Crc(new Parameters("CRC-32", 32, 0x04C11DB7, computedCRC, false, false, 0xFFFFFFFF, 0xCBF43926));
				return CrcHelper.ToUInt32(crc.ComputeHash(classType));
			} else {
				return computedCRC;
			}
		}

		public string StringCRC => CurrentString == null ? "None" : $"{CalculateStringCRC(CurrentString):X8}";
		public string CRC(uint? classType) => CurrentString == null ? "None" : $"{CalculateCRC(CurrentString, classType: classType):X8}";

		// Don't need to save these, so we store these locally here
		public string CurrentString { get; set; } = "";
		public uint CustomType { get; set; } = 200;
		public bool ShowRegularCRCDropdown { get; set; }
	}
}