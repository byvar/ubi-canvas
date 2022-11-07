namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PCState_RealFlying : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3A81F8AA;
	}
}

