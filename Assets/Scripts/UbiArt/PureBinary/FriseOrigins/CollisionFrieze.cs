using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::CollisionFrieze::serialize
	public class CollisionFrieze : CSerializable {
		public float flt;
		public int int1;
		public int int2;
		public int int3;
		public Vec2d vec1;
		public Vec2d vec2;
		public Vec2d vec3;
		public Vec2d vec4;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flt = s.Serialize<float>(flt, name: "flt");
			int1 = s.Serialize<int>(int1, name: "int1");
			int2 = s.Serialize<int>(int2, name: "int2");
			int3 = s.Serialize<int>(int3, name: "int3");
			vec1 = s.SerializeObject<Vec2d>(vec1, name: "vec1");
			vec2 = s.SerializeObject<Vec2d>(vec2, name: "vec2");
			vec3 = s.SerializeObject<Vec2d>(vec3, name: "vec3");
			vec4 = s.SerializeObject<Vec2d>(vec4, name: "vec4");
		}
	}
}
