using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierNode : CSerializable {
		[Serialize("tangent"                )] public Vector2 tangent;
		[Serialize("scale"                  )] public float scale;
		[Serialize("tween"                  )] public Nullable<BezierTween> tween;
		[Serialize("lumChainSpeedMultiplier")] public float lumChainSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tangent));
			SerializeField(s, nameof(scale));
			SerializeField(s, nameof(tween));
			SerializeField(s, nameof(lumChainSpeedMultiplier));
		}
	}
}

