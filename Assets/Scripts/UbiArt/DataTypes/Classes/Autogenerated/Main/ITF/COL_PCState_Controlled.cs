namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PCState_Controlled : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x9983B9BD;
	}
}

