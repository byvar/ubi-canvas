namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventFear : Event {
		public int int__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			int__0 = s.Serialize<int>(int__0, name: "int__0");
		}
		public override uint? ClassCRC => 0x414387A5;
	}
}

