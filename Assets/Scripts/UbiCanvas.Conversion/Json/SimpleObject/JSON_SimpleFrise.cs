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

		public JSON_Mesh Geometry { get; set; } 

		public JSON_PolyPointList Points { get; set; }

		public bool HasCollision { get; set; } = true;
		public List<JSON_PolyPointList> CollisionPoints { get; set; }

		public bool Precomputed { get; set; } = true;

		public class JSON_Point {
			public Vec2d Position { get; set; }
			public float Scale { get; set; } = 1f;
			public string GameMaterial { get; set; }
		}
		public class JSON_PolyPointList {
			public bool Loop { get; set; }
			public List<JSON_Point> Points { get; set; }
		}

		public class JSON_Mesh {
			public List<JSON_VertexPCT> Vertices { get; set; }
			public List<JSON_MeshElement> Elements { get; set; }
		}
		public class JSON_VertexPCT {
			public Vec3d Position { get; set; }
			public Vec2d UV { get; set; }
			public JSON_Color Color { get; set; }
		}
		public class JSON_MeshElement {
			public int Material { get; set; }
			public List<int> Indices { get; set; }
		}
	}
}
