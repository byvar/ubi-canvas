namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.RA | GameFlags.RM)]
	public partial class EventSetBusVolume : Event {
		public StringID bus;
		public Volume volume;
		public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game != Game.RA && s.Settings.Game != Game.RM) {
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				time = s.Serialize<float>(time, name: "time");
			} else {
			}
		}
		public override uint? ClassCRC => 0x6241355A;
	}
}

