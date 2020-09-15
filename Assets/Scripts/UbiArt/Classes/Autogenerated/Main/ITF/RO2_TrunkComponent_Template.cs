using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TrunkComponent_Template : ActorComponent_Template {
		public float height;
		public float length;
		public Angle angularAccel;
		public Angle angularSpeedMax;
		public float angularFriction;
		public float bounceFactor;
		public float bounceFallFactor;
		public float fallAccel;
		public float fallSpeedMax;
		public bool debugDraw;
		public Angle angularSpeedStart;
		public bool fakeFreedom;
		public Generic<PhysShape> collisionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			height = s.Serialize<float>(height, name: "height");
			length = s.Serialize<float>(length, name: "length");
			angularAccel = s.SerializeObject<Angle>(angularAccel, name: "angularAccel");
			angularSpeedMax = s.SerializeObject<Angle>(angularSpeedMax, name: "angularSpeedMax");
			angularFriction = s.Serialize<float>(angularFriction, name: "angularFriction");
			bounceFactor = s.Serialize<float>(bounceFactor, name: "bounceFactor");
			bounceFallFactor = s.Serialize<float>(bounceFallFactor, name: "bounceFallFactor");
			fallAccel = s.Serialize<float>(fallAccel, name: "fallAccel");
			fallSpeedMax = s.Serialize<float>(fallSpeedMax, name: "fallSpeedMax");
			debugDraw = s.Serialize<bool>(debugDraw, name: "debugDraw");
			angularSpeedStart = s.SerializeObject<Angle>(angularSpeedStart, name: "angularSpeedStart");
			fakeFreedom = s.Serialize<bool>(fakeFreedom, name: "fakeFreedom");
			collisionShape = s.SerializeObject<Generic<PhysShape>>(collisionShape, name: "collisionShape");
		}
		public override uint? ClassCRC => 0xC4BDF2E2;
	}
}

