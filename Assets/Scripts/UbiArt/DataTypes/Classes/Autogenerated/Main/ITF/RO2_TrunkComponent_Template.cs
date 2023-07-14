namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
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

		public Angle Vita_00 { get; set; }
		public float Vita_01 { get; set; }
		public float Vita_02 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			height = s.Serialize<float>(height, name: "height");
			length = s.Serialize<float>(length, name: "length");
			angularAccel = s.SerializeObject<Angle>(angularAccel, name: "angularAccel");
			angularSpeedMax = s.SerializeObject<Angle>(angularSpeedMax, name: "angularSpeedMax");
			if (s.Settings.platform == Settings.Platform.Vita) {
				Vita_00 = s.SerializeObject<Angle>(Vita_00, name: nameof(Vita_00));
				Vita_01 = s.Serialize<float>(Vita_01, name: nameof(Vita_01));
				Vita_02 = s.Serialize<float>(Vita_02, name: nameof(Vita_02));
			}
			angularFriction = s.Serialize<float>(angularFriction, name: "angularFriction");
			bounceFactor = s.Serialize<float>(bounceFactor, name: "bounceFactor");
			bounceFallFactor = s.Serialize<float>(bounceFallFactor, name: "bounceFallFactor");
			fallAccel = s.Serialize<float>(fallAccel, name: "fallAccel");
			fallSpeedMax = s.Serialize<float>(fallSpeedMax, name: "fallSpeedMax");
			debugDraw = s.Serialize<bool>(debugDraw, name: "debugDraw");
			angularSpeedStart = s.SerializeObject<Angle>(angularSpeedStart, name: "angularSpeedStart");
			fakeFreedom = s.Serialize<bool>(fakeFreedom, name: "fakeFreedom");
			if (s.Settings.platform != Settings.Platform.Vita) {
				collisionShape = s.SerializeObject<Generic<PhysShape>>(collisionShape, name: "collisionShape");
			}
		}
		public override uint? ClassCRC => 0xC4BDF2E2;
	}
}

