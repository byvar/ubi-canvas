namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_AspiNetworkComponent_Template : ActorComponent_Template {
		public float enterDuration;
		public float enterBezierMultiplier;
		public float speed;
		public float exitSpeed;
		public float exitDist;
		public float exitRestoreZDist;
		public CListO<Ray_AspiNetworkComponent_Template.FxData> fxData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enterDuration = s.Serialize<float>(enterDuration, name: "enterDuration");
			enterBezierMultiplier = s.Serialize<float>(enterBezierMultiplier, name: "enterBezierMultiplier");
			speed = s.Serialize<float>(speed, name: "speed");
			exitSpeed = s.Serialize<float>(exitSpeed, name: "exitSpeed");
			exitDist = s.Serialize<float>(exitDist, name: "exitDist");
			exitRestoreZDist = s.Serialize<float>(exitRestoreZDist, name: "exitRestoreZDist");
			fxData = s.SerializeObject<CListO<Ray_AspiNetworkComponent_Template.FxData>>(fxData, name: "fxData");
		}
		[Games(GameFlags.RFR)]
		public partial class FxData : CSerializable {
			public string string__0;
			public StringID StringID__1;
			public StringID StringID__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				string__0 = s.Serialize<string>(string__0, name: "string__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
			}
		}
		public override uint? ClassCRC => 0x1DF730D4;
	}
}

