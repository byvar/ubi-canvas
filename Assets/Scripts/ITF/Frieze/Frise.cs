using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	// In Rayman Adventures, a Frise is an Actor.
	public class Frise : Pickable {
		public CollisionData collisionData;
		public MeshStaticData meshStaticData;
		public MeshAnimData meshAnimData;
		public MeshOverlayData meshOverlayData;
		public PolyLine visualPolyLine;
		public PolyPointList visualPolyPointLocal;
		public MeshBuildData meshBuildData;
		public MeshFluidData meshFluidData;
		public float AABB_MinZ;
		public float AABB_MaxZ;
		public PolyPointList pointsList;
		public Path configName;
		public uint switchTexturePipeExtremity;
		public bool switchExtremityStart;
		public bool switchExtremityStop;
		public Vector2 fillUVOrigin;
		public bool preComputedForCook;
		public Transform2D xfForCook;
		public float depthForCook;
		public GFXPrimitiveParam primitiveParameters;
		public float depthOffset;
		public float uvX_Offset;
		public float uvY_Offset;
		public bool uvX_Flip;
		public bool uvY_Flip;
		public float uvY_Tile;
		public Vector2 filling_offsetUv;
		public float animSyncGlobal;
		public uint atlasIndex;
		public uint atlasTessellationIndex;
		public float thickness;
		public bool useMovingCollision;
		public bool useTemplatePrimitiveParams;
		public LockTexture lockTexture;
		public Path matShader;

		public Container<FriseConfig> config;


		protected override void InitGameObject() {
			base.InitGameObject();
			if (meshBuildData != null) {
				if (meshBuildData.staticVertexList.Count > 0) {
					Mesh mesh = new Mesh();
					mesh.vertices = meshBuildData.staticVertexList.Select(v => v.pos).ToArray();
					int[] tris = new int[meshBuildData.staticIndexList.First().list.Count * 2];
					for (int i = 0; i < meshBuildData.staticIndexList.First().list.Count / 3; i++) {
						tris[(i * 6) + 0] = meshBuildData.staticIndexList.First().list[(i * 3) + 0];
						tris[(i * 6) + 1] = meshBuildData.staticIndexList.First().list[(i * 3) + 1];
						tris[(i * 6) + 2] = meshBuildData.staticIndexList.First().list[(i * 3) + 2];
						tris[(i * 6) + 3] = meshBuildData.staticIndexList.First().list[(i * 3) + 0];
						tris[(i * 6) + 4] = meshBuildData.staticIndexList.First().list[(i * 3) + 2];
						tris[(i * 6) + 5] = meshBuildData.staticIndexList.First().list[(i * 3) + 1];
					}
					mesh.triangles = tris;
					//mesh.triangles = meshBuildData.staticIndexList.First().list.Select(i => (int)i).ToArray();
					mesh.uv = meshBuildData.staticVertexList.Select(v => v.uv).ToArray();
					MeshFilter mf = gao.AddComponent<MeshFilter>();
					mf.mesh = mesh;
					MeshRenderer mr = gao.AddComponent<MeshRenderer>();
					Material mat = new Material(MapLoader.Loader.baseMaterial);
					if (config != null && config[0].textureConfigs.Count > 0 && config[0].textureConfigs[0].material.textureSet.diffuseTex != null) {
						mat.SetTexture("_MainTex", config[0].textureConfigs[0].material.textureSet.diffuseTex.Texture);
					} else {
						mat.SetTexture("_MainTex", Util.CreateDummyTexture());
					}
					mr.material = mat;
				}
			}
		}


		public Frise(Reader reader) : base(reader) {
			if (reader.ReadBoolean()) collisionData = new CollisionData(reader);
			if (reader.ReadBoolean()) meshStaticData = new MeshStaticData(reader);
			if (reader.ReadBoolean()) meshAnimData = new MeshAnimData(reader);
			if (reader.ReadBoolean()) meshOverlayData = new MeshOverlayData(reader);
			visualPolyLine = new PolyLine(reader);
			visualPolyPointLocal = new PolyPointList(reader);
			if (reader.ReadBoolean()) meshBuildData = new MeshBuildData(reader);
			if (reader.ReadBoolean()) meshFluidData = new MeshFluidData(reader);
			AABB_MinZ = reader.ReadSingle();
			AABB_MaxZ = reader.ReadSingle();
			pointsList = new PolyPointList(reader);
			configName = new Path(reader);
			switchTexturePipeExtremity = reader.ReadUInt32();
			switchExtremityStart = reader.ReadBoolean();
			switchExtremityStop = reader.ReadBoolean();
			fillUVOrigin = reader.ReadVector2();
			preComputedForCook = reader.ReadBoolean();
			xfForCook = new Transform2D(reader);
			depthForCook = reader.ReadSingle();
			primitiveParameters = new GFXPrimitiveParam(reader);
			depthOffset = reader.ReadSingle();
			uvX_Offset = reader.ReadSingle();
			uvY_Offset = reader.ReadSingle();
			uvX_Flip = reader.ReadByte() != 0;
			uvY_Flip = reader.ReadByte() != 0;
			uvY_Tile = reader.ReadSingle();
			filling_offsetUv = reader.ReadVector2();
			animSyncGlobal = reader.ReadSingle();
			atlasIndex = reader.ReadUInt32();
			atlasTessellationIndex = reader.ReadUInt32();
			thickness = reader.ReadSingle();
			useMovingCollision = reader.ReadBoolean();
			useTemplatePrimitiveParams = reader.ReadBoolean();
			lockTexture = (LockTexture)reader.ReadUInt32();
			matShader = new Path(reader);

			MapLoader.Loader.Load(configName, (extReader) => {
				if (MapLoader.Loader.fcg.ContainsKey(configName.stringID)) {
					config = MapLoader.Loader.fcg[configName.stringID];
				} else {
					extReader.flags |= Reader.Flags.AddObjectSizes;
					config = new Container<FriseConfig>(extReader, true);
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
			public Container<PolyPointList> localCollisionList;
			public Container<PolyLine> worldCollisionList;
			public CollisionData(Reader reader) : base(reader) {
				localCollisionList = new Container<PolyPointList>(reader);
				worldCollisionList = new Container<PolyLine>(reader);
			}
		}

		public class MeshStaticData : BaseObject {
			public AABB localAABB;
			public AABB worldAABB;

			public MeshStaticData(Reader reader) : base(reader) {
				localAABB = new AABB(reader);
				worldAABB = new AABB(reader);
			}
		}

		public class MeshAnimData : BaseObject {
			public AABB localAABB;
			public AABB worldAABB;
			public MeshAnimData(Reader reader) : base(reader) {
				localAABB = new AABB(reader);
				worldAABB = new AABB(reader);
			}
		}

		public class MeshOverlayData : BaseObject {
			public AABB localAABB;
			public AABB worldAABB;
			public float cosAngle;
			public float sinAngle;
			public MeshOverlayData(Reader reader) : base(reader) {
				localAABB = new AABB(reader);
				worldAABB = new AABB(reader);
				cosAngle = reader.ReadSingle();
				sinAngle = reader.ReadSingle();
			}
		}

		public class MeshBuildData : BaseObject {
			public Container<IndexList> animIndexList;
			public Container<VertexPNC3T> animVertexList;
			public Container<IndexList> staticIndexList;
			public Container<VertexPCT> staticVertexList;
			public IndexList overlayIndexList;
			public Container<VertexPCBT> overlayVertexList;
			public MeshBuildData(Reader reader) : base(reader) {
				animIndexList = new Container<IndexList>(reader);
				animVertexList = new Container<VertexPNC3T>(reader);
				staticIndexList = new Container<IndexList>(reader);
				staticVertexList = new Container<VertexPCT>(reader);
				overlayIndexList = new IndexList(reader);
				overlayVertexList = new Container<VertexPCBT>(reader);
			}
		}

		public class MeshFluidData : BaseObject {
			public MeshFluidData(Reader reader) : base(reader) {
				Debug.LogError("Decipher MeshFluidData @ " + Pointer.Current(reader));
			}
		}

		public class IndexList : BaseObject {
			public Container<ushort> list;
			public uint idTexConfig;

			public IndexList(Reader reader) : base(reader) {
				list = new Container<ushort>(reader);
				idTexConfig = reader.ReadUInt32();
			}
		}
		#endregion
	}
}
