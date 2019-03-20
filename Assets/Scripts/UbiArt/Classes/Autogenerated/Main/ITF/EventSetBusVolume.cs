using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class EventSetBusVolume : Event {
		[Serialize("bus"   )] public StringID bus;
		[Serialize("volume")] public Volume volume;
		[Serialize("time"  )] public float time;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game != Settings.Game.RA) {
				SerializeField(s, nameof(bus));
				SerializeField(s, nameof(volume));
				SerializeField(s, nameof(time));
			} else {
			}
		}
		public override uint? ClassCRC => 0x6241355A;
	}
}

