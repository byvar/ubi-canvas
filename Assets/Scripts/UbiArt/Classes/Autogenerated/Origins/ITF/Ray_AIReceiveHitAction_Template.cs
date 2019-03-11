using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIReceiveHitAction_Template : AIAction_Template {
		[Serialize("reward"           )] public Placeholder reward;
		[Serialize("playRateVariation")] public float playRateVariation;
		[Serialize("faceHitDir"       )] public bool faceHitDir;
		[Serialize("ignoreWind"       )] public bool ignoreWind;
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

