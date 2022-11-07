namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class ActorTranslateComponent : ActorComponent {
		public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
		}
		public override uint? ClassCRC => 0xA7BB0A55;
	}
}

