using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[Flags]
	public enum GameFlags {
		None = 0,
		RO = 1,
		RJR = 1 << 1,
		RFR = 1 << 2,
		RL = 1 << 3,
		COL = 1 << 4,
		VH = 1 << 5,
		RA = 1 << 6,
		ROVersion = RO | RJR | RFR,
		RLVersion = RL | COL,
		RAVersion = RA | VH,
		All = RO | RJR | RFR | RL | COL | VH | RA
	}
}
