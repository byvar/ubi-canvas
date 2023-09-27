using Newtonsoft.Json;
using System.Collections.Generic;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_SimpleCombinedScene {
		public List<Subscene> Subscenes { get; set; }
		public Vec2d Spacing { get; set; }
		public int TeensiesCount { get; set; } // 0, 3 or 10

		public class Subscene {
			public string Path { get; set; }
			public Vec2d Position { get; set; }

			[JsonIgnore]
			public Scene Data { get; set; }

			public string ActorName { get; set; }
		}
	}
}
