namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTActionAlerted : CSerializable {
		public Placeholder detectionShape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectionShape = s.SerializeObject<Placeholder>(detectionShape, name: "detectionShape");
		}
		public override uint? ClassCRC => 0xFF483937;
	}
}

