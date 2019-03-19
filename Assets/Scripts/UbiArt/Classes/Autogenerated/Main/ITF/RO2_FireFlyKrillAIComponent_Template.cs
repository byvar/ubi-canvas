using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_FireFlyKrillAIComponent_Template : ActorComponent_Template {
		[Serialize("nbGroups"                )] public uint nbGroups;
		[Serialize("nbParticles"             )] public uint nbParticles;
		[Serialize("particleMinSize"         )] public float particleMinSize;
		[Serialize("particleMaxSize"         )] public float particleMaxSize;
		[Serialize("radius"                  )] public float radius;
		[Serialize("generationRadius"        )] public float generationRadius;
		[Serialize("lifeDuration"            )] public float lifeDuration;
		[Serialize("deathDuration"           )] public float deathDuration;
		[Serialize("lifeDurationRandom"      )] public float lifeDurationRandom;
		[Serialize("separationDistance"      )] public float separationDistance;
		[Serialize("separationFactor"        )] public float separationFactor;
		[Serialize("attractionFactor"        )] public float attractionFactor;
		[Serialize("frictionFactor"          )] public float frictionFactor;
		[Serialize("positionOffsetFactor"    )] public float positionOffsetFactor;
		[Serialize("speed"                   )] public float speed;
		[Serialize("krillRespawnSpeedFactor" )] public float krillRespawnSpeedFactor;
		[Serialize("krillBarycenterInfluence")] public float krillBarycenterInfluence;
		[Serialize("textureFile"             )] public Path textureFile;
		[Serialize("fireFlyMaterial"         )] public GFXMaterialSerializable fireFlyMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(nbGroups));
			SerializeField(s, nameof(nbParticles));
			SerializeField(s, nameof(particleMinSize));
			SerializeField(s, nameof(particleMaxSize));
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(generationRadius));
			SerializeField(s, nameof(lifeDuration));
			SerializeField(s, nameof(deathDuration));
			SerializeField(s, nameof(lifeDurationRandom));
			SerializeField(s, nameof(separationDistance));
			SerializeField(s, nameof(separationFactor));
			SerializeField(s, nameof(attractionFactor));
			SerializeField(s, nameof(frictionFactor));
			SerializeField(s, nameof(positionOffsetFactor));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(krillRespawnSpeedFactor));
			SerializeField(s, nameof(krillBarycenterInfluence));
			SerializeField(s, nameof(textureFile));
			SerializeField(s, nameof(fireFlyMaterial));
		}
		public override uint? ClassCRC => 0xE25C4D21;
	}
}

