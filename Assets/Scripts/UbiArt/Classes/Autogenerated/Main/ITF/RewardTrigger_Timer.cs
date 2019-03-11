using UnityEngine;

namespace UbiArt.ITF {
	public partial class RewardTrigger_Timer : RewardTrigger_Base {
		[Serialize("timerId"           )] public StringID timerId;
		[Serialize("timeToGet"         )] public float timeToGet;
		[Serialize("currentSessionOnly")] public bool currentSessionOnly;
		[Serialize("reachTimeToGet"    )] public bool reachTimeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timerId));
			SerializeField(s, nameof(timeToGet));
			SerializeField(s, nameof(currentSessionOnly));
			SerializeField(s, nameof(reachTimeToGet));
		}
		public override uint? ClassCRC => 0xB36DD730;
	}
}

