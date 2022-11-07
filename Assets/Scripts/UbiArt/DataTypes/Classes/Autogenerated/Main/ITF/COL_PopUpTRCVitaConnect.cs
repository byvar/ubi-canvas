namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PopUpTRCVitaConnect : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBE7DA5F8;
	}
}

