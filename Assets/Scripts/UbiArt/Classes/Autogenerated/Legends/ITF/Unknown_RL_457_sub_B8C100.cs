using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_457_sub_B8C100 : RO2_AIReceiveHitAction_Template {
		[Serialize("minStunTime"        )] public float minStunTime;
		[Serialize("maxStunTime"        )] public float maxStunTime;
		[Serialize("loopingAnimDuration")] public float loopingAnimDuration;
		[Serialize("stunAnimation"      )] public StringID stunAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(minStunTime));
			SerializeField(s, nameof(maxStunTime));
			SerializeField(s, nameof(loopingAnimDuration));
			SerializeField(s, nameof(stunAnimation));
		}
		public override uint? ClassCRC => 0x48A1589A;
	}
}

