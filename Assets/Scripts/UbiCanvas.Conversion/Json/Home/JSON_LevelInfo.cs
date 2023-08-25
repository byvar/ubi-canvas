using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_LevelInfo {
		public string MapID { get; set; }
		public uint NameID { get; set; } // LocId 4721 will be used for testing
		public string MapPath { get; set; }
		public string[] MapDependencies { get; set; } // list of MapIDs of maps you need to finish before this one
		public string WorldID { get; set; }
		//public int TeensyUnlockCount { get; set; } // Seems to be always 0
		public string TexturePath { get; set; }
		public int TeensyCount { get; set; } // 0, 3 or 10 only
		public int LumsCount { get; set; }
		public int Difficulty { get; set; }
		public string ScoreRecapPath { get; set; }  // Path of score recap screen (null for default)
		public string Loading { get; set; } // Path of loading screen when entering (null for default)
		public string LoadingOut { get; set; } // Path of loading screen when exiting (null for default)
		public bool StartLeft { get; set; } // Rayman starts the level facing left
		public bool Horizontal { get; set; } // Painting is horizontal

		public JSON_LockData Lock { get; set; }
	}
}
