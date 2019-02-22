using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class BoxInterpolatorComponent : InterpolatorComponent {
		[Serialize(0, "innerBox")] public AABB innerBox;
		[Serialize(1, "outerBox")] public AABB outerBox;

		public BoxInterpolatorComponent(Reader reader) : base(reader) {
			innerBox = new AABB(reader);
			outerBox = new AABB(reader);
		}
	}
}
