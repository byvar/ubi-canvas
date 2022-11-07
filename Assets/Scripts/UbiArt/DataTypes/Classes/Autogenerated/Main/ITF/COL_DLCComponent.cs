namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DLCComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA1423BED;
	}
}

