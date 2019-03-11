using UnityEngine;

namespace UbiArt.ITF {
	public partial class BreakableStackManagerAIComponent_Template : AIComponent_Template {
		[Serialize("timeShakeBeforeFall"   )] public float timeShakeBeforeFall;
		[Serialize("countDownHit"          )] public float countDownHit;
		[Serialize("gravityBallistics"     )] public float gravityBallistics;
		[Serialize("timeExpulse"           )] public float timeExpulse;
		[Serialize("atlasPath"             )] public Path atlasPath;
		[Serialize("atlasParticlesPath"    )] public Path atlasParticlesPath;
		[Serialize("atlasMaterial"         )] public GFXMaterialSerializable atlasMaterial;
		[Serialize("atlasParticlesMaterial")] public GFXMaterialSerializable atlasParticlesMaterial;
		[Serialize("edgeSize"              )] public float edgeSize;
		[Serialize("breakFaction"          )] public uint breakFaction;
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
			SerializeField(s, nameof(breakFaction));
		}
		public override uint? ClassCRC => 0x943399E1;
	}
}

