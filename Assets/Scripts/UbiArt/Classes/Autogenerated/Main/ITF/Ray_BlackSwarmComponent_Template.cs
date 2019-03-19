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
		[Serialize("secondParticleGenerator"         )] public Placeholder secondParticleGenerator;
		[Serialize("float__0"                        )] public float float__0;
		[Serialize("float__1"                        )] public float float__1;
		[Serialize("float__2"                        )] public float float__2;
		[Serialize("float__3"                        )] public float float__3;
		[Serialize("Color__4"                        )] public Color Color__4;
		[Serialize("float__5"                        )] public float float__5;
		[Serialize("uint__6"                         )] public uint uint__6;
		[Serialize("uint__7"                         )] public uint uint__7;
		[Serialize("float__8"                        )] public float float__8;
		[Serialize("float__9"                        )] public float float__9;
		[Serialize("float__10"                       )] public float float__10;
		[Serialize("float__11"                       )] public float float__11;
		[Serialize("float__12"                       )] public float float__12;
		[Serialize("float__13"                       )] public float float__13;
		[Serialize("float__14"                       )] public float float__14;
		[Serialize("float__15"                       )] public float float__15;
		[Serialize("float__16"                       )] public float float__16;
		[Serialize("Path__17"                        )] public Path Path__17;
		[Serialize("uint__18"                        )] public uint uint__18;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
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
			} else {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(Color__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(uint__6));
				SerializeField(s, nameof(uint__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(float__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(Path__17));
				SerializeField(s, nameof(uint__18));
			}
		}
		public override uint? ClassCRC => 0x148E4EE8;
	}
}

