using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BlackSwarmComponent_Template : SwarmComponent_Template {
		public float detectionRadius;
		public float particleMaxSpeed;
		public float particleSize;
		public float particleSizeRandomFactor;
		public Color particleColor;
		public float particleLifeTime;
		public uint particleDeathSpeed;
		public uint particleLifeSpeed;
		public float particleContainerRepulsionFactor;
		public float particleRepellerRepulsionFactor;
		public float particleSeparationFactor;
		public float particleTargetAttractionFactor;
		public float playerMaxTimeInZone;
		public float soundMinCloseDensityDistance;
		public float soundMaxCloseDensityDistance;
		public float soundMinFarDensityDistance;
		public float soundMaxFarDensityDistance;
		public Path playerProtectionRepeller;
		public uint secondNumParticles;
		public ITF_ParticleGenerator_Template secondParticleGenerator;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
			particleMaxSpeed = s.Serialize<float>(particleMaxSpeed, name: "particleMaxSpeed");
			particleSize = s.Serialize<float>(particleSize, name: "particleSize");
			particleSizeRandomFactor = s.Serialize<float>(particleSizeRandomFactor, name: "particleSizeRandomFactor");
			particleColor = s.SerializeObject<Color>(particleColor, name: "particleColor");
			particleLifeTime = s.Serialize<float>(particleLifeTime, name: "particleLifeTime");
			particleDeathSpeed = s.Serialize<uint>(particleDeathSpeed, name: "particleDeathSpeed");
			particleLifeSpeed = s.Serialize<uint>(particleLifeSpeed, name: "particleLifeSpeed");
			particleContainerRepulsionFactor = s.Serialize<float>(particleContainerRepulsionFactor, name: "particleContainerRepulsionFactor");
			particleRepellerRepulsionFactor = s.Serialize<float>(particleRepellerRepulsionFactor, name: "particleRepellerRepulsionFactor");
			particleSeparationFactor = s.Serialize<float>(particleSeparationFactor, name: "particleSeparationFactor");
			particleTargetAttractionFactor = s.Serialize<float>(particleTargetAttractionFactor, name: "particleTargetAttractionFactor");
			playerMaxTimeInZone = s.Serialize<float>(playerMaxTimeInZone, name: "playerMaxTimeInZone");
			soundMinCloseDensityDistance = s.Serialize<float>(soundMinCloseDensityDistance, name: "soundMinCloseDensityDistance");
			soundMaxCloseDensityDistance = s.Serialize<float>(soundMaxCloseDensityDistance, name: "soundMaxCloseDensityDistance");
			soundMinFarDensityDistance = s.Serialize<float>(soundMinFarDensityDistance, name: "soundMinFarDensityDistance");
			soundMaxFarDensityDistance = s.Serialize<float>(soundMaxFarDensityDistance, name: "soundMaxFarDensityDistance");
			playerProtectionRepeller = s.SerializeObject<Path>(playerProtectionRepeller, name: "playerProtectionRepeller");
			secondNumParticles = s.Serialize<uint>(secondNumParticles, name: "secondNumParticles");
			secondParticleGenerator = s.SerializeObject<ITF_ParticleGenerator_Template>(secondParticleGenerator, name: "secondParticleGenerator");
		}
		public override uint? ClassCRC => 0x148E4EE8;
	}
}

