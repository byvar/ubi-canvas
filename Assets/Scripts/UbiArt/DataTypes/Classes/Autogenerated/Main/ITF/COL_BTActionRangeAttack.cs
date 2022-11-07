namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionRangeAttack : CSerializable {
		public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				detectionShape = s.SerializeObject<Placeholder>(detectionShape, name: "detectionShape");
			}
		}
		public override uint? ClassCRC => 0x1323BFB6;
	}
}

