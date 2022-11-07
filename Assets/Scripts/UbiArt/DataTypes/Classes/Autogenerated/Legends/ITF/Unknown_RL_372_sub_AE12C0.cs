namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_372_sub_AE12C0 : CSerializable {
		public int patrol;
		public int isStatic;
		public int isInFly;
		public float distFront;
		public float distBack;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			patrol = s.Serialize<int>(patrol, name: "patrol");
			isStatic = s.Serialize<int>(isStatic, name: "isStatic");
			isInFly = s.Serialize<int>(isInFly, name: "isInFly");
			distFront = s.Serialize<float>(distFront, name: "distFront");
			distBack = s.Serialize<float>(distBack, name: "distBack");
		}
		public override uint? ClassCRC => 0x6C279A69;
	}
}

