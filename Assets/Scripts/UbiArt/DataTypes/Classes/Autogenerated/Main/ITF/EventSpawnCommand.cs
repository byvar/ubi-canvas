namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventSpawnCommand : Event {
		public EventSpawnCommand_Enum Command;
		public float duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Command = s.Serialize<EventSpawnCommand_Enum>(Command, name: "Command");
			if (s.HasFlags(SerializeFlags.Default)) {
				duration = s.Serialize<float>(duration, name: "duration");
			}
		}
		public enum EventSpawnCommand_Enum {
			[Serialize("EventSpawnCommand::Stop"             )] Stop = 0,
			[Serialize("EventSpawnCommand::Pause"            )] Pause = 1,
			[Serialize("EventSpawnCommand::PauseWithDuration")] PauseWithDuration = 2,
			[Serialize("EventSpawnCommand::Resume"           )] Resume = 3,
			[Serialize("EventSpawnCommand::ResetAndPlay"     )] ResetAndPlay = 4,
		}
		public override uint? ClassCRC => 0xBE6184DD;
	}
}

