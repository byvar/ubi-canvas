using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[Flags]
	public enum SerializeFlags {
		None = 0,
		Flags0 = 1,
		Flags1 = 1 << 1,
		Flags2 = 1 << 2,
		StoreObjectSizes = 1 << 3,
		Flags4 = 1 << 4,
		Flags5 = 1 << 5,
		Flags6 = 1 << 6,
		Flags7 = 1 << 7,
		Flags8 = 1 << 8,
		Flags9 = 1 << 9,
		Flags10 = 1 << 10,
		Flags11 = 1 << 11,
		Flags12 = 1 << 12,
		Flags13 = 1 << 13,
		Flags14 = 1 << 14,
		Flags15 = 1 << 15,
		Flags16 = 1 << 16,
		Flags17 = 1 << 17,
		Flags18 = 1 << 18,
		Flags19 = 1 << 19,
		Flags20 = 1 << 20,
		Flags21 = 1 << 21,
		Flags22 = 1 << 22,
		Flags23 = 1 << 23,
		Flags24 = 1 << 24,
		Flags25 = 1 << 25,
		Flags26 = 1 << 26,
		Flags27 = 1 << 27,
		Flags28 = 1 << 28,
		Flags29 = 1 << 29,
		Flags30 = 1 << 30,
		Flags31 = 1 << 31,
		Persistent = Flags2 | StoreObjectSizes,
		Flags_xC0 = Flags6 | Flags7,
		Flags_x30 = Flags4 | Flags5,
		Flags_x03 = Flags0 | Flags1,
		Flags_0xF = Flags_x03 | Persistent,
		Default = Flags_x03 | Flags_xC0,
	}
}
