namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BTDeciderLightingMushroomHasFired_Template : BTDecider_Template {
		public bool invert;
		public StringID factActor;
		public bool checkAll;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			invert = s.Serialize<bool>(invert, name: "invert");
			factActor = s.SerializeObject<StringID>(factActor, name: "factActor");
			checkAll = s.Serialize<bool>(checkAll, name: "checkAll");
		}
		public override uint? ClassCRC => 0xA67F188F;
	}
}

