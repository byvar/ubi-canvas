using UnityEngine;

namespace UbiArt.ITF {
	public partial class TimedSpawnerModifierComponent_Template : ActorComponent_Template {
		[Serialize("timedSpawnerData" )] public TimedSpawnerData timedSpawnerData;
		[Serialize("useInstanceValues")] public bool useInstanceValues;
		[Serialize("isTriggered"      )] public bool isTriggered;
		[Serialize("TimedSpawnerData" )] public Placeholder TimedSpawnerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(timedSpawnerData));
				SerializeField(s, nameof(TimedSpawnerData));
				SerializeField(s, nameof(useInstanceValues));
				SerializeField(s, nameof(isTriggered));
			} else {
				SerializeField(s, nameof(timedSpawnerData));
				SerializeField(s, nameof(useInstanceValues));
				SerializeField(s, nameof(isTriggered));
			}
		}
		public override uint? ClassCRC => 0xD49FDDEC;
	}
}

