using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventSpawnCommand : Event {
		[Serialize("Command" )] public EventSpawnCommand Command;
		[Serialize("duration")] public float duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Command));
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(duration));
			}
		}
		public enum EventSpawnCommand {
			[Serialize("EventSpawnCommand::Stop"             )] Stop = 0,
			[Serialize("EventSpawnCommand::Pause"            )] Pause = 1,
			[Serialize("EventSpawnCommand::PauseWithDuration")] PauseWithDuration = 2,
			[Serialize("EventSpawnCommand::Resume"           )] Resume = 3,
			[Serialize("EventSpawnCommand::ResetAndPlay"     )] ResetAndPlay = 4,
		}
		public override uint? ClassCRC => 0xBE6184DD;
	}
}

