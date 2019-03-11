using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIIdleAction_Template : AIAction_Template {
		[Serialize("minTime"              )] public float minTime;
		[Serialize("maxTime"              )] public float maxTime;
		[Serialize("startTimerOnMetronome")] public bool startTimerOnMetronome;
		[Serialize("syncRatio"            )] public float syncRatio;
		[Serialize("syncOffset"           )] public float syncOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minTime));
			SerializeField(s, nameof(maxTime));
			SerializeField(s, nameof(startTimerOnMetronome));
			SerializeField(s, nameof(syncRatio));
			SerializeField(s, nameof(syncOffset));
		}
		public override uint? ClassCRC => 0x5926CA92;
	}
}

