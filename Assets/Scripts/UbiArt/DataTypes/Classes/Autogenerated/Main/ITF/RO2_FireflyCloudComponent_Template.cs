namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FireflyCloudComponent_Template : ActorComponent_Template {
		public StringID standFX;
		public StringID poufFX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			standFX = s.SerializeObject<StringID>(standFX, name: "standFX");
			poufFX = s.SerializeObject<StringID>(poufFX, name: "poufFX");
		}
		public override uint? ClassCRC => 0x39C1D03A;
	}
}

