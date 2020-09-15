using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CountdownComponent : ActorComponent {
		public StringID animName;
		public float countdownCount;
		public float countdownDuration;
		public float goDisplayDuration;
		public bool finishAfterGo;
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

