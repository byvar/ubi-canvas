using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_FireFlyKrillAIComponent_Template : ActorComponent_Template {
		public uint nbGroups;
		public uint nbParticles;
		public float particleMinSize;
		public float particleMaxSize;
		public float radius;
		public float generationRadius;
		public float lifeDuration;
		public float deathDuration;
		public float lifeDurationRandom;
		public float separationDistance;
		public float separationFactor;
		public float attractionFactor;
		public float frictionFactor;
		public float positionOffsetFactor;
		public float speed;
		public float krillRespawnSpeedFactor;
		public float krillBarycenterInfluence;
		public Path textureFile;
		public GFXMaterialSerializable fireFlyMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			nbGroups = s.Serialize<uint>(nbGroups, name: "nbGroups");
			nbParticles = s.Serialize<uint>(nbParticles, name: "nbParticles");
			particleMinSize = s.Serialize<float>(particleMinSize, name: "particleMinSize");
			particleMaxSize = s.Serialize<float>(particleMaxSize, name: "particleMaxSize");
			radius = s.Serialize<float>(radius, name: "radius");
			generationRadius = s.Serialize<float>(generationRadius, name: "generationRadius");
			lifeDuration = s.Serialize<float>(lifeDuration, name: "lifeDuration");
			deathDuration = s.Serialize<float>(deathDuration, name: "deathDuration");
			lifeDurationRandom = s.Serialize<float>(lifeDurationRandom, name: "lifeDurationRandom");
			separationDistance = s.Serialize<float>(separationDistance, name: "separationDistance");
			separationFactor = s.Serialize<float>(separationFactor, name: "separationFactor");
			attractionFactor = s.Serialize<float>(attractionFactor, name: "attractionFactor");
			frictionFactor = s.Serialize<float>(frictionFactor, name: "frictionFactor");
			positionOffsetFactor = s.Serialize<float>(positionOffsetFactor, name: "positionOffsetFactor");
			speed = s.Serialize<float>(speed, name: "speed");
			krillRespawnSpeedFactor = s.Serialize<float>(krillRespawnSpeedFactor, name: "krillRespawnSpeedFactor");
			krillBarycenterInfluence = s.Serialize<float>(krillBarycenterInfluence, name: "krillBarycenterInfluence");
			textureFile = s.SerializeObject<Path>(textureFile, name: "textureFile");
			fireFlyMaterial = s.SerializeObject<GFXMaterialSerializable>(fireFlyMaterial, name: "fireFlyMaterial");
		}
		public override uint? ClassCRC => 0xE25C4D21;
	}
}

