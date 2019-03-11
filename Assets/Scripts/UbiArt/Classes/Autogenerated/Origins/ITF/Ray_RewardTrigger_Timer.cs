using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_RewardTrigger_Timer : CSerializable {
		[Serialize("timer"             )] public StringID timer;
		[Serialize("timeToGet"         )] public float timeToGet;
		[Serialize("currentSessionOnly")] public bool currentSessionOnly;
		[Serialize("reachTimeToGet"    )] public bool reachTimeToGet;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timer));
			SerializeField(s, nameof(timeToGet));
			SerializeField(s, nameof(currentSessionOnly));
			SerializeField(s, nameof(reachTimeToGet));
		}
		public override uint? ClassCRC => 0x62E9D8BD;
	}
}

