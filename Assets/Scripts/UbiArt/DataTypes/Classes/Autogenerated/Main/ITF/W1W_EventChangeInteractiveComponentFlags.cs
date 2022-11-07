namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventChangeInteractiveComponentFlags : Event {
		public uint uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
		}
		public override uint? ClassCRC => 0x6EAF284B;
	}
}

