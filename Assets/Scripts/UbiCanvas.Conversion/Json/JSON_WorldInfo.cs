using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_WorldInfo {
		// in gameconfig -> WorldConfig
		public string WorldID { get; set; }
		public uint NameID { get; set; }
		public string InteractiveLoadingPath { get; set; }
		public string DefaultScoreRecapPath { get; set; }
		public int TeensyUnlockCountRetro1 { get; set; } // Not sure what this does.
		public int TeensyUnlockCountRetro2 { get; set; }
		public string Presence { get; set; } // for rich presence. Use "ToadStory" to get "On a rescue mission in Toad story!" for example.
	}
}
