using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class SequenceEvent_Template : CSerializable {
		[Serialize("StartFrame"        )] public int StartFrame;
		[Serialize("Offset"            )] public int Offset;
		[Serialize("Duration"          )] public int Duration;
		[Serialize("TrackLine"         )] public uint TrackLine;
		[Serialize("Channel"           )] public string Channel;
		[Serialize("Selected"          )] public int Selected;
		[Serialize("DisabledForTesting")] public bool DisabledForTesting;
		[Serialize("uid"               )] public uint uid;
		[Serialize("EventMode"         )] public event_mode EventMode;
		[Serialize("DisabledForTesting")] public int DisabledForTesting;
		[Serialize("EventMode"         )] public Enum_EventMode EventMode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(StartFrame));
				SerializeField(s, nameof(Offset));
				SerializeField(s, nameof(Duration));
				SerializeField(s, nameof(TrackLine));
				SerializeField(s, nameof(Channel));
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(Selected));
					SerializeField(s, nameof(DisabledForTesting));
				}
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(StartFrame));
				SerializeField(s, nameof(Offset));
				SerializeField(s, nameof(Duration));
				SerializeField(s, nameof(TrackLine));
				SerializeField(s, nameof(Channel));
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(Selected));
					SerializeField(s, nameof(DisabledForTesting));
					SerializeField(s, nameof(uid));
				}
				SerializeField(s, nameof(EventMode));
			} else {
				SerializeField(s, nameof(StartFrame));
				SerializeField(s, nameof(Offset));
				SerializeField(s, nameof(Duration));
				SerializeField(s, nameof(TrackLine));
				SerializeField(s, nameof(Channel));
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(Selected));
					SerializeField(s, nameof(DisabledForTesting));
					SerializeField(s, nameof(uid));
				}
				SerializeField(s, nameof(EventMode));
			}
		}
		public enum event_mode {
			[Serialize("event_mode_default"      )] _default = 0,
			[Serialize("event_mode_sequence_only")] sequence_only = 1,
			[Serialize("event_mode_editor_only"  )] editor_only = 2,
		}
		public enum Enum_EventMode {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xFB5A38F1;
	}
}

