using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EdgeFluid : CSerializable {
		[Serialize("Colors"                     )] public CArray<ColorInteger> Colors;
		[Serialize("UvAnimTrans"                )] public Vector2 UvAnimTrans;
		[Serialize("MeshLevel"                  )] public uint MeshLevel;
		[Serialize("Depth"                      )] public float Depth;
		[Serialize("LastIndex"                  )] public uint LastIndex;
		[Serialize("LocalNorm"                  )] public float LocalNorm;
		[Serialize("WorldNorm"                  )] public float WorldNorm;
		[Serialize("WorldHeight"                )] public float WorldHeight;
		[Serialize("WorldAngle"                 )] public float WorldAngle;
		[Serialize("Delta"                      )] public Vector3 Delta;
		[Serialize("DeltaUV"                    )] public Vector2 DeltaUV;
		[Serialize("CollisionProcesses"         )] public CList<EdgeProcessData> CollisionProcesses;
		[Serialize("VisualProcess"              )] public EdgeProcessData VisualProcess;
		[Serialize("LocalAABB"                  )] public AABB LocalAABB;
		[Serialize("WorldAABB"                  )] public AABB WorldAABB;
		[Serialize("Vector2__0"                 )] public Vector2 Vector2__0;
		[Serialize("Vector2__1"                 )] public Vector2 Vector2__1;
		[Serialize("ColorInteger__2"            )] public ColorInteger ColorInteger__2;
		[Serialize("Vector2__3"                 )] public Vector2 Vector2__3;
		[Serialize("uint__4"                    )] public uint uint__4;
		[Serialize("float__5"                   )] public float float__5;
		[Serialize("uint__6"                    )] public uint uint__6;
		[Serialize("float__7"                   )] public float float__7;
		[Serialize("float__8"                   )] public float float__8;
		[Serialize("float__9"                   )] public float float__9;
		[Serialize("float__10"                  )] public float float__10;
		[Serialize("Vector3__11"                )] public Vector3 Vector3__11;
		[Serialize("Vector2__12"                )] public Vector2 Vector2__12;
		[Serialize("CArray<EdgeProcessData>__13")] public CArray<EdgeProcessData> CArray_EdgeProcessData__13;
		[Serialize("EdgeProcessData__14"        )] public EdgeProcessData EdgeProcessData__14;
		[Serialize("AABB__15"                   )] public AABB AABB__15;
		[Serialize("AABB__16"                   )] public AABB AABB__16;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(Vector2__0));
				SerializeField(s, nameof(Vector2__1));
				SerializeField(s, nameof(ColorInteger__2));
				SerializeField(s, nameof(Vector2__3));
				SerializeField(s, nameof(uint__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(uint__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(Vector3__11));
				SerializeField(s, nameof(Vector2__12));
				SerializeField(s, nameof(CArray_EdgeProcessData__13));
				SerializeField(s, nameof(EdgeProcessData__14));
				SerializeField(s, nameof(AABB__15));
				SerializeField(s, nameof(AABB__16));
			} else {
				SerializeField(s, nameof(Colors));
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
}

