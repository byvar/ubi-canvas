namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class EventPlayMovie : Event {
		public bool play;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			play = s.Serialize<bool>(play, name: "play");
		}
		public override uint? ClassCRC => 0x2F8DA1FF;
	}
}

