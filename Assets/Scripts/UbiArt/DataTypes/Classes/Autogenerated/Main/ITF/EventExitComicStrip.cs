namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class EventExitComicStrip : Event {
		public uint uint__0;
		public uint uint__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
			uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
		}
		public override uint? ClassCRC => 0x695D55A5;
	}
}

