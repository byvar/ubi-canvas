using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusVolume : Event {
		public StringID bus;
		public Volume volume;
		public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game != Settings.Game.RA) {
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				volume = s.SerializeObject<Volume>(volume, name: "volume");
				time = s.Serialize<float>(time, name: "time");
			} else {
			}
		}
		public override uint? ClassCRC => 0x6241355A;
	}
}

