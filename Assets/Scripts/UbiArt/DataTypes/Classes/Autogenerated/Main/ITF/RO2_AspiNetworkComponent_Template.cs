namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AspiNetworkComponent_Template : ActorComponent_Template {
		public float enterDuration;
		public float enterBezierMultiplier;
		public float speed;
		public float exitSpeed;
		public float exitDist;
		public float exitRestoreZDist;
		public CListO<RO2_AspiNetworkComponent_Template.FxDataNet> fxData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enterDuration = s.Serialize<float>(enterDuration, name: "enterDuration");
			enterBezierMultiplier = s.Serialize<float>(enterBezierMultiplier, name: "enterBezierMultiplier");
			speed = s.Serialize<float>(speed, name: "speed");
			exitSpeed = s.Serialize<float>(exitSpeed, name: "exitSpeed");
			exitDist = s.Serialize<float>(exitDist, name: "exitDist");
			exitRestoreZDist = s.Serialize<float>(exitRestoreZDist, name: "exitRestoreZDist");
			fxData = s.SerializeObject<CListO<RO2_AspiNetworkComponent_Template.FxDataNet>>(fxData, name: "fxData");
		}
		[Games(GameFlags.RA)]
		public partial class FxDataNet : CSerializable {
			public string playerFamily;
			public StringID fxIn;
			public StringID fxOut;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				playerFamily = s.Serialize<string>(playerFamily, name: "playerFamily");
				fxIn = s.SerializeObject<StringID>(fxIn, name: "fxIn");
				fxOut = s.SerializeObject<StringID>(fxOut, name: "fxOut");
			}
		}
		public override uint? ClassCRC => 0x650F47CC;
	}
}

