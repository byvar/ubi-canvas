namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventPause : Event {
		public bool pause = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pause = s.Serialize<bool>(pause, name: "pause");
		}
		public override uint? ClassCRC => 0x31779023;
	}
}

