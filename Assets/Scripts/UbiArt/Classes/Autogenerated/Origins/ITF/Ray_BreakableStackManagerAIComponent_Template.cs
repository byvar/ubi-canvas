using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_BreakableStackManagerAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("timeShakeBeforeFall")] public float timeShakeBeforeFall;
		[Serialize("countDownHit"       )] public float countDownHit;
		[Serialize("gravityBallistics"  )] public float gravityBallistics;
		[Serialize("timeExpulse"        )] public float timeExpulse;
		[Serialize("atlasPath"          )] public Path atlasPath;
		[Serialize("atlasParticlesPath" )] public Path atlasParticlesPath;
		[Serialize("edgeSize"           )] public float edgeSize;
		[Serialize("faction"            )] public uint faction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeShakeBeforeFall));
			SerializeField(s, nameof(countDownHit));
			SerializeField(s, nameof(gravityBallistics));
			SerializeField(s, nameof(timeExpulse));
			SerializeField(s, nameof(atlasPath));
			SerializeField(s, nameof(atlasParticlesPath));
			SerializeField(s, nameof(edgeSize));
			SerializeField(s, nameof(faction));
		}
		public override uint? ClassCRC => 0x964A0D32;
	}
}

