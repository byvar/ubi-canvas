using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class FogBoxComponent : ActorComponent {
		public Vector2 attenuationDist;
		public float near;
		public float far;
		public Color nearColor;
		public Color farColor;
		public bool useNearOffset;
		public float zWorldCliping;

		public FogBoxComponent(Reader reader) : base(reader) {
			attenuationDist = reader.ReadVector2();
			near = reader.ReadSingle();
			far = reader.ReadSingle();
			nearColor = reader.ReadColor();
			farColor = reader.ReadColor();
			useNearOffset = reader.ReadBoolean();
			zWorldCliping = reader.ReadSingle();
		}
	}
}
