namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIPrisonerMedalComponent_Template : ActorComponent_Template {
		public float upMargin;
		public float rightMargin;
		public StringID appear;
		public StringID prisonerAppear;
		public StringID stand;
		public StringID disappear;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			upMargin = s.Serialize<float>(upMargin, name: "upMargin");
			rightMargin = s.Serialize<float>(rightMargin, name: "rightMargin");
			appear = s.SerializeObject<StringID>(appear, name: "appear");
			prisonerAppear = s.SerializeObject<StringID>(prisonerAppear, name: "prisonerAppear");
			stand = s.SerializeObject<StringID>(stand, name: "stand");
			disappear = s.SerializeObject<StringID>(disappear, name: "disappear");
		}
		public override uint? ClassCRC => 0x222209E0;
	}
}

