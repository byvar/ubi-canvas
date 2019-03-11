using UnityEngine;

namespace UbiArt.ITF {
	public partial class EdgeFluid : CSerializable {
		[Serialize("Colors"            )] public CArray<ColorInteger> Colors;
		[Serialize("UvAnimTrans"       )] public Vector2 UvAnimTrans;
		[Serialize("MeshLevel"         )] public uint MeshLevel;
		[Serialize("Depth"             )] public float Depth;
		[Serialize("LastIndex"         )] public uint LastIndex;
		[Serialize("LocalNorm"         )] public float LocalNorm;
		[Serialize("WorldNorm"         )] public float WorldNorm;
		[Serialize("WorldHeight"       )] public float WorldHeight;
		[Serialize("WorldAngle"        )] public float WorldAngle;
		[Serialize("Delta"             )] public Vector3 Delta;
		[Serialize("DeltaUV"           )] public Vector2 DeltaUV;
		[Serialize("CollisionProcesses")] public CList<EdgeProcessData> CollisionProcesses;
		[Serialize("VisualProcess"     )] public EdgeProcessData VisualProcess;
		[Serialize("LocalAABB"         )] public AABB LocalAABB;
		[Serialize("WorldAABB"         )] public AABB WorldAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Colors));
			SerializeField(s, nameof(UvAnimTrans));
			SerializeField(s, nameof(MeshLevel));
			SerializeField(s, nameof(Depth));
			SerializeField(s, nameof(LastIndex));
			SerializeField(s, nameof(LocalNorm));
			SerializeField(s, nameof(WorldNorm));
			SerializeField(s, nameof(WorldHeight));
			SerializeField(s, nameof(WorldAngle));
			SerializeField(s, nameof(Delta));
			SerializeField(s, nameof(DeltaUV));
			SerializeField(s, nameof(CollisionProcesses));
			SerializeField(s, nameof(VisualProcess));
			SerializeField(s, nameof(LocalAABB));
			SerializeField(s, nameof(WorldAABB));
		}
	}
}

