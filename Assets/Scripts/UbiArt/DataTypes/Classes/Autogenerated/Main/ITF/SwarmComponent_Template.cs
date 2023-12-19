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
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RO || s.Settings.Game == Game.RFR) {
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

