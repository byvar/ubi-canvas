using UnityEngine;

namespace UbiArt.ITF {
	public partial class SwarmComponent_Template : GraphicComponent_Template {
		[Serialize("texture"             )] public Path texture;
		[Serialize("swarmMaterial"       )] public GFXMaterialSerializable swarmMaterial;
		[Serialize("numParticles"        )] public uint numParticles;
		[Serialize("startRadius"         )] public float startRadius;
		[Serialize("startSpeed"          )] public float startSpeed;
		[Serialize("followBestChance"    )] public float followBestChance;
		[Serialize("followTargetChance"  )] public float followTargetChance;
		[Serialize("targetTimer"         )] public float targetTimer;
		[Serialize("windMultiplier"      )] public float windMultiplier;
		[Serialize("angularRotationScale")] public float angularRotationScale;
		[Serialize("globalInfluence"     )] public float globalInfluence;
		[Serialize("localInfluence"      )] public float localInfluence;
		[Serialize("damp"                )] public float damp;
		[Serialize("stiff"               )] public float stiff;
		[Serialize("particleGenerator"   )] public ITF_ParticleGenerator_Template particleGenerator;
		[Serialize("swarmTexture"        )] public Path swarmTexture;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(swarmTexture));
				SerializeField(s, nameof(numParticles));
				SerializeField(s, nameof(startRadius));
				SerializeField(s, nameof(startSpeed));
				SerializeField(s, nameof(followBestChance));
				SerializeField(s, nameof(followTargetChance));
				SerializeField(s, nameof(targetTimer));
				SerializeField(s, nameof(windMultiplier));
				SerializeField(s, nameof(angularRotationScale));
				SerializeField(s, nameof(globalInfluence));
				SerializeField(s, nameof(localInfluence));
				SerializeField(s, nameof(damp));
				SerializeField(s, nameof(stiff));
				SerializeField(s, nameof(particleGenerator));
			} else {
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(texture));
				}
				SerializeField(s, nameof(swarmMaterial));
				SerializeField(s, nameof(numParticles));
				SerializeField(s, nameof(startRadius));
				SerializeField(s, nameof(startSpeed));
				SerializeField(s, nameof(followBestChance));
				SerializeField(s, nameof(followTargetChance));
				SerializeField(s, nameof(targetTimer));
				SerializeField(s, nameof(windMultiplier));
				SerializeField(s, nameof(angularRotationScale));
				SerializeField(s, nameof(globalInfluence));
				SerializeField(s, nameof(localInfluence));
				SerializeField(s, nameof(damp));
				SerializeField(s, nameof(stiff));
				SerializeField(s, nameof(particleGenerator));
			}
		}
		public override uint? ClassCRC => 0x5DF8E89E;
	}
}

