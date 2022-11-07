namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MazeRoomComponent : ActorComponent {
		public bool startOnInstance;
		public bool startOn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				startOnInstance = s.Serialize<bool>(startOnInstance, name: "startOnInstance");
			}
			if (s.HasFlags(SerializeFlags.Default)) {
				startOn = s.Serialize<bool>(startOn, name: "startOn");
			}
		}
		public override uint? ClassCRC => 0xED53265B;
	}
}

