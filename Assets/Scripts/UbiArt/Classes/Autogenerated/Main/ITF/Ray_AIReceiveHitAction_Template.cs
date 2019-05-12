using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIReceiveHitAction_Template : AIReceiveHitAction_Template {
		[Serialize("reward"           )] public Generic<Ray_EventSpawnReward> reward;
		[Serialize("playRateVariation")] public float playRateVariation;
		[Serialize("faceHitDir"       )] public int faceHitDir;
		[Serialize("ignoreWind"       )] public int ignoreWind;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(playRateVariation));
			SerializeField(s, nameof(faceHitDir));
			SerializeField(s, nameof(ignoreWind));
		}
		public override uint? ClassCRC => 0x18FA8506;
	}
}

