namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_StepOnObjectInteraction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xEDEDB11E;
	}
}

