namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionLitRune_Template : BTAction_Template {
		public StringID animIncantation;
		public StringID animGrateful;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animIncantation = s.SerializeObject<StringID>(animIncantation, name: "animIncantation");
			animGrateful = s.SerializeObject<StringID>(animGrateful, name: "animGrateful");
		}
		public override uint? ClassCRC => 0x2EE4FAA6;
	}
}

