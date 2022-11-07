namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionCharge_Template : CSerializable {
		public StringID name;
		public StringID animCharge;
		public Placeholder detectionShape;
		public float targetDistThreshold;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			animCharge = s.SerializeObject<StringID>(animCharge, name: "animCharge");
			detectionShape = s.SerializeObject<Placeholder>(detectionShape, name: "detectionShape");
			targetDistThreshold = s.Serialize<float>(targetDistThreshold, name: "targetDistThreshold");
		}
		public override uint? ClassCRC => 0xE5816A26;
	}
}

