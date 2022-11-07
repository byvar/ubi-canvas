namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_WheelPuzzleComponent_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6696ADD3;
	}
}

