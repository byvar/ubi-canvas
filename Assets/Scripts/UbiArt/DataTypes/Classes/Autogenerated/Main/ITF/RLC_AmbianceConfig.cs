namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_AmbianceConfig : CSerializable {
		public StringID AmbianceDetailsId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AmbianceDetailsId = s.SerializeObject<StringID>(AmbianceDetailsId, name: "AmbianceDetailsId");
		}
		public override uint? ClassCRC => 0xBC4BC469;
	}
}

