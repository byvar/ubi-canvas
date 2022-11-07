namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RttiTestTwo : BaseRttiTest {
		public bool BoolValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BoolValue = s.Serialize<bool>(BoolValue, name: "BoolValue");
		}
		public override uint? ClassCRC => 0x2B7167E4;
	}
}

