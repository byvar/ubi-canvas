using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL | GameFlags.VH)]
	public partial class EventPlayWwiseEvent : SendMetronomedEvent {
		[Serialize("WwiseEventGUID"              )] public StringID WwiseEventGUID;
		[Serialize("EventGUIDBackupSerialization")] public StringID EventGUIDBackupSerialization;
		[Serialize("soundPlayAfterdestroy"       )] public bool soundPlayAfterdestroy;
		[Serialize("sender"                      )] public uint sender;
		[Serialize("WwiseMetronomeID"            )] public Enum_WwiseMetronomeID WwiseMetronomeID;
		[Serialize("StopOnDestroy"               )] public int StopOnDestroy;
		[Serialize("StringID__0"                 )] public StringID StringID__0;
		[Serialize("bool__1"                     )] public bool bool__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(sender));
				SerializeField(s, nameof(WwiseEventGUID));
				SerializeField(s, nameof(WwiseMetronomeID));
				SerializeField(s, nameof(StopOnDestroy));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(bool__1));
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

