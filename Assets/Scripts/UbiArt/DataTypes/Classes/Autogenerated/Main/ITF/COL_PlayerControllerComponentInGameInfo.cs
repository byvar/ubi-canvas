namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PlayerControllerComponentInGameInfo : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x3C84D5ED;
	}
}

