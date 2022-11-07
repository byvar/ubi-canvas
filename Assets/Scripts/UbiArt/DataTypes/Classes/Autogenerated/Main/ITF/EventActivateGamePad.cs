namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class EventActivateGamePad : Event {
		public bool Activate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Activate = s.Serialize<bool>(Activate, name: "Activate");
		}
		public override uint? ClassCRC => 0x8D252EDD;
	}
}

