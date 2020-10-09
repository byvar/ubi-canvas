using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class EdgeFluid : CSerializable {
		public CArrayO<Vec2d> PosList;
		public CArrayO<Vec2d> UVList;
		public CArrayO<ColorInteger> Colors;
		public Vec2d UvAnimTrans;
		public uint MeshLevel;
		public float Depth;
		public uint LastIndex;
		public float LocalNorm;
		public float WorldNorm;
		public float WorldHeight;
		public float WorldAngle;
		public Vec3d Delta;
		public Vec2d DeltaUV;
		public CListO<EdgeProcessData> CollisionProcesses;
		public EdgeProcessData VisualProcess;
		public AABB LocalAABB;
		public AABB WorldAABB;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			PosList = s.SerializeObject<CArrayO<Vec2d>>(PosList, name: "PosList");
			UVList = s.SerializeObject<CArrayO<Vec2d>>(UVList, name: "UVList");
			Colors = s.SerializeObject<CArrayO<ColorInteger>>(Colors, name: "Colors");
			UvAnimTrans = s.SerializeObject<Vec2d>(UvAnimTrans, name: "UvAnimTrans");
			MeshLevel = s.Serialize<uint>(MeshLevel, name: "MeshLevel");
			Depth = s.Serialize<float>(Depth, name: "Depth");
			LastIndex = s.Serialize<uint>(LastIndex, name: "LastIndex");
			LocalNorm = s.Serialize<float>(LocalNorm, name: "LocalNorm");
			WorldNorm = s.Serialize<float>(WorldNorm, name: "WorldNorm");
			WorldHeight = s.Serialize<float>(WorldHeight, name: "WorldHeight");
			WorldAngle = s.Serialize<float>(WorldAngle, name: "WorldAngle");
			Delta = s.SerializeObject<Vec3d>(Delta, name: "Delta");
			DeltaUV = s.SerializeObject<Vec2d>(DeltaUV, name: "DeltaUV");
			CollisionProcesses = s.SerializeObject<CListO<EdgeProcessData>>(CollisionProcesses, name: "CollisionProcesses");
			VisualProcess = s.SerializeObject<EdgeProcessData>(VisualProcess, name: "VisualProcess");
			LocalAABB = s.SerializeObject<AABB>(LocalAABB, name: "LocalAABB");
			WorldAABB = s.SerializeObject<AABB>(WorldAABB, name: "WorldAABB");
		}
	}
}

