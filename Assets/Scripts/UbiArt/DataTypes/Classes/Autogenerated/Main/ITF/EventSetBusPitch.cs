namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventSetBusPitch : Event {
		public StringID bus;
		public float pitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				pitch = s.Serialize<float>(pitch, name: "pitch");
			}
		}
		public override uint? ClassCRC => 0x73B21DD0;
	}
}

