using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.LegendsAndUp)]
	public partial class RewardTrigger_Timer : RewardTrigger_Base {
		public StringID timerId;
		public float timeToGet;
		public bool currentSessionOnly;
		public bool reachTimeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timerId = s.SerializeObject<StringID>(timerId, name: "timerId");
			timeToGet = s.Serialize<float>(timeToGet, name: "timeToGet");
			currentSessionOnly = s.Serialize<bool>(currentSessionOnly, name: "currentSessionOnly");
			reachTimeToGet = s.Serialize<bool>(reachTimeToGet, name: "reachTimeToGet");
		}
		public override uint? ClassCRC => 0xB36DD730;
	}
}

