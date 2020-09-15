using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudSwarmComponent_Template : CSerializable {
		public float detectionRadius;
		public float particleMaxSpeed;
		public float particleSize;
		public float particleSizeRandomFactor;
		public Color particleColor;
		public float particleLifeTime;
		public float particleLifeTimeRandomFactor;
		public uint particleDeathSpeed;
		public uint particleLifeSpeed;
		public float particleContainerRepulsionFactor;
		public float particleRepellerRepulsionFactor;
		public float particleSeparationFactor;
		public float particleTargetAttractionFactor;
		public float playerMaxTimeInZone;
		public float playerMovementAnticipationFactor;
		public float soundMinCloseDensityDistance;
		public float soundMaxCloseDensityDistance;
		public float soundMinFarDensityDistance;
		public float soundMaxFarDensityDistance;
		public StringID darkCloudSoundName;
		public uint secondNumParticles;
		public Placeholder secondParticleGenerator;
		public char particleLifeOnSpawn;
		public int particlesDamagedByRepeller;
		public int updateParticleRotation;
		public int usePlayersAsTargets;
		public int useGridSpawningStrategy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			detectionRadius = s.Serialize<float>(detectionRadius, name: "detectionRadius");
			particleMaxSpeed = s.Serialize<float>(particleMaxSpeed, name: "particleMaxSpeed");
			particleSize = s.Serialize<float>(particleSize, name: "particleSize");
			particleSizeRandomFactor = s.Serialize<float>(particleSizeRandomFactor, name: "particleSizeRandomFactor");
			particleColor = s.SerializeObject<Color>(particleColor, name: "particleColor");
			particleLifeTime = s.Serialize<float>(particleLifeTime, name: "particleLifeTime");
			particleLifeTimeRandomFactor = s.Serialize<float>(particleLifeTimeRandomFactor, name: "particleLifeTimeRandomFactor");
			particleDeathSpeed = s.Serialize<uint>(particleDeathSpeed, name: "particleDeathSpeed");
			particleLifeSpeed = s.Serialize<uint>(particleLifeSpeed, name: "particleLifeSpeed");
			particleContainerRepulsionFactor = s.Serialize<float>(particleContainerRepulsionFactor, name: "particleContainerRepulsionFactor");
			particleRepellerRepulsionFactor = s.Serialize<float>(particleRepellerRepulsionFactor, name: "particleRepellerRepulsionFactor");
			particleSeparationFactor = s.Serialize<float>(particleSeparationFactor, name: "particleSeparationFactor");
			particleTargetAttractionFactor = s.Serialize<float>(particleTargetAttractionFactor, name: "particleTargetAttractionFactor");
			playerMaxTimeInZone = s.Serialize<float>(playerMaxTimeInZone, name: "playerMaxTimeInZone");
			playerMovementAnticipationFactor = s.Serialize<float>(playerMovementAnticipationFactor, name: "playerMovementAnticipationFactor");
			soundMinCloseDensityDistance = s.Serialize<float>(soundMinCloseDensityDistance, name: "soundMinCloseDensityDistance");
			soundMaxCloseDensityDistance = s.Serialize<float>(soundMaxCloseDensityDistance, name: "soundMaxCloseDensityDistance");
			soundMinFarDensityDistance = s.Serialize<float>(soundMinFarDensityDistance, name: "soundMinFarDensityDistance");
			soundMaxFarDensityDistance = s.Serialize<float>(soundMaxFarDensityDistance, name: "soundMaxFarDensityDistance");
			darkCloudSoundName = s.SerializeObject<StringID>(darkCloudSoundName, name: "darkCloudSoundName");
			secondNumParticles = s.Serialize<uint>(secondNumParticles, name: "secondNumParticles");
			secondParticleGenerator = s.SerializeObject<Placeholder>(secondParticleGenerator, name: "secondParticleGenerator");
			particleLifeOnSpawn = s.Serialize<char>(particleLifeOnSpawn, name: "particleLifeOnSpawn");
			particlesDamagedByRepeller = s.Serialize<int>(particlesDamagedByRepeller, name: "particlesDamagedByRepeller");
			updateParticleRotation = s.Serialize<int>(updateParticleRotation, name: "updateParticleRotation");
			usePlayersAsTargets = s.Serialize<int>(usePlayersAsTargets, name: "usePlayersAsTargets");
			useGridSpawningStrategy = s.Serialize<int>(useGridSpawningStrategy, name: "useGridSpawningStrategy");
		}
		public override uint? ClassCRC => 0x3CE977D9;
	}
}

