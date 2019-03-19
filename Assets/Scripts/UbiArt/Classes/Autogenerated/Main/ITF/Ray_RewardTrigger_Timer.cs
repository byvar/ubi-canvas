using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_Timer : CSerializable {
		[Serialize("timer"             )] public StringID timer;
		[Serialize("timeToGet"         )] public float timeToGet;
		[Serialize("currentSessionOnly")] public int currentSessionOnly;
		[Serialize("reachTimeToGet"    )] public int reachTimeToGet;
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

