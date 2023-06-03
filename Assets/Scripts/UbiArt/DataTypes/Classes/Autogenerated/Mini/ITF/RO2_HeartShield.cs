namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RO2_HeartShield : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x16F0C3D3;
	}
}

