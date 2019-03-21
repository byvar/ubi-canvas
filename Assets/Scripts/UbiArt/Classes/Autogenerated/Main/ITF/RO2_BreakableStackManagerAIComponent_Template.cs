using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BreakableStackManagerAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("timeShakeBeforeFall"   )] public float timeShakeBeforeFall;
		[Serialize("countDownHit"          )] public float countDownHit;
		[Serialize("gravityBallistics"     )] public float gravityBallistics;
		[Serialize("timeExpulse"           )] public float timeExpulse;
		[Serialize("atlasPath"             )] public Path atlasPath;
		[Serialize("atlasParticlesPath"    )] public Path atlasParticlesPath;
		[Serialize("atlasMaterial"         )] public GFXMaterialSerializable atlasMaterial;
		[Serialize("atlasParticlesMaterial")] public GFXMaterialSerializable atlasParticlesMaterial;
		[Serialize("edgeSize"              )] public float edgeSize;
		[Serialize("faction"               )] public uint faction2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(timeShakeBeforeFall));
			SerializeField(s, nameof(countDownHit));
			SerializeField(s, nameof(gravityBallistics));
			SerializeField(s, nameof(timeExpulse));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(atlasPath));
				SerializeField(s, nameof(atlasParticlesPath));
			}
			SerializeField(s, nameof(atlasMaterial));
			SerializeField(s, nameof(atlasParticlesMaterial));
			SerializeField(s, nameof(edgeSize));
			SerializeField(s, nameof(faction2));
		}
		public override uint? ClassCRC => 0x189DAE6B;
	}
}

