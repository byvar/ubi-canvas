using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.VH | GameFlags.RA)]
	public partial class EventPlayWwiseEvent : SendMetronomedEvent {
		public StringID WwiseEventGUID;
		public StringID EventGUIDBackupSerialization;
		public bool soundPlayAfterdestroy;
		public Enum_WwiseMetronomeID WwiseMetronomeID2;
		public int StopOnDestroy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.COL) {
				WwiseEventGUID = s.SerializeObject<StringID>(WwiseEventGUID, name: "WwiseEventGUID");
				WwiseMetronomeID2 = s.Serialize<Enum_WwiseMetronomeID>(WwiseMetronomeID2, name: "WwiseMetronomeID");
				StopOnDestroy = s.Serialize<int>(StopOnDestroy, name: "StopOnDestroy");
			} else if (s.Settings.game == Settings.Game.VH) {
				WwiseEventGUID = s.SerializeObject<StringID>(WwiseEventGUID, name: "WwiseEventGUID");
				soundPlayAfterdestroy = s.Serialize<bool>(soundPlayAfterdestroy, name: "soundPlayAfterdestroy");
			} else {
				WwiseEventGUID = s.SerializeObject<StringID>(WwiseEventGUID, name: "WwiseEventGUID");
				EventGUIDBackupSerialization = s.SerializeObject<StringID>(EventGUIDBackupSerialization, name: "EventGUIDBackupSerialization");
				soundPlayAfterdestroy = s.Serialize<bool>(soundPlayAfterdestroy, name: "soundPlayAfterdestroy");
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

