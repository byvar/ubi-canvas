using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class BreakableStackElementAIComponent_Template : AIComponent_Template {
		public CListO<InfoElementList> grid;
		public uint width;
		public uint height;
		public FxData fxData;
		public Path gmatPath;
		public uint hitPoint;
		public Path atlasPath;
		public Path atlasParticlesPath;
		public GFXMaterialSerializable atlasMaterial;
		public GFXMaterialSerializable atlasParticlesMaterial;
		public float countDownHit;
		public float gravityBallistics;
		public float timeExpulse;
		public float edgeSize;
		public bool blockStatic;
		public bool instantSpawn;
		public bool explosive;
		public float radiusExplosive;
		public float timeBeforeExplode;
		public Path eye;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			grid = s.SerializeObject<CListO<InfoElementList>>(grid, name: "grid");
			width = s.Serialize<uint>(width, name: "width");
			height = s.Serialize<uint>(height, name: "height");
			fxData = s.SerializeObject<FxData>(fxData, name: "fxData");
			gmatPath = s.SerializeObject<Path>(gmatPath, name: "gmatPath");
			hitPoint = s.Serialize<uint>(hitPoint, name: "hitPoint");
			if (s.HasFlags(SerializeFlags.Flags8)) {
				atlasPath = s.SerializeObject<Path>(atlasPath, name: "atlasPath");
				atlasParticlesPath = s.SerializeObject<Path>(atlasParticlesPath, name: "atlasParticlesPath");
			}
			atlasMaterial = s.SerializeObject<GFXMaterialSerializable>(atlasMaterial, name: "atlasMaterial");
			atlasParticlesMaterial = s.SerializeObject<GFXMaterialSerializable>(atlasParticlesMaterial, name: "atlasParticlesMaterial");
			countDownHit = s.Serialize<float>(countDownHit, name: "countDownHit");
			gravityBallistics = s.Serialize<float>(gravityBallistics, name: "gravityBallistics");
			timeExpulse = s.Serialize<float>(timeExpulse, name: "timeExpulse");
			edgeSize = s.Serialize<float>(edgeSize, name: "edgeSize");
			blockStatic = s.Serialize<bool>(blockStatic, name: "blockStatic");
			instantSpawn = s.Serialize<bool>(instantSpawn, name: "instantSpawn");
			explosive = s.Serialize<bool>(explosive, name: "explosive");
			radiusExplosive = s.Serialize<float>(radiusExplosive, name: "radiusExplosive");
			timeBeforeExplode = s.Serialize<float>(timeBeforeExplode, name: "timeBeforeExplode");
			eye = s.SerializeObject<Path>(eye, name: "eye");
		}
		public override uint? ClassCRC => 0xEB3DC4B2;
	}
}

