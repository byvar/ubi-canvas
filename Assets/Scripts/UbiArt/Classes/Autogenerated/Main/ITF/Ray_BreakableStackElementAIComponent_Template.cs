using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BreakableStackElementAIComponent_Template : Ray_AIComponent_Template {
		public CList<InfoElementList> grid;
		public uint width;
		public uint height;
		public FxData fxData;
		public Path gmatPath;
		public uint hitPoint;
		public Path atlasPath;
		public Path atlasParticlesPath;
		public float countDownHit;
		public float gravityBallistics;
		public float timeExpulse;
		public float edgeSize;
		public int blockStatic;
		public int instantSpawn;
		public int explosive;
		public float radiusExplosive;
		public float timeBeforeExplode;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			grid = s.SerializeObject<CList<InfoElementList>>(grid, name: "grid");
			width = s.Serialize<uint>(width, name: "width");
			height = s.Serialize<uint>(height, name: "height");
			fxData = s.SerializeObject<FxData>(fxData, name: "fxData");
			gmatPath = s.SerializeObject<Path>(gmatPath, name: "gmatPath");
			hitPoint = s.Serialize<uint>(hitPoint, name: "hitPoint");
			atlasPath = s.SerializeObject<Path>(atlasPath, name: "atlasPath");
			atlasParticlesPath = s.SerializeObject<Path>(atlasParticlesPath, name: "atlasParticlesPath");
			countDownHit = s.Serialize<float>(countDownHit, name: "countDownHit");
			gravityBallistics = s.Serialize<float>(gravityBallistics, name: "gravityBallistics");
			timeExpulse = s.Serialize<float>(timeExpulse, name: "timeExpulse");
			edgeSize = s.Serialize<float>(edgeSize, name: "edgeSize");
			blockStatic = s.Serialize<int>(blockStatic, name: "blockStatic");
			instantSpawn = s.Serialize<int>(instantSpawn, name: "instantSpawn");
			explosive = s.Serialize<int>(explosive, name: "explosive");
			radiusExplosive = s.Serialize<float>(radiusExplosive, name: "radiusExplosive");
			timeBeforeExplode = s.Serialize<float>(timeBeforeExplode, name: "timeBeforeExplode");
		}
		public override uint? ClassCRC => 0xB5AA0E08;
	}
}

