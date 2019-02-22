using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class RO2_BezierNode : BaseObject {
		[Serialize(0, "pos")] public Vector3 pos;
		[Serialize(1, "tangent")] public Vector2 tangent;
		[Serialize(2, "scale")] public float scale;
		[Serialize(3, "tween")] public Nullable<RO2_BezierTween> tween;
		[Serialize(4, "lumChainSpeedMultiplier")] public float lumChainSpeedMultiplier;

		public RO2_BezierNode(Reader reader) : base(reader) {
		}
	}
}
