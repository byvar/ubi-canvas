namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RO2_AIFlyIdleAction : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x6A5E899C;
	}
}

