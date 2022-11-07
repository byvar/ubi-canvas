namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionAppearSplinterCell_Template : BTAction_Template {
		public StringID animSwimUp;
		public float speedLimitToStop;
		public float antiBounceFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animSwimUp = s.SerializeObject<StringID>(animSwimUp, name: "animSwimUp");
			speedLimitToStop = s.Serialize<float>(speedLimitToStop, name: "speedLimitToStop");
			antiBounceFactor = s.Serialize<float>(antiBounceFactor, name: "antiBounceFactor");
		}
		public override uint? ClassCRC => 0x9D54B652;
	}
}

