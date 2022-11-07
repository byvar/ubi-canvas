namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PCState_Battle : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x4844609D;
	}
}

