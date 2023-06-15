using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_LevelsConfig {
		public List<JSON_WorldInfo> Worlds { get; set; }
		public List<JSON_LevelInfo> Levels { get; set; }
		public List<JSON_CostumeInfo> Costumes { get; set; }

		public List<JSON_HomePainting> MainPaintings { get; set; } // Add to home.isc sceneconfig[0].packageDescriptors

	}
}
