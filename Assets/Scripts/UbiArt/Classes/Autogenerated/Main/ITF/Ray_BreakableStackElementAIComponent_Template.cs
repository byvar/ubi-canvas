using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BreakableStackElementAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("grid"              )] public CList<InfoElementList> grid;
		[Serialize("width"             )] public uint width;
		[Serialize("height"            )] public uint height;
		[Serialize("fxData"            )] public FxData fxData;
		[Serialize("gmatPath"          )] public Path gmatPath;
		[Serialize("hitPoint"          )] public uint hitPoint;
		[Serialize("atlasPath"         )] public Path atlasPath;
		[Serialize("atlasParticlesPath")] public Path atlasParticlesPath;
		[Serialize("countDownHit"      )] public float countDownHit;
		[Serialize("gravityBallistics" )] public float gravityBallistics;
		[Serialize("timeExpulse"       )] public float timeExpulse;
		[Serialize("edgeSize"          )] public float edgeSize;
		[Serialize("blockStatic"       )] public int blockStatic;
		[Serialize("instantSpawn"      )] public int instantSpawn;
		[Serialize("explosive"         )] public int explosive;
		[Serialize("radiusExplosive"   )] public float radiusExplosive;
		[Serialize("timeBeforeExplode" )] public float timeBeforeExplode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(grid));
			SerializeField(s, nameof(width));
			SerializeField(s, nameof(height));
			SerializeField(s, nameof(fxData));
			SerializeField(s, nameof(gmatPath));
			SerializeField(s, nameof(hitPoint));
			SerializeField(s, nameof(atlasPath));
			SerializeField(s, nameof(atlasParticlesPath));
			SerializeField(s, nameof(countDownHit));
			SerializeField(s, nameof(gravityBallistics));
			SerializeField(s, nameof(timeExpulse));
			SerializeField(s, nameof(edgeSize));
			SerializeField(s, nameof(blockStatic));
			SerializeField(s, nameof(instantSpawn));
			SerializeField(s, nameof(explosive));
			SerializeField(s, nameof(radiusExplosive));
			SerializeField(s, nameof(timeBeforeExplode));
		}
		public override uint? ClassCRC => 0xB5AA0E08;
	}
}

