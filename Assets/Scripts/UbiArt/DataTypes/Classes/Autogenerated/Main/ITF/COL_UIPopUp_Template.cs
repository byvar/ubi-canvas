namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_UIPopUp_Template : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6B369513;
	}
}

