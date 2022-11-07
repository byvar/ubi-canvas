namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionSetCurrentObjective_Template : CSerializable {
		public Placeholder objective;
		public bool primary;
		public bool reset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			objective = s.SerializeObject<Placeholder>(objective, name: "objective");
			primary = s.Serialize<bool>(primary, name: "primary", options: CSerializerObject.Options.BoolAsByte);
			reset = s.Serialize<bool>(reset, name: "reset", options: CSerializerObject.Options.BoolAsByte);
		}
		public override uint? ClassCRC => 0x9840154A;
	}
}

