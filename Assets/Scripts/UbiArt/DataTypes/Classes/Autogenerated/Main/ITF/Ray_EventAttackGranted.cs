namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_EventAttackGranted : CSerializable {
		public uint sender;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sender = s.Serialize<uint>(sender, name: "sender");
		}
		public override uint? ClassCRC => 0xB6489BCD;
	}
}

