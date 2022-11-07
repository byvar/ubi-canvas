namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventShowScoreboard : Event {
		public int display;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			display = s.Serialize<int>(display, name: "display");
		}
		public override uint? ClassCRC => 0xF87620F8;
	}
}

