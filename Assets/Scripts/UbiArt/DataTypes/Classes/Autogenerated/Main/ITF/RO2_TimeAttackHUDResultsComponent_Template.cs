namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TimeAttackHUDResultsComponent_Template : ActorComponent_Template {
		public float scale;
		public StringID boneTimer;
		public StringID boneCup;
		public StringID boneElectoons;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			scale = s.Serialize<float>(scale, name: "scale");
			boneTimer = s.SerializeObject<StringID>(boneTimer, name: "boneTimer");
			boneCup = s.SerializeObject<StringID>(boneCup, name: "boneCup");
			boneElectoons = s.SerializeObject<StringID>(boneElectoons, name: "boneElectoons");
		}
		public override uint? ClassCRC => 0xB4EE7F00;
	}
}

