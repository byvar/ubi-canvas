using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UbiArt;
using UbiArt.ITF;

namespace UbiCanvas.Conversion.Json {
	public class JSON_SimpleFrise : JSON_SimplePickable {
		public string GeometryPath { get; set; }

		// Points
		public bool Loop { get; set; }
		public List<JSON_Point> Points { get; set; }

		public class JSON_Point {
			public Vec2d Position { get; set; }
			public float Scale { get; set; }
			public string GameMaterialOverride { get; set; }
		}
	}
}
