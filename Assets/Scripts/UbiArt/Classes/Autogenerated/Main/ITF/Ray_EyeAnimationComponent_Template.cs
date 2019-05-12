using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EyeAnimationComponent_Template : ActorComponent_Template {
		[Serialize("eyeCursorSmoothFactor")] public float eyeCursorSmoothFactor;
		[Serialize("eyeInputX"            )] public StringID eyeInputX;
		[Serialize("eyeInputY"            )] public StringID eyeInputY;
		[Serialize("eyeMin"               )] public Vector2 eyeMin;
		[Serialize("eyeMax"               )] public Vector2 eyeMax;
		[Serialize("targetOffset"         )] public Vector2 targetOffset;
		[Serialize("eyeOffset"            )] public Vector2 eyeOffset;
		[Serialize("distanceFactor"       )] public float distanceFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(eyeCursorSmoothFactor));
			SerializeField(s, nameof(eyeInputX));
			SerializeField(s, nameof(eyeInputY));
			SerializeField(s, nameof(eyeMin));
			SerializeField(s, nameof(eyeMax));
			SerializeField(s, nameof(targetOffset));
			SerializeField(s, nameof(eyeOffset));
			SerializeField(s, nameof(distanceFactor));
		}
		public override uint? ClassCRC => 0x8D8F4DD4;
	}
}

