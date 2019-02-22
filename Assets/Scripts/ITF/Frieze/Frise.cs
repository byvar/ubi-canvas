using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	// In Rayman Adventures, a Frise is an Actor.
	public class Frise : Pickable {
		[Serialize(0, "CollisionData")] public Nullable<CollisionData> collisionData;
		[Serialize(1, "MeshStaticData")] public Nullable<MeshStaticData> meshStaticData;
		[Serialize(2, "MeshAnimData")] public Nullable<MeshAnimData> meshAnimData;
		[Serialize(3, "MeshOverlayData")] public Nullable<MeshOverlayData> meshOverlayData;
		[Serialize(4, "VisualPolyline")] public PolyLine visualPolyLine;
		[Serialize(5, "VisualPolyPointLocal")] public PolyPointList visualPolyPointLocal;
		[Serialize(6, "MeshBuildData")] public Nullable<MeshBuildData> meshBuildData;
		[Serialize(7, "MeshFluidData")] public Nullable<MeshFluidData> meshFluidData;
		[Serialize(8, "AABB_MinZ")] public float AABB_MinZ;
		[Serialize(9, "AABB_MaxZ")] public float AABB_MaxZ;
		[Serialize(10, "PointsList")] public PolyPointList pointsList;
		[Serialize(11, "ConfigName")] public Path configName;
		[Serialize(12, "SwitchTexturePipeExtremity")] public uint switchTexturePipeExtremity;
		[Serialize(13, "SwitchExtremityStart")] public bool switchExtremityStart;
		[Serialize(14, "SwitchExtremityStop")] public bool switchExtremityStop;
		[Serialize(15, "FillUVOrigin")] public Vector2 fillUVOrigin;
		[Serialize(16, "PreComputedForCook")] public bool preComputedForCook;
		[Serialize(17, "XfForCook")] public Transform2D xfForCook;
		[Serialize(18, "DepthForCook")] public float depthForCook;
		[Serialize(19, "PrimitiveParameters")] public GFXPrimitiveParam primitiveParameters;
		[Serialize(20, "DepthOffset")] public float depthOffset;
		[Serialize(21, "UvX_Offset")] public float uvX_Offset;
		[Serialize(22, "UvY_Offset")] public float uvY_Offset;
		[Serialize(23, "UvX_Flip")] public byte uvX_Flip;
		[Serialize(24, "UvY_Flip")] public byte uvY_Flip;
		[Serialize(25, "UvY_Tile")] public float uvY_Tile;
		[Serialize(26, "Filling_OffSetUv")] public Vector2 filling_offsetUv;
		[Serialize(27, "Anim_SyncGlobal")] public float animSyncGlobal;
		[Serialize(28, "AtlasIndex")] public uint atlasIndex;
		[Serialize(29, "AtlasTessellationIndex")] public uint atlasTessellationIndex;
		[Serialize(30, "Thickness")] public float thickness;
		[Serialize(31, "UseMovingCollision")] public bool useMovingCollision;
		[Serialize(32, "UseTemplatePrimitiveParams")] public bool useTemplatePrimitiveParams;
		[Serialize(33, "LockTexture")] public LockTexture lockTexture;
		[Serialize(34, "MatShader")] public Path matShader;

		public Container<Generic<FriseConfig>> config;


		protected override void InitGameObject() {
			base.InitGameObject();
			if (meshBuildData.obj != null) {
				if (meshBuildData.obj.staticVertexList.Count > 0) {
					Mesh mesh = new Mesh();
					mesh.vertices = meshBuildData.obj.staticVertexList.Select(v => v.pos).ToArray();
					int[] tris = new int[meshBuildData.obj.staticIndexList.First().list.Count * 2];
					for (int i = 0; i < meshBuildData.obj.staticIndexList.First().list.Count / 3; i++) {
						tris[(i * 6) + 0] = meshBuildData.obj.staticIndexList.First().list[(i * 3) + 0];
						tris[(i * 6) + 1] = meshBuildData.obj.staticIndexList.First().list[(i * 3) + 1];
						tris[(i * 6) + 2] = meshBuildData.obj.staticIndexList.First().list[(i * 3) + 2];
						tris[(i * 6) + 3] = meshBuildData.obj.staticIndexList.First().list[(i * 3) + 0];
						tris[(i * 6) + 4] = meshBuildData.obj.staticIndexList.First().list[(i * 3) + 2];
						tris[(i * 6) + 5] = meshBuildData.obj.staticIndexList.First().list[(i * 3) + 1];
					}
					mesh.triangles = tris;
					//mesh.triangles = meshBuildData.staticIndexList.First().list.Select(i => (int)i).ToArray();
					mesh.uv = meshBuildData.obj.staticVertexList.Select(v => v.uv).ToArray();
					MeshFilter mf = gao.AddComponent<MeshFilter>();
					mf.mesh = mesh;
					MeshRenderer mr = gao.AddComponent<MeshRenderer>();
					Material mat;
					if (config != null && config[0].obj.textureConfigs.Count > 0) {
						if (config[0].obj.textureConfigs[0].material.shader != null) {
							if (config[0].obj.textureConfigs[0].material.shader[0].obj.materialtype == GFXMaterialShader_Template.GFXMat.Default) {
								mat = new Material(MapLoader.Loader.baseMaterial);
							} else {
								mat = new Material(MapLoader.Loader.baseLightMaterial);
							}
							if (!config[0].obj.textureConfigs[0].material.shader[0].obj.renderRegular) gao.SetActive(false);
						} else {
							mat = new Material(MapLoader.Loader.baseMaterial);
						}
						//mat.color = config[0].obj.textureConfigs[0].color.Color;
						if (config[0].obj.textureConfigs[0].material.textureSet.diffuseTex != null) {
							mat.SetTexture("_MainTex", config[0].obj.textureConfigs[0].material.textureSet.diffuseTex.Texture);
						} else {
							mat.SetTexture("_MainTex", Util.CreateDummyTexture());
						}
					} else {
						mat = new Material(MapLoader.Loader.baseMaterial);
					}
					mr.material = mat;
				}
			}
		}


		public Frise(Reader reader) : base(reader) {
			MapLoader.Loader.Load(configName, (extReader) => {
				if (MapLoader.Loader.fcg.ContainsKey(configName.stringID)) {
					config = MapLoader.Loader.fcg[configName.stringID];
				} else {
					extReader.flags |= Reader.Flags.AddObjectSizes;
					config = new Container<Generic<FriseConfig>>(extReader);
					MapLoader.Loader.fcg[configName.stringID] = config;
					MapLoader.Loader.print("Read:" + extReader.BaseStream.Position.ToString("X8") + " - Length:" + extReader.BaseStream.Length.ToString("X8") + " - " + (extReader.BaseStream.Position == extReader.BaseStream.Length ? "good!" : "bad!"));
				}
			});
		}

		public enum LockTexture {
			Top,
			Right,
			Left,
			Bottom,
			None,
			Switch
		}

		#region Data classes
		public class CollisionData : BaseObject {
			[Serialize(0, "LocalCollisionList")] public Container<PolyPointList> localCollisionList;
			[Serialize(1, "WorldCollisionList")] public Container<PolyLine> worldCollisionList;
			public CollisionData(Reader reader) : base(reader) {
			}
		}

		public class MeshStaticData : BaseObject {
			[Serialize(0, "LocalAABB")] public AABB localAABB;
			[Serialize(1, "WorldAABB")] public AABB worldAABB;

			public MeshStaticData(Reader reader) : base(reader) {
			}
		}

		public class MeshAnimData : BaseObject {
			[Serialize(0, "LocalAABB")] public AABB localAABB;
			[Serialize(1, "WorldAABB")] public AABB worldAABB;
			public MeshAnimData(Reader reader) : base(reader) {
			}
		}

		public class MeshOverlayData : BaseObject {
			[Serialize(0, "LocalAABB")] public AABB localAABB;
			[Serialize(1, "WorldAABB")] public AABB worldAABB;
			[Serialize(2, "CosAngle")] public float cosAngle;
			[Serialize(3, "SinAngle")] public float sinAngle;
			public MeshOverlayData(Reader reader) : base(reader) {
			}
		}

		public class MeshBuildData : BaseObject {
			[Serialize(0, "AnimIndexList")] public Container<IndexList> animIndexList;
			[Serialize(1, "AnimVertexList")] public Container<VertexPNC3T> animVertexList;
			[Serialize(2, "StaticIndexList")] public Container<IndexList> staticIndexList;
			[Serialize(3, "StaticVertexList")] public Container<VertexPCT> staticVertexList;
			[Serialize(4, "OverlayIndexList")] public IndexList overlayIndexList;
			[Serialize(5, "OverlayVertexList")] public Container<VertexPCBT> overlayVertexList;
			public MeshBuildData(Reader reader) : base(reader) {
			}
		}

		public class MeshFluidData : BaseObject {
			public MeshFluidData(Reader reader) : base(reader) {
				Debug.LogError("Decipher MeshFluidData @ " + Pointer.Current(reader));
			}
		}

		public class IndexList : BaseObject {
			[Serialize(0, "List")] public Container<ushort> list;
			[Serialize(1, "IdTexConfig")] public uint idTexConfig;

			public IndexList(Reader reader) : base(reader) {
			}
		}
		#endregion
	}
}
