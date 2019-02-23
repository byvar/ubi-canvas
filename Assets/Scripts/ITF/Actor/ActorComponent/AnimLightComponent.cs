using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class AnimLightComponent : GraphicComponent {
		[Serialize(0, "syncOffset")] public float syncOffset;
		[Serialize(1, "startOffset")] public float startOffset;
		[Serialize(2, "subAnimInfo")] public SubAnimSet subAnimInfo;
		[Serialize(3, "MatShader")] public Path matShader;
		[Serialize(4, "subSkeleton")] public StringID subSkeleton;
		[Serialize(5, "defaultAnim")] public StringID defaultAnim;
		[Serialize(6, "useZOffset")] public bool useZOffset;

		public AnimLightComponent(Reader reader) : base(reader) {
		}
	}
}
