using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EyeAnimationComponent_Template : ActorComponent_Template {
		public float eyeCursorSmoothFactor;
		public StringID eyeInputX;
		public StringID eyeInputY;
		public Vec2d eyeMin;
		public Vec2d eyeMax;
		public Vec2d targetOffset;
		public Vec2d eyeOffset;
		public float distanceFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eyeCursorSmoothFactor = s.Serialize<float>(eyeCursorSmoothFactor, name: "eyeCursorSmoothFactor");
			eyeInputX = s.SerializeObject<StringID>(eyeInputX, name: "eyeInputX");
			eyeInputY = s.SerializeObject<StringID>(eyeInputY, name: "eyeInputY");
			eyeMin = s.SerializeObject<Vec2d>(eyeMin, name: "eyeMin");
			eyeMax = s.SerializeObject<Vec2d>(eyeMax, name: "eyeMax");
			targetOffset = s.SerializeObject<Vec2d>(targetOffset, name: "targetOffset");
			eyeOffset = s.SerializeObject<Vec2d>(eyeOffset, name: "eyeOffset");
			distanceFactor = s.Serialize<float>(distanceFactor, name: "distanceFactor");
		}
		public override uint? ClassCRC => 0x8D8F4DD4;
	}
}

