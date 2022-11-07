namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class EventPlayerModeSet : Event {
		public uint mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mode = s.Serialize<uint>(mode, name: "mode");
		}
		public override uint? ClassCRC => 0x2B16A294;
	}
}

