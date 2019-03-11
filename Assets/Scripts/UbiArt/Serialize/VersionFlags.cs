using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UbiArt {
	[Flags]
	public enum VersionFlags {
		None = 0,
		Origins = 1,
		Legends = 1 << 1,
		Adventures = 1 << 2,
		NotAdventures = Origins | Legends,
		NotLegends = Origins | Adventures,
		NotOrigins = Legends | Adventures,
		All = Origins | Legends | Adventures
	}
}
