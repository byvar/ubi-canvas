namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PCState_CoopDrawing : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x50D22CAC;
	}
}

