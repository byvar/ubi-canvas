namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LeverComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x55E75DD7;
	}
}

