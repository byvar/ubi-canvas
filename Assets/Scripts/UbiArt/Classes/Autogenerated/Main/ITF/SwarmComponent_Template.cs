using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH | GameFlags.RFR | GameFlags.RO)]
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
		[Serialize("Path__0"             )] public Path Path__0;
		[Serialize("uint__1"             )] public uint uint__1;
		[Serialize("float__2"            )] public float float__2;
		[Serialize("float__3"            )] public float float__3;
		[Serialize("float__4"            )] public float float__4;
		[Serialize("float__5"            )] public float float__5;
		[Serialize("float__6"            )] public float float__6;
		[Serialize("float__7"            )] public float float__7;
		[Serialize("float__8"            )] public float float__8;
		[Serialize("float__9"            )] public float float__9;
		[Serialize("float__10"           )] public float float__10;
		[Serialize("float__11"           )] public float float__11;
		[Serialize("float__12"           )] public float float__12;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Path__0));
				SerializeField(s, nameof(uint__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(float__11));
				SerializeField(s, nameof(float__12));
			} else if (Settings.s.game == Settings.Game.RO) {
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

