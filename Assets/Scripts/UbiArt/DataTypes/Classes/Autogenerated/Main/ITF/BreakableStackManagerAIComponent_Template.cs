using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BreakableStackManagerAIComponent_Template : AIComponent_Template {
		public float timeShakeBeforeFall;
		public float countDownHit;
		public float gravityBallistics;
		public float timeExpulse;
		public Path atlasPath;
		public Path atlasParticlesPath;
		public GFXMaterialSerializable atlasMaterial;
		public GFXMaterialSerializable atlasParticlesMaterial;
		public float edgeSize;
		public uint breakFaction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			timeShakeBeforeFall = s.Serialize<float>(timeShakeBeforeFall, name: "timeShakeBeforeFall");
			countDownHit = s.Serialize<float>(countDownHit, name: "countDownHit");
			gravityBallistics = s.Serialize<float>(gravityBallistics, name: "gravityBallistics");
			timeExpulse = s.Serialize<float>(timeExpulse, name: "timeExpulse");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				atlasPath = s.SerializeObject<Path>(atlasPath, name: "atlasPath");
				atlasParticlesPath = s.SerializeObject<Path>(atlasParticlesPath, name: "atlasParticlesPath");
			}
			atlasMaterial = s.SerializeObject<GFXMaterialSerializable>(atlasMaterial, name: "atlasMaterial");
			atlasParticlesMaterial = s.SerializeObject<GFXMaterialSerializable>(atlasParticlesMaterial, name: "atlasParticlesMaterial");
			edgeSize = s.Serialize<float>(edgeSize, name: "edgeSize");
			breakFaction = s.Serialize<uint>(breakFaction, name: "breakFaction");
		}
		public override uint? ClassCRC => 0x943399E1;
	}
}

