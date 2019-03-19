using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudSwarmComponent_Template : CSerializable {
		[Serialize("detectionRadius"                 )] public float detectionRadius;
		[Serialize("particleMaxSpeed"                )] public float particleMaxSpeed;
		[Serialize("particleSize"                    )] public float particleSize;
		[Serialize("particleSizeRandomFactor"        )] public float particleSizeRandomFactor;
		[Serialize("particleColor"                   )] public Color particleColor;
		[Serialize("particleLifeTime"                )] public float particleLifeTime;
		[Serialize("particleLifeTimeRandomFactor"    )] public float particleLifeTimeRandomFactor;
		[Serialize("particleDeathSpeed"              )] public uint particleDeathSpeed;
		[Serialize("particleLifeSpeed"               )] public uint particleLifeSpeed;
		[Serialize("particleContainerRepulsionFactor")] public float particleContainerRepulsionFactor;
		[Serialize("particleRepellerRepulsionFactor" )] public float particleRepellerRepulsionFactor;
		[Serialize("particleSeparationFactor"        )] public float particleSeparationFactor;
		[Serialize("particleTargetAttractionFactor"  )] public float particleTargetAttractionFactor;
		[Serialize("playerMaxTimeInZone"             )] public float playerMaxTimeInZone;
		[Serialize("playerMovementAnticipationFactor")] public float playerMovementAnticipationFactor;
		[Serialize("soundMinCloseDensityDistance"    )] public float soundMinCloseDensityDistance;
		[Serialize("soundMaxCloseDensityDistance"    )] public float soundMaxCloseDensityDistance;
		[Serialize("soundMinFarDensityDistance"      )] public float soundMinFarDensityDistance;
		[Serialize("soundMaxFarDensityDistance"      )] public float soundMaxFarDensityDistance;
		[Serialize("darkCloudSoundName"              )] public StringID darkCloudSoundName;
		[Serialize("secondNumParticles"              )] public uint secondNumParticles;
		[Serialize("secondParticleGenerator"         )] public Placeholder secondParticleGenerator;
		[Serialize("particleLifeOnSpawn"             )] public char particleLifeOnSpawn;
		[Serialize("particlesDamagedByRepeller"      )] public int particlesDamagedByRepeller;
		[Serialize("updateParticleRotation"          )] public int updateParticleRotation;
		[Serialize("usePlayersAsTargets"             )] public int usePlayersAsTargets;
		[Serialize("useGridSpawningStrategy"         )] public int useGridSpawningStrategy;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectionRadius));
			SerializeField(s, nameof(particleMaxSpeed));
			SerializeField(s, nameof(particleSize));
			SerializeField(s, nameof(particleSizeRandomFactor));
			SerializeField(s, nameof(particleColor));
			SerializeField(s, nameof(particleLifeTime));
			SerializeField(s, nameof(particleLifeTimeRandomFactor));
			SerializeField(s, nameof(particleDeathSpeed));
			SerializeField(s, nameof(particleLifeSpeed));
			SerializeField(s, nameof(particleContainerRepulsionFactor));
			SerializeField(s, nameof(particleRepellerRepulsionFactor));
			SerializeField(s, nameof(particleSeparationFactor));
			SerializeField(s, nameof(particleTargetAttractionFactor));
			SerializeField(s, nameof(playerMaxTimeInZone));
			SerializeField(s, nameof(playerMovementAnticipationFactor));
			SerializeField(s, nameof(soundMinCloseDensityDistance));
			SerializeField(s, nameof(soundMaxCloseDensityDistance));
			SerializeField(s, nameof(soundMinFarDensityDistance));
			SerializeField(s, nameof(soundMaxFarDensityDistance));
			SerializeField(s, nameof(darkCloudSoundName));
			SerializeField(s, nameof(secondNumParticles));
			SerializeField(s, nameof(secondParticleGenerator));
			SerializeField(s, nameof(particleLifeOnSpawn));
			SerializeField(s, nameof(particlesDamagedByRepeller));
			SerializeField(s, nameof(updateParticleRotation));
			SerializeField(s, nameof(usePlayersAsTargets));
			SerializeField(s, nameof(useGridSpawningStrategy));
		}
		public override uint? ClassCRC => 0x3CE977D9;
	}
}

