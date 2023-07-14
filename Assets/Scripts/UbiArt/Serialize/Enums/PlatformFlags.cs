using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[Flags]
	public enum PlatformFlags {
		None = 0,
		PC = 1 << 0,
		Android = 1 << 1,
		iOS = 1 << 2,
		Vita = 1 << 3,
		MacOS = 1 << 4,
		WiiU = 1 << 5,
		Mobile = Android | iOS,
		DRCPlatforms = Vita | WiiU,
		All = PC | Android | iOS | Vita | MacOS | WiiU
	}
}
