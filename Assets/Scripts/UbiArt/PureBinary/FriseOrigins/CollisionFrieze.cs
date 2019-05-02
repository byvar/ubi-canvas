using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace UbiArt.FriseOrigins {
	// See: ITF::CollisionFrieze::serialize
	public class CollisionFrieze : CSerializable {
		[Serialize("flt")] public float flt;
		[Serialize("int1")] public int int1;
		[Serialize("int2")] public int int2;
		[Serialize("int3")] public int int3;
		[Serialize("vec1")] public Vector2 vec1;
		[Serialize("vec2")] public Vector2 vec2;
		[Serialize("vec3")] public Vector2 vec3;
		[Serialize("vec4")] public Vector2 vec4;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flt));
			SerializeField(s, nameof(int1));
			SerializeField(s, nameof(int2));
			SerializeField(s, nameof(int3));
			SerializeField(s, nameof(vec1));
			SerializeField(s, nameof(vec2));
			SerializeField(s, nameof(vec3));
			SerializeField(s, nameof(vec4));
		}
	}
}
