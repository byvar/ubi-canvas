using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class SwarmComponent_Template : GraphicComponent_Template {
		public Path texture;
		public GFXMaterialSerializable swarmMaterial;
		public uint numParticles;
		public float startRadius;
		public float startSpeed;
		public float followBestChance;
		public float followTargetChance;
		public float targetTimer;
		public float windMultiplier;
		public float angularRotationScale;
		public float globalInfluence;
		public float localInfluence;
		public float damp;
		public float stiff;
		public ITF_ParticleGenerator_Template particleGenerator;
		public Path swarmTexture;
		public Path Path__0;
		public uint uint__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public float float__10;
		public float float__11;
		public float float__12;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
				uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				float__9 = s.Serialize<float>(float__9, name: "float__9");
				float__10 = s.Serialize<float>(float__10, name: "float__10");
				float__11 = s.Serialize<float>(float__11, name: "float__11");
				float__12 = s.Serialize<float>(float__12, name: "float__12");
			} else if (Settings.s.game == Settings.Game.RO) {
				swarmTexture = s.SerializeObject<Path>(swarmTexture, name: "swarmTexture");
				numParticles = s.Serialize<uint>(numParticles, name: "numParticles");
				startRadius = s.Serialize<float>(startRadius, name: "startRadius");
				startSpeed = s.Serialize<float>(startSpeed, name: "startSpeed");
				followBestChance = s.Serialize<float>(followBestChance, name: "followBestChance");
				followTargetChance = s.Serialize<float>(followTargetChance, name: "followTargetChance");
				targetTimer = s.Serialize<float>(targetTimer, name: "targetTimer");
				windMultiplier = s.Serialize<float>(windMultiplier, name: "windMultiplier");
				angularRotationScale = s.Serialize<float>(angularRotationScale, name: "angularRotationScale");
				globalInfluence = s.Serialize<float>(globalInfluence, name: "globalInfluence");
				localInfluence = s.Serialize<float>(localInfluence, name: "localInfluence");
				damp = s.Serialize<float>(damp, name: "damp");
				stiff = s.Serialize<float>(stiff, name: "stiff");
				particleGenerator = s.SerializeObject<ITF_ParticleGenerator_Template>(particleGenerator, name: "particleGenerator");
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					texture = s.SerializeObject<Path>(texture, name: "texture");
				}
				swarmMaterial = s.SerializeObject<GFXMaterialSerializable>(swarmMaterial, name: "swarmMaterial");
				numParticles = s.Serialize<uint>(numParticles, name: "numParticles");
				startRadius = s.Serialize<float>(startRadius, name: "startRadius");
				startSpeed = s.Serialize<float>(startSpeed, name: "startSpeed");
				followBestChance = s.Serialize<float>(followBestChance, name: "followBestChance");
				followTargetChance = s.Serialize<float>(followTargetChance, name: "followTargetChance");
				targetTimer = s.Serialize<float>(targetTimer, name: "targetTimer");
				windMultiplier = s.Serialize<float>(windMultiplier, name: "windMultiplier");
				angularRotationScale = s.Serialize<float>(angularRotationScale, name: "angularRotationScale");
				globalInfluence = s.Serialize<float>(globalInfluence, name: "globalInfluence");
				localInfluence = s.Serialize<float>(localInfluence, name: "localInfluence");
				damp = s.Serialize<float>(damp, name: "damp");
				stiff = s.Serialize<float>(stiff, name: "stiff");
				particleGenerator = s.SerializeObject<ITF_ParticleGenerator_Template>(particleGenerator, name: "particleGenerator");
			}
		}
		public override uint? ClassCRC => 0x5DF8E89E;
	}
}

