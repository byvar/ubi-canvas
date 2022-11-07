namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_NotificationPopUp : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5B0E5B8E;
	}
}

