using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.VH)]
	public partial class EventPlayWwiseEvent : SendMetronomedEvent {
		[Serialize("WwiseEventGUID"              )] public StringID WwiseEventGUID;
		[Serialize("EventGUIDBackupSerialization")] public StringID EventGUIDBackupSerialization;
		[Serialize("soundPlayAfterdestroy"       )] public bool soundPlayAfterdestroy;
		[Serialize("WwiseMetronomeID"            )] public Enum_WwiseMetronomeID WwiseMetronomeID2;
		[Serialize("StopOnDestroy"               )] public int StopOnDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(WwiseEventGUID));
				SerializeField(s, nameof(WwiseMetronomeID2));
				SerializeField(s, nameof(StopOnDestroy));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(WwiseEventGUID));
				SerializeField(s, nameof(soundPlayAfterdestroy));
			} else {
				SerializeField(s, nameof(WwiseEventGUID));
				SerializeField(s, nameof(EventGUIDBackupSerialization));
				SerializeField(s, nameof(soundPlayAfterdestroy));
			}
		}
		public enum Enum_WwiseMetronomeID {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xFDDFC049;
	}
}

