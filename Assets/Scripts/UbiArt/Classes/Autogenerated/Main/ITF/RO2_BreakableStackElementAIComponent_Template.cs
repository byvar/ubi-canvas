using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BreakableStackElementAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("grid"                  )] public CList<RO2_InfoElementList> grid;
		[Serialize("width"                 )] public uint width;
		[Serialize("height"                )] public uint height;
		[Serialize("fxData"                )] public RO2_FxData fxData;
		[Serialize("gmatPath"              )] public Path gmatPath;
		[Serialize("hitPoint"              )] public uint hitPoint;
		[Serialize("atlasPath"             )] public Path atlasPath;
		[Serialize("atlasParticlesPath"    )] public Path atlasParticlesPath;
		[Serialize("atlasMaterial"         )] public GFXMaterialSerializable atlasMaterial;
		[Serialize("atlasParticlesMaterial")] public GFXMaterialSerializable atlasParticlesMaterial;
		[Serialize("countDownHit"          )] public float countDownHit;
		[Serialize("gravityBallistics"     )] public float gravityBallistics;
		[Serialize("timeExpulse"           )] public float timeExpulse;
		[Serialize("edgeSize"              )] public float edgeSize;
		[Serialize("blockStatic"           )] public bool blockStatic;
		[Serialize("instantSpawn"          )] public bool instantSpawn;
		[Serialize("explosive"             )] public bool explosive;
		[Serialize("radiusExplosive"       )] public float radiusExplosive;
		[Serialize("timeBeforeExplode"     )] public float timeBeforeExplode;
		[Serialize("eye"                   )] public Path eye;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(grid));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(fxData));
				SerializeField(s, nameof(gmatPath));
				SerializeField(s, nameof(hitPoint));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(atlasPath));
					SerializeField(s, nameof(atlasParticlesPath));
				}
				SerializeField(s, nameof(atlasMaterial));
				SerializeField(s, nameof(atlasParticlesMaterial));
				SerializeField(s, nameof(countDownHit));
				SerializeField(s, nameof(gravityBallistics));
				SerializeField(s, nameof(timeExpulse));
				SerializeField(s, nameof(edgeSize));
				SerializeField(s, nameof(blockStatic));
				SerializeField(s, nameof(instantSpawn));
				SerializeField(s, nameof(explosive));
				SerializeField(s, nameof(radiusExplosive));
				SerializeField(s, nameof(timeBeforeExplode));
			} else {
				SerializeField(s, nameof(grid));
				SerializeField(s, nameof(width));
				SerializeField(s, nameof(height));
				SerializeField(s, nameof(fxData));
				SerializeField(s, nameof(gmatPath));
				SerializeField(s, nameof(hitPoint));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(atlasPath));
					SerializeField(s, nameof(atlasParticlesPath));
				}
				SerializeField(s, nameof(atlasMaterial));
				SerializeField(s, nameof(atlasParticlesMaterial));
				SerializeField(s, nameof(countDownHit));
				SerializeField(s, nameof(gravityBallistics));
				SerializeField(s, nameof(timeExpulse));
				SerializeField(s, nameof(edgeSize));
				SerializeField(s, nameof(blockStatic));
				SerializeField(s, nameof(instantSpawn));
				SerializeField(s, nameof(explosive));
				SerializeField(s, nameof(radiusExplosive));
				SerializeField(s, nameof(timeBeforeExplode));
				SerializeField(s, nameof(eye));
			}
		}
		public override uint? ClassCRC => 0x4AB4165E;
	}
}

