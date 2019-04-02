using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Frise : Actor {
		[Serialize("EventShowColorDst"                  )] public Color EventShowColorDst;
		[Serialize("disablePhysic"                      )] public bool disablePhysic;
		[Serialize("CollisionData"                      )] public Nullable<Frise.CollisionData> collisionData;
		[Serialize("MeshStaticData"                     )] public Nullable<Frise.MeshStaticData> meshStaticData;
		[Serialize("MeshAnimData"                       )] public Nullable<Frise.MeshAnimData> meshAnimData;
		[Serialize("MeshOverlayData"                    )] public Nullable<Frise.MeshOverlayData> meshOverlayData;
		[Serialize("VisualPolyline"                     )] public PolyLine VisualPolyline;
		[Serialize("VisualPolyPointLocal"               )] public PolyPointList VisualPolyPointLocal;
		[Serialize("MeshBuildData"                      )] public Nullable<Frise.MeshBuildData> meshBuildData;
		[Serialize("MeshFluidData"                      )] public Nullable<Frise.MeshFluidData> meshFluidData;
		[Serialize("AABB_MinZ"                          )] public float AABB_MinZ;
		[Serialize("AABB_MaxZ"                          )] public float AABB_MaxZ;
		[Serialize("LOCAL_POINTS"                       )] public CList<PolyLineEdge> LOCAL_POINTS;
		[Serialize("LOOP"                               )] public bool LOOP;
		[Serialize("PointsList"                         )] public PolyPointList PointsList;
		[Serialize("ConfigName"                         )] public Path ConfigName;
		[Serialize("SwitchTexturePipeExtremity"         )] public uint SwitchTexturePipeExtremity;
		[Serialize("SwitchExtremityStart"               )] public bool SwitchExtremityStart;
		[Serialize("SwitchExtremityStop"                )] public bool SwitchExtremityStop;
		[Serialize("FillUVOrigin"                       )] public Vector2 FillUVOrigin;
		[Serialize("PreComputedForCook"                 )] public bool PreComputedForCook;
		[Serialize("XfForCook"                          )] public Transform2d XfForCook;
		[Serialize("DepthForCook"                       )] public float DepthForCook;
		[Serialize("ColorFactor"                        )] public Color ColorFactor;
		[Serialize("ColorFog"                           )] public Color ColorFog;
		[Serialize("PrimitiveParameters"                )] public GFXPrimitiveParam PrimitiveParameters;
		[Serialize("DepthOffset"                        )] public float DepthOffset;
		[Serialize("UvX_Offset"                         )] public float UvX_Offset;
		[Serialize("UvY_Offset"                         )] public float UvY_Offset;
		[Serialize("UvX_Flip"                           )] public bool UvX_Flip;
		[Serialize("UvY_Flip"                           )] public bool UvY_Flip;
		[Serialize("uvY_Tile"                           )] public float uvY_Tile;
		[Serialize("Filling_OffSetUv"                   )] public Vector2 Filling_OffSetUv;
		[Serialize("Anim_SyncGlobal"                    )] public float Anim_SyncGlobal;
		[Serialize("AtlasIndex"                         )] public uint AtlasIndex;
		[Serialize("AtlasTessellationIndex"             )] public uint AtlasTessellationIndex;
		[Serialize("Thickness"                          )] public float Thickness;
		[Serialize("UseMovingCollision"                 )] public bool UseMovingCollision;
		[Serialize("UseTemplatePrimitiveParams"         )] public bool UseTemplatePrimitiveParams;
		[Serialize("LockTexture"                        )] public LockTexture lockTexture;
		[Serialize("MatShader"                          )] public Path MatShader;
		[Serialize("Mesh3dSeed"                         )] public uint Mesh3dSeed;
		[Serialize("MeshManualySet"                     )] public CList<int> MeshManualySet;
		[Serialize("animSpeedFactor"                    )] public float animSpeedFactor;
		[Serialize("animAmplitudeFactor"                )] public float animAmplitudeFactor;
		[Serialize("highlightOutlineColor"              )] public Color highlightOutlineColor;
		[Serialize("highlightFrontLightBrightness"      )] public float highlightFrontLightBrightness;
		[Serialize("highlightOutlineWidth"              )] public float highlightOutlineWidth;
		[Serialize("highlightPeriod"                    )] public float highlightPeriod;
		[Serialize("highlightAmplitude"                 )] public float highlightAmplitude;
		[Serialize("POINTS"                             )] public CList<PolyLineEdge> POINTS;
		[Serialize("PivotMode"                          )] public PivotMode pivotMode;
		[Serialize("USERPIVOT"                          )] public Vector2 USERPIVOT;
		[Serialize("ColorFactor_Red"                    )] public float ColorFactor_Red;
		[Serialize("ColorFactor_Green"                  )] public float ColorFactor_Green;
		[Serialize("ColorFactor_Blu"                    )] public float ColorFactor_Blu;
		[Serialize("ColorFactor_Alpha"                  )] public float ColorFactor_Alpha;
		[Serialize("ColorFog_Red"                       )] public float ColorFog_Red;
		[Serialize("ColorFog_Green"                     )] public float ColorFog_Green;
		[Serialize("ColorFog_Blu"                       )] public float ColorFog_Blu;
		[Serialize("fogfactor"                          )] public float fogfactor;
		[Serialize("ColorComputerTagId"                 )] public uint ColorComputerTagId;
		[Serialize("renderInTarget"                     )] public int renderInTarget;
		[Serialize("IsDynamicFrieze"                    )] public int IsDynamicFrieze;
		[Serialize("useStaticFog"                       )] public bool useStaticFog;
		[Serialize("renderInRelection"                  )] public bool renderInRelection;
		
		
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					SerializeField(s, nameof(LOCAL_POINTS));
				}
				if (s.HasFlags(SerializeFlags.Flags6 | SerializeFlags.Flags8)) {
					SerializeField(s, nameof(POINTS));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(pivotMode));
					SerializeField(s, nameof(LOOP));
					SerializeField(s, nameof(USERPIVOT));
					SerializeField(s, nameof(ConfigName));
					SerializeField(s, nameof(SwitchTexturePipeExtremity));
					if (s.HasFlags(SerializeFlags.Default)) {
						SerializeField(s, nameof(ColorFactor_Red));
						SerializeField(s, nameof(ColorFactor_Green));
						SerializeField(s, nameof(ColorFactor_Blu));
						SerializeField(s, nameof(ColorFactor_Alpha));
						SerializeField(s, nameof(ColorFog_Red));
						SerializeField(s, nameof(ColorFog_Green));
						SerializeField(s, nameof(ColorFog_Blu));
						SerializeField(s, nameof(fogfactor));
						SerializeField(s, nameof(ColorFactor));
						SerializeField(s, nameof(ColorFog));
						SerializeField(s, nameof(ColorComputerTagId));
						SerializeField(s, nameof(renderInTarget));
						SerializeField(s, nameof(UvX_Offset));
						SerializeField(s, nameof(UvY_Offset));
						SerializeField(s, nameof(UvX_Flip));
						SerializeField(s, nameof(UvY_Flip));
						SerializeField(s, nameof(uvY_Tile));
						SerializeField(s, nameof(Filling_OffSetUv));
						SerializeField(s, nameof(Anim_SyncGlobal));
						SerializeField(s, nameof(IsDynamicFrieze));
						SerializeField(s, nameof(AtlasIndex));
						SerializeField(s, nameof(Thickness));
						SerializeField(s, nameof(lockTexture));
					}
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(EventShowColorDst));
					SerializeField(s, nameof(disablePhysic));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(collisionData));
					SerializeField(s, nameof(meshStaticData));
					SerializeField(s, nameof(meshAnimData));
					SerializeField(s, nameof(meshOverlayData));
					SerializeField(s, nameof(VisualPolyline));
					SerializeField(s, nameof(VisualPolyPointLocal));
					if (Settings.s.isCatchThemAll) {
						meshBuildData = new Nullable<MeshBuildData>();
						s.Serialize(ref meshBuildData.value, name: "MeshBuildData");
					} else {
						SerializeField(s, nameof(meshBuildData));
					}
					SerializeField(s, nameof(meshFluidData));
					SerializeField(s, nameof(AABB_MinZ));
					SerializeField(s, nameof(AABB_MaxZ));
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(LOCAL_POINTS));
					SerializeField(s, nameof(LOOP));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(PointsList));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(ConfigName));
					SerializeField(s, nameof(SwitchTexturePipeExtremity));
					SerializeField(s, nameof(SwitchExtremityStart));
					SerializeField(s, nameof(SwitchExtremityStop));
					SerializeField(s, nameof(FillUVOrigin));
					SerializeField(s, nameof(PreComputedForCook));
					SerializeField(s, nameof(XfForCook));
					SerializeField(s, nameof(DepthForCook));
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							SerializeField(s, nameof(ColorFactor));
							SerializeField(s, nameof(ColorFog));
							SerializeField(s, nameof(useStaticFog));
							SerializeField(s, nameof(renderInRelection));
						}
						SerializeField(s, nameof(PrimitiveParameters));
						SerializeField(s, nameof(DepthOffset));
						SerializeField(s, nameof(UvX_Offset));
						SerializeField(s, nameof(UvY_Offset));
						SerializeField(s, nameof(UvX_Flip), type: typeof(byte));
						SerializeField(s, nameof(UvY_Flip), type: typeof(byte));
						if (Settings.s.isCatchThemAll) {
							SerializeField(s, nameof(UvY_Flip), type: typeof(byte));
						}
						SerializeField(s, nameof(uvY_Tile));
						SerializeField(s, nameof(Filling_OffSetUv));
						SerializeField(s, nameof(Anim_SyncGlobal));
						SerializeField(s, nameof(AtlasIndex));
						SerializeField(s, nameof(AtlasTessellationIndex));
						SerializeField(s, nameof(Thickness));
						SerializeField(s, nameof(UseMovingCollision));
						SerializeField(s, nameof(UseTemplatePrimitiveParams));
						if (Settings.s.isCatchThemAll) {
							SerializeField(s, nameof(UvY_Flip), type: typeof(byte));
						}
						SerializeField(s, nameof(lockTexture));
						SerializeField(s, nameof(MatShader));
					}
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(EventShowColorDst));
					SerializeField(s, nameof(disablePhysic));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(VisualPolyPointLocal));
					SerializeField(s, nameof(AABB_MinZ));
					SerializeField(s, nameof(AABB_MaxZ));
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(LOCAL_POINTS));
					SerializeField(s, nameof(LOOP));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(PointsList));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(ConfigName));
					SerializeField(s, nameof(SwitchTexturePipeExtremity));
					SerializeField(s, nameof(SwitchExtremityStart), boolAsByte: true);
					SerializeField(s, nameof(SwitchExtremityStop), boolAsByte: true);
					SerializeField(s, nameof(FillUVOrigin));
					SerializeField(s, nameof(PreComputedForCook), boolAsByte: true);
					SerializeField(s, nameof(XfForCook));
					SerializeField(s, nameof(DepthForCook));
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							SerializeField(s, nameof(ColorFactor));
							SerializeField(s, nameof(ColorFog));
							SerializeField(s, nameof(useStaticFog), boolAsByte: true);
							SerializeField(s, nameof(renderInRelection), boolAsByte: true);
						}
						SerializeField(s, nameof(PrimitiveParameters));
						SerializeField(s, nameof(DepthOffset));
						SerializeField(s, nameof(UvX_Offset));
						SerializeField(s, nameof(UvY_Offset));
						SerializeField(s, nameof(UvX_Flip), boolAsByte: true);
						SerializeField(s, nameof(UvY_Flip), boolAsByte: true);
						SerializeField(s, nameof(uvY_Tile));
						SerializeField(s, nameof(Filling_OffSetUv));
						SerializeField(s, nameof(Anim_SyncGlobal));
						SerializeField(s, nameof(AtlasIndex));
						SerializeField(s, nameof(AtlasTessellationIndex));
						SerializeField(s, nameof(Thickness));
						SerializeField(s, nameof(UseMovingCollision), boolAsByte: true);
						SerializeField(s, nameof(UseTemplatePrimitiveParams), boolAsByte: true);
						SerializeField(s, nameof(lockTexture));
						SerializeField(s, nameof(MatShader));
					}
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(EventShowColorDst));
					SerializeField(s, nameof(disablePhysic));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(collisionData));
					SerializeField(s, nameof(meshStaticData));
					SerializeField(s, nameof(meshAnimData));
					SerializeField(s, nameof(meshOverlayData));
					SerializeField(s, nameof(VisualPolyline));
					SerializeField(s, nameof(VisualPolyPointLocal));
					SerializeField(s, nameof(meshBuildData));
					SerializeField(s, nameof(meshFluidData));
					SerializeField(s, nameof(AABB_MinZ));
					SerializeField(s, nameof(AABB_MaxZ));
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(LOCAL_POINTS));
					SerializeField(s, nameof(LOOP));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(PointsList));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(ConfigName));
					SerializeField(s, nameof(SwitchTexturePipeExtremity));
					SerializeField(s, nameof(SwitchExtremityStart));
					SerializeField(s, nameof(SwitchExtremityStop));
					SerializeField(s, nameof(FillUVOrigin));
					SerializeField(s, nameof(PreComputedForCook));
					SerializeField(s, nameof(XfForCook));
					SerializeField(s, nameof(DepthForCook));
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							SerializeField(s, nameof(ColorFactor));
							SerializeField(s, nameof(ColorFog));
							SerializeField(s, nameof(useStaticFog));
							SerializeField(s, nameof(renderInRelection));
						}
						SerializeField(s, nameof(PrimitiveParameters));
						SerializeField(s, nameof(DepthOffset));
						SerializeField(s, nameof(UvX_Offset));
						SerializeField(s, nameof(UvY_Offset));
						SerializeField(s, nameof(UvX_Flip));
						SerializeField(s, nameof(UvY_Flip));
						SerializeField(s, nameof(uvY_Tile));
						SerializeField(s, nameof(Filling_OffSetUv));
						SerializeField(s, nameof(Anim_SyncGlobal));
						SerializeField(s, nameof(AtlasIndex));
						SerializeField(s, nameof(AtlasTessellationIndex));
						SerializeField(s, nameof(Thickness));
						SerializeField(s, nameof(UseMovingCollision));
						SerializeField(s, nameof(UseTemplatePrimitiveParams));
						SerializeField(s, nameof(lockTexture));
						SerializeField(s, nameof(MatShader));
					}
				}
				SerializeField(s, nameof(Mesh3dSeed));
				SerializeField(s, nameof(MeshManualySet));
				SerializeField(s, nameof(animSpeedFactor));
				SerializeField(s, nameof(animAmplitudeFactor));
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(EventShowColorDst));
					SerializeField(s, nameof(disablePhysic));
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(collisionData));
					SerializeField(s, nameof(meshStaticData));
					SerializeField(s, nameof(meshAnimData));
					SerializeField(s, nameof(meshOverlayData));
				}
				SerializeField(s, nameof(VisualPolyline));
				SerializeField(s, nameof(VisualPolyPointLocal));
				SerializeField(s, nameof(meshBuildData));
				SerializeField(s, nameof(meshFluidData));
				SerializeField(s, nameof(AABB_MinZ));
				SerializeField(s, nameof(AABB_MaxZ));
				if (s.HasFlags(SerializeFlags.Flags8)) {
					SerializeField(s, nameof(LOCAL_POINTS));
					SerializeField(s, nameof(LOOP));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(PointsList));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(ConfigName));
					SerializeField(s, nameof(SwitchTexturePipeExtremity));
					SerializeField(s, nameof(SwitchExtremityStart));
					SerializeField(s, nameof(SwitchExtremityStop));
					SerializeField(s, nameof(FillUVOrigin));
					SerializeField(s, nameof(PreComputedForCook));
					SerializeField(s, nameof(XfForCook));
					SerializeField(s, nameof(DepthForCook));
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							SerializeField(s, nameof(ColorFactor));
							SerializeField(s, nameof(ColorFog));
						}
						SerializeField(s, nameof(PrimitiveParameters));
						SerializeField(s, nameof(DepthOffset));
						SerializeField(s, nameof(UvX_Offset));
						SerializeField(s, nameof(UvY_Offset));
						SerializeField(s, nameof(UvX_Flip));
						SerializeField(s, nameof(UvY_Flip));
						SerializeField(s, nameof(uvY_Tile));
						SerializeField(s, nameof(Filling_OffSetUv));
						SerializeField(s, nameof(Anim_SyncGlobal));
						SerializeField(s, nameof(AtlasIndex));
						SerializeField(s, nameof(AtlasTessellationIndex));
						SerializeField(s, nameof(Thickness));
						SerializeField(s, nameof(UseMovingCollision));
						SerializeField(s, nameof(UseTemplatePrimitiveParams));
						SerializeField(s, nameof(lockTexture));
						SerializeField(s, nameof(MatShader));
					}
				}
				SerializeField(s, nameof(Mesh3dSeed));
				SerializeField(s, nameof(MeshManualySet));
				SerializeField(s, nameof(animSpeedFactor));
				SerializeField(s, nameof(animAmplitudeFactor));
				SerializeField(s, nameof(highlightOutlineColor));
				SerializeField(s, nameof(highlightFrontLightBrightness));
				SerializeField(s, nameof(highlightOutlineWidth));
				SerializeField(s, nameof(highlightPeriod));
				SerializeField(s, nameof(highlightAmplitude));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class MeshStaticData : CSerializable {
			[Serialize("LocalAABB")] public AABB LocalAABB;
			[Serialize("WorldAABB")] public AABB WorldAABB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(LocalAABB));
				SerializeField(s, nameof(WorldAABB));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class MeshAnimData : CSerializable {
			[Serialize("LocalAABB")] public AABB LocalAABB;
			[Serialize("WorldAABB")] public AABB WorldAABB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(LocalAABB));
				SerializeField(s, nameof(WorldAABB));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class MeshOverlayData : CSerializable {
			[Serialize("LocalAABB")] public AABB LocalAABB;
			[Serialize("WorldAABB")] public AABB WorldAABB;
			[Serialize("CosAngle" )] public float CosAngle;
			[Serialize("SinAngle" )] public float SinAngle;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(LocalAABB));
				SerializeField(s, nameof(WorldAABB));
				SerializeField(s, nameof(CosAngle));
				SerializeField(s, nameof(SinAngle));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
		public partial class IndexList : CSerializable {
			[Serialize("List"       )] public CList<ushort> List;
			[Serialize("IdTexConfig")] public uint IdTexConfig;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(List));
				SerializeField(s, nameof(IdTexConfig));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class MeshBuildData : CSerializable {
			[Serialize("AnimIndexList"    )] public CList<Frise.IndexList> AnimIndexList;
			[Serialize("AnimVertexList"   )] public CList<VertexPNC3T> AnimVertexList;
			[Serialize("StaticIndexList"  )] public CList<Frise.IndexList> StaticIndexList;
			[Serialize("StaticVertexList" )] public CList<VertexPCT> StaticVertexList;
			[Serialize("OverlayIndexList" )] public Frise.IndexList OverlayIndexList;
			[Serialize("OverlayVertexList")] public CList<VertexPCBT> OverlayVertexList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(AnimIndexList));
				SerializeField(s, nameof(AnimVertexList));
				SerializeField(s, nameof(StaticIndexList));
				SerializeField(s, nameof(StaticVertexList));
				SerializeField(s, nameof(OverlayIndexList));
				SerializeField(s, nameof(OverlayVertexList));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class MeshFluidData : CSerializable {
			[Serialize("Data"     )] public DataFluid Data;
			[Serialize("LocalAABB")] public AABB LocalAABB;
			[Serialize("WorldAABB")] public AABB WorldAABB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Data));
				SerializeField(s, nameof(LocalAABB));
				SerializeField(s, nameof(WorldAABB));
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class CollisionData : CSerializable {
			[Serialize("LocalCollisionList")] public CList<PolyPointList> LocalCollisionList;
			[Serialize("WorldCollisionList")] public CList<PolyLine> WorldCollisionList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(LocalCollisionList));
				SerializeField(s, nameof(WorldCollisionList));
			}
		}
		public enum LockTexture {
			[Serialize("LockTexture_None"  )] None = 4,
			[Serialize("LockTexture_Top"   )] Top = 0,
			[Serialize("LockTexture_Right" )] Right = 1,
			[Serialize("LockTexture_Left"  )] Left = 2,
			[Serialize("LockTexture_Bottom")] Bottom = 3,
			[Serialize("LockTexture_Switch")] Switch = 5,
		}
		public enum PivotMode {
			No = 0,
			Yes = 1
		}
		public override uint? ClassCRC => 0x99BA2AA8;
	}
}

