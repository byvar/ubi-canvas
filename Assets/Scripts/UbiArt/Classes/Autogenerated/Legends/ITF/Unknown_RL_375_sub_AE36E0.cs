using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_375_sub_AE36E0 : ActorComponent_Template {
		[Serialize("eyeCursorSmoothFactor")] public float eyeCursorSmoothFactor;
		[Serialize("eyeInputX"            )] public StringID eyeInputX;
		[Serialize("eyeInputY"            )] public StringID eyeInputY;
		[Serialize("eyeMin"               )] public Vec2d eyeMin;
		[Serialize("eyeMax"               )] public Vec2d eyeMax;
		[Serialize("targetOffset"         )] public Vec2d targetOffset;
		[Serialize("eyeOffset"            )] public Vec2d eyeOffset;
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
		public override uint? ClassCRC => 0x3BD8A524;
	}
}

