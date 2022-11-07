namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_SpinnerInteraction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xCCC8C468;
	}
}

