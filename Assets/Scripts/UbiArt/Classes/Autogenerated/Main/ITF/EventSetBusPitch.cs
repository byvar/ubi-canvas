using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusPitch : Event {
		public StringID bus;
		public float pitch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				bus = s.SerializeObject<StringID>(bus, name: "bus");
				pitch = s.Serialize<float>(pitch, name: "pitch");
			}
		}
		public override uint? ClassCRC => 0x73B21DD0;
	}
}

