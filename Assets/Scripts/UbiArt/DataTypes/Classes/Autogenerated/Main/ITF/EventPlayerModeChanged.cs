namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventPlayerModeChanged : EventTrigger {
		public uint mode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mode = s.Serialize<uint>(mode, name: "mode");
		}
		public override uint? ClassCRC => 0x4FAB9E6B;
	}
}

