using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class AnimMeshVertexComponent : GraphicComponent {
		[Serialize(0, "anims")] public Container<SingleAnimData> anims;
		[Serialize(1, "mergeRange")] public float mergeRange;
		[Serialize(2, "aabb")] public AABB aabb;

		public AnimMeshVertexComponent(Reader reader) : base(reader) {
		}
	}
}
