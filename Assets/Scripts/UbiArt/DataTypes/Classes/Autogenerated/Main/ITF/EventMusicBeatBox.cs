namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventMusicBeatBox : Event {
		public bool Activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Activate = s.Serialize<bool>(Activate, name: "Activate");
		}
		public override uint? ClassCRC => 0x1584131F;
	}
}

