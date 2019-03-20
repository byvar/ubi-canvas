using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BlackSwarmComponent_Template : SwarmComponent_Template {
		[Serialize("detectionRadius"                 )] public float detectionRadius;
		[Serialize("particleMaxSpeed"                )] public float particleMaxSpeed;
		[Serialize("particleSize"                    )] public float particleSize;
		[Serialize("particleSizeRandomFactor"        )] public float particleSizeRandomFactor;
		[Serialize("particleColor"                   )] public Color particleColor;
		[Serialize("particleLifeTime"                )] public float particleLifeTime;
		[Serialize("particleDeathSpeed"              )] public uint particleDeathSpeed;
		[Serialize("particleLifeSpeed"               )] public uint particleLifeSpeed;
		[Serialize("particleContainerRepulsionFactor")] public float particleContainerRepulsionFactor;
		[Serialize("particleRepellerRepulsionFactor" )] public float particleRepellerRepulsionFactor;
		[Serialize("particleSeparationFactor"        )] public float particleSeparationFactor;
		[Serialize("particleTargetAttractionFactor"  )] public float particleTargetAttractionFactor;
		[Serialize("playerMaxTimeInZone"             )] public float playerMaxTimeInZone;
		[Serialize("soundMinCloseDensityDistance"    )] public float soundMinCloseDensityDistance;
		[Serialize("soundMaxCloseDensityDistance"    )] public float soundMaxCloseDensityDistance;
		[Serialize("soundMinFarDensityDistance"      )] public float soundMinFarDensityDistance;
		[Serialize("soundMaxFarDensityDistance"      )] public float soundMaxFarDensityDistance;
		[Serialize("playerProtectionRepeller"        )] public Path playerProtectionRepeller;
		[Serialize("secondNumParticles"              )] public uint secondNumParticles;
		[Serialize("secondParticleGenerator"         )] public ITF_ParticleGenerator_Template secondParticleGenerator;
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(detectionRadius));
			SerializeField(s, nameof(particleMaxSpeed));
			SerializeField(s, nameof(particleSize));
			SerializeField(s, nameof(particleSizeRandomFactor));
			SerializeField(s, nameof(particleColor));
			SerializeField(s, nameof(particleLifeTime));
			SerializeField(s, nameof(particleDeathSpeed));
			SerializeField(s, nameof(particleLifeSpeed));
			SerializeField(s, nameof(particleContainerRepulsionFactor));
			SerializeField(s, nameof(particleRepellerRepulsionFactor));
			SerializeField(s, nameof(particleSeparationFactor));
			SerializeField(s, nameof(particleTargetAttractionFactor));
			SerializeField(s, nameof(playerMaxTimeInZone));
			SerializeField(s, nameof(soundMinCloseDensityDistance));
			SerializeField(s, nameof(soundMaxCloseDensityDistance));
			SerializeField(s, nameof(soundMinFarDensityDistance));
			SerializeField(s, nameof(soundMaxFarDensityDistance));
			SerializeField(s, nameof(playerProtectionRepeller));
			SerializeField(s, nameof(secondNumParticles));
			SerializeField(s, nameof(secondParticleGenerator));
		}
		public override uint? ClassCRC => 0x148E4EE8;
	}
}

