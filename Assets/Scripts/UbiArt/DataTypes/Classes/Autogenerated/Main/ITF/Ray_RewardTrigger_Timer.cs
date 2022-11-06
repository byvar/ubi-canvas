using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_Timer : CSerializable {
		public StringID timer;
		public float timeToGet;
		public int currentSessionOnly;
		public int reachTimeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timer = s.SerializeObject<StringID>(timer, name: "timer");
			timeToGet = s.Serialize<float>(timeToGet, name: "timeToGet");
			currentSessionOnly = s.Serialize<int>(currentSessionOnly, name: "currentSessionOnly");
			reachTimeToGet = s.Serialize<int>(reachTimeToGet, name: "reachTimeToGet");
		}
		public override uint? ClassCRC => 0x62E9D8BD;
	}
}

