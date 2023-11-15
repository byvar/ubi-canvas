namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_CountdownComponent : ActorComponent {
		public StringID animName;
		public float countdownCount = 3f;
		public float countdownDuration = 3f;
		public float goDisplayDuration = 1f;
		public bool finishAfterGo = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			animName = s.SerializeObject<StringID>(animName, name: "animName");
			countdownCount = s.Serialize<float>(countdownCount, name: "countdownCount");
			countdownDuration = s.Serialize<float>(countdownDuration, name: "countdownDuration");
			goDisplayDuration = s.Serialize<float>(goDisplayDuration, name: "goDisplayDuration");
			finishAfterGo = s.Serialize<bool>(finishAfterGo, name: "finishAfterGo");
		}
		public override uint? ClassCRC => 0xF8B2093C;
	}
}

