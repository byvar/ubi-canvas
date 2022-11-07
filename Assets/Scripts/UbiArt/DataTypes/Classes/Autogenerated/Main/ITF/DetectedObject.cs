namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class DetectedObject : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x387B40DF;
	}
}

