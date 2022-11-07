namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class EventGhostOnReadingFinish : Event {
		public uint ghostIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ghostIndex = s.Serialize<uint>(ghostIndex, name: "ghostIndex");
		}
		public override uint? ClassCRC => 0x3D1C19B5;
	}
}

