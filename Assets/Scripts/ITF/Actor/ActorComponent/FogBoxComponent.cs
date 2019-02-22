using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class FogBoxComponent : ActorComponent {
		[Serialize(0, "attenuationDist")] public Vector2 attenuationDist;
		[Serialize(1, "near")] public float near;
		[Serialize(2, "far")] public float far;
		[Serialize(3, "nearColor")] public Color nearColor;
		[Serialize(4, "farColor")] public Color farColor;
		[Serialize(5, "useNearOffset")] public bool useNearOffset;
		[Serialize(6, "ZWorldCliping")] public float zWorldClipping;

		public FogBoxComponent(Reader reader) : base(reader) {
		}
	}
}
