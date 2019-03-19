using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_TrunkComponent_Template : ActorComponent_Template {
		[Serialize("height"           )] public float height;
		[Serialize("length"           )] public float length;
		[Serialize("angularAccel"     )] public Angle angularAccel;
		[Serialize("angularSpeedMax"  )] public Angle angularSpeedMax;
		[Serialize("angularFriction"  )] public float angularFriction;
		[Serialize("bounceFactor"     )] public float bounceFactor;
		[Serialize("bounceFallFactor" )] public float bounceFallFactor;
		[Serialize("fallAccel"        )] public float fallAccel;
		[Serialize("fallSpeedMax"     )] public float fallSpeedMax;
		[Serialize("debugDraw"        )] public bool debugDraw;
		[Serialize("angularSpeedStart")] public Angle angularSpeedStart;
		[Serialize("fakeFreedom"      )] public bool fakeFreedom;
		[Serialize("collisionShape"   )] public Generic<PhysShape> collisionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(height));
			SerializeField(s, nameof(length));
			SerializeField(s, nameof(angularAccel));
			SerializeField(s, nameof(angularSpeedMax));
			SerializeField(s, nameof(angularFriction));
			SerializeField(s, nameof(bounceFactor));
			SerializeField(s, nameof(bounceFallFactor));
			SerializeField(s, nameof(fallAccel));
			SerializeField(s, nameof(fallSpeedMax));
			SerializeField(s, nameof(debugDraw));
			SerializeField(s, nameof(angularSpeedStart));
			SerializeField(s, nameof(fakeFreedom));
			SerializeField(s, nameof(collisionShape));
		}
		public override uint? ClassCRC => 0xC4BDF2E2;
	}
}

