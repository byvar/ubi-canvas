namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class Frise : Actor {
		public Color EventShowColorDst;
		public bool disablePhysic;
		public Nullable<Frise.CollisionData> collisionData;
		public Nullable<Frise.MeshStaticData> meshStaticData;
		public Nullable<Frise.MeshAnimData> meshAnimData;
		public Nullable<Frise.MeshOverlayData> meshOverlayData;
		public PolyLine VisualPolyline;
		public PolyPointList VisualPolyPointLocal;
		public Nullable<Frise.MeshBuildData> meshBuildData;
		public Nullable<Frise.MeshFluidData> meshFluidData;
		public float AABB_MinZ;
		public float AABB_MaxZ;
		public CListO<PolyLineEdge> LOCAL_POINTS;
		public bool LOOP;
		public PolyPointList PointsList;
		public Path ConfigName;
		public uint SwitchTexturePipeExtremity;
		public bool SwitchExtremityStart;
		public bool SwitchExtremityStop;
		public Vec2d FillUVOrigin;
		public bool PreComputedForCook;
		public Transform2d XfForCook;
		public float DepthForCook;
		public Color ColorFactor { get => PrimitiveParameters.colorFactor; set { PrimitiveParameters.colorFactor = value; } }
		public Color ColorFog { get => PrimitiveParameters.colorFog; set { PrimitiveParameters.colorFog = value; } }
		public GFXPrimitiveParam PrimitiveParameters = new GFXPrimitiveParam();
		public float DepthOffset;
		public float UvX_Offset;
		public float UvY_Offset;
		public bool UvX_Flip;
		public bool UvY_Flip;
		public float uvY_Tile = 1f;
		public Vec2d Filling_OffSetUv;
		public float Anim_SyncGlobal;
		public uint AtlasIndex;
		public uint AtlasTessellationIndex;
		public float Thickness = 1f;
		public bool UseMovingCollision;
		public bool UseTemplatePrimitiveParams = true;
		public LockTexture lockTexture = LockTexture.None;
		public Path MatShader;
		public uint Mesh3dSeed;
		public CListP<int> MeshManualySet;
		public float animSpeedFactor = 1f;
		public float animAmplitudeFactor = 1f;
		public Color highlightOutlineColor = Color.White;
		public float highlightFrontLightBrightness = 1.5f;
		public float highlightOutlineWidth = 4f;
		public float highlightPeriod = 1f;
		public float highlightAmplitude = 0.21f;
		public CListO<PolyLineEdge> POINTS;
		public PivotMode pivotMode;
		public Vec2d USERPIVOT;
		public float ColorFactor_Red;
		public float ColorFactor_Green;
		public float ColorFactor_Blu;
		public float ColorFactor_Alpha;
		public float ColorFog_Red;
		public float ColorFog_Green;
		public float ColorFog_Blu;
		public float fogfactor;
		public uint ColorComputerTagId;
		public int renderInTarget;
		public int IsDynamicFrieze;
		public bool useStaticFog { get => PrimitiveParameters.useStaticFog; set { PrimitiveParameters.useStaticFog = value; } }
		public bool renderInRelection { get => PrimitiveParameters.RenderInReflections; set { PrimitiveParameters.RenderInReflections = value; } }


		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					LOCAL_POINTS = s.SerializeObject<CListO<PolyLineEdge>>(LOCAL_POINTS, name: "LOCAL_POINTS");
				}
				if (s.HasFlags(SerializeFlags.Flags6 | SerializeFlags.Flags8)) {
					POINTS = s.SerializeObject<CListO<PolyLineEdge>>(POINTS, name: "POINTS");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					pivotMode = s.Serialize<PivotMode>(pivotMode, name: "PivotMode");
					LOOP = s.Serialize<bool>(LOOP, name: "LOOP");
					USERPIVOT = s.SerializeObject<Vec2d>(USERPIVOT, name: "USERPIVOT");
					ConfigName = s.SerializeObject<Path>(ConfigName, name: "ConfigName");
					SwitchTexturePipeExtremity = s.Serialize<uint>(SwitchTexturePipeExtremity, name: "SwitchTexturePipeExtremity");
					if (s.HasFlags(SerializeFlags.Default)) {
						if (!s.HasProperty(CSerializerObject.SerializerProperty.Binary)) {
							ColorFactor_Red = s.Serialize<float>(ColorFactor_Red, name: "ColorFactor_Red");
							ColorFactor_Green = s.Serialize<float>(ColorFactor_Green, name: "ColorFactor_Green");
							ColorFactor_Blu = s.Serialize<float>(ColorFactor_Blu, name: "ColorFactor_Blu");
							ColorFactor_Alpha = s.Serialize<float>(ColorFactor_Alpha, name: "ColorFactor_Alpha");
							ColorFog_Red = s.Serialize<float>(ColorFog_Red, name: "ColorFog_Red");
							ColorFog_Green = s.Serialize<float>(ColorFog_Green, name: "ColorFog_Green");
							ColorFog_Blu = s.Serialize<float>(ColorFog_Blu, name: "ColorFog_Blu");
							fogfactor = s.Serialize<float>(fogfactor, name: "fogfactor");
						}
						ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
						ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
						ColorComputerTagId = s.Serialize<uint>(ColorComputerTagId, name: "ColorComputerTagId");
						renderInTarget = s.Serialize<int>(renderInTarget, name: "renderInTarget");
						UvX_Offset = s.Serialize<float>(UvX_Offset, name: "UvX_Offset");
						UvY_Offset = s.Serialize<float>(UvY_Offset, name: "UvY_Offset");
						UvX_Flip = s.Serialize<bool>(UvX_Flip, name: "UvX_Flip", options: CSerializerObject.Options.ForceAsByte);
						UvY_Flip = s.Serialize<bool>(UvY_Flip, name: "UvY_Flip", options: CSerializerObject.Options.ForceAsByte);
						uvY_Tile = s.Serialize<float>(uvY_Tile, name: "uvY_Tile");
						Filling_OffSetUv = s.SerializeObject<Vec2d>(Filling_OffSetUv, name: "Filling_OffSetUv");
						Anim_SyncGlobal = s.Serialize<float>(Anim_SyncGlobal, name: "Anim_SyncGlobal");
						IsDynamicFrieze = s.Serialize<int>(IsDynamicFrieze, name: "IsDynamicFrieze");
						AtlasIndex = s.Serialize<uint>(AtlasIndex, name: "AtlasIndex");
						Thickness = s.Serialize<float>(Thickness, name: "Thickness");
						lockTexture = s.Serialize<LockTexture>(lockTexture, name: "LockTexture");
					}
				}
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					EventShowColorDst = s.SerializeObject<Color>(EventShowColorDst, name: "EventShowColorDst");
					disablePhysic = s.Serialize<bool>(disablePhysic, name: "disablePhysic");
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					collisionData = s.SerializeObject<Nullable<Frise.CollisionData>>(collisionData, name: "CollisionData");
					meshStaticData = s.SerializeObject<Nullable<Frise.MeshStaticData>>(meshStaticData, name: "MeshStaticData");
					meshAnimData = s.SerializeObject<Nullable<Frise.MeshAnimData>>(meshAnimData, name: "MeshAnimData");
					meshOverlayData = s.SerializeObject<Nullable<Frise.MeshOverlayData>>(meshOverlayData, name: "MeshOverlayData");
					VisualPolyline = s.SerializeObject<PolyLine>(VisualPolyline, name: "VisualPolyline");
					VisualPolyPointLocal = s.SerializeObject<PolyPointList>(VisualPolyPointLocal, name: "VisualPolyPointLocal");
					if (s.Settings.platform == Settings.Platform.Vita) {
						meshBuildData = new Nullable<MeshBuildData>();
						meshBuildData.read = true;
						meshBuildData.value = s.SerializeObject<MeshBuildData>(meshBuildData.value, name: "MeshBuildData");
					} else {
						meshBuildData = s.SerializeObject<Nullable<Frise.MeshBuildData>>(meshBuildData, name: "MeshBuildData");
					}
					meshFluidData = s.SerializeObject<Nullable<Frise.MeshFluidData>>(meshFluidData, name: "MeshFluidData");
					AABB_MinZ = s.Serialize<float>(AABB_MinZ, name: "AABB_MinZ");
					AABB_MaxZ = s.Serialize<float>(AABB_MaxZ, name: "AABB_MaxZ");
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					LOCAL_POINTS = s.SerializeObject<CListO<PolyLineEdge>>(LOCAL_POINTS, name: "LOCAL_POINTS");
					LOOP = s.Serialize<bool>(LOOP, name: "LOOP");
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					PointsList = s.SerializeObject<PolyPointList>(PointsList, name: "PointsList");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					ConfigName = s.SerializeObject<Path>(ConfigName, name: "ConfigName");
					SwitchTexturePipeExtremity = s.Serialize<uint>(SwitchTexturePipeExtremity, name: "SwitchTexturePipeExtremity");
					SwitchExtremityStart = s.Serialize<bool>(SwitchExtremityStart, name: "SwitchExtremityStart");
					SwitchExtremityStop = s.Serialize<bool>(SwitchExtremityStop, name: "SwitchExtremityStop");
					FillUVOrigin = s.SerializeObject<Vec2d>(FillUVOrigin, name: "FillUVOrigin");
					PreComputedForCook = s.Serialize<bool>(PreComputedForCook, name: "PreComputedForCook");
					XfForCook = s.SerializeObject<Transform2d>(XfForCook, name: "XfForCook");
					DepthForCook = s.Serialize<float>(DepthForCook, name: "DepthForCook");
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
							ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
							useStaticFog = s.Serialize<bool>(useStaticFog, name: "useStaticFog");
							renderInRelection = s.Serialize<bool>(renderInRelection, name: "renderInRelection");
						}
						PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
						if (s.Settings.platform != Settings.Platform.Vita) {
							DepthOffset = s.Serialize<float>(DepthOffset, name: "DepthOffset");
						}
						UvX_Offset = s.Serialize<float>(UvX_Offset, name: "UvX_Offset");
						UvY_Offset = s.Serialize<float>(UvY_Offset, name: "UvY_Offset");
						UvX_Flip = s.Serialize<bool>(UvX_Flip, name: "UvX_Flip", options: CSerializerObject.Options.ForceAsByte);
						UvY_Flip = s.Serialize<bool>(UvY_Flip, name: "UvY_Flip", options: CSerializerObject.Options.ForceAsByte);
						uvY_Tile = s.Serialize<float>(uvY_Tile, name: "uvY_Tile");
						Filling_OffSetUv = s.SerializeObject<Vec2d>(Filling_OffSetUv, name: "Filling_OffSetUv");
						Anim_SyncGlobal = s.Serialize<float>(Anim_SyncGlobal, name: "Anim_SyncGlobal");
						AtlasIndex = s.Serialize<uint>(AtlasIndex, name: "AtlasIndex");
						AtlasTessellationIndex = s.Serialize<uint>(AtlasTessellationIndex, name: "AtlasTessellationIndex");
						Thickness = s.Serialize<float>(Thickness, name: "Thickness");
						UseMovingCollision = s.Serialize<bool>(UseMovingCollision, name: "UseMovingCollision");
						UseTemplatePrimitiveParams = s.Serialize<bool>(UseTemplatePrimitiveParams, name: "UseTemplatePrimitiveParams");
						if (s.Settings.isCatchThemAll) {
							UvY_Flip = s.Serialize<bool>(UvY_Flip, name: "UvY_Flip", options: CSerializerObject.Options.ForceAsByte);
						}
						lockTexture = s.Serialize<LockTexture>(lockTexture, name: "LockTexture");
						MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					}
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					EventShowColorDst = s.SerializeObject<Color>(EventShowColorDst, name: "EventShowColorDst");
					disablePhysic = s.Serialize<bool>(disablePhysic, name: "disablePhysic");
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					collisionData = s.SerializeObject<Nullable<Frise.CollisionData>>(collisionData, name: "CollisionData");
					meshStaticData = s.SerializeObject<Nullable<Frise.MeshStaticData>>(meshStaticData, name: "MeshStaticData");
					meshAnimData = s.SerializeObject<Nullable<Frise.MeshAnimData>>(meshAnimData, name: "MeshAnimData");
					meshOverlayData = s.SerializeObject<Nullable<Frise.MeshOverlayData>>(meshOverlayData, name: "MeshOverlayData");
					VisualPolyline = s.SerializeObject<PolyLine>(VisualPolyline, name: "VisualPolyline");
					VisualPolyPointLocal = s.SerializeObject<PolyPointList>(VisualPolyPointLocal, name: "VisualPolyPointLocal");
					meshBuildData = s.SerializeObject<Nullable<Frise.MeshBuildData>>(meshBuildData, name: "MeshBuildData");
					meshFluidData = s.SerializeObject<Nullable<Frise.MeshFluidData>>(meshFluidData, name: "MeshFluidData");
					AABB_MinZ = s.Serialize<float>(AABB_MinZ, name: "AABB_MinZ");
					AABB_MaxZ = s.Serialize<float>(AABB_MaxZ, name: "AABB_MaxZ");
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					LOCAL_POINTS = s.SerializeObject<CListO<PolyLineEdge>>(LOCAL_POINTS, name: "LOCAL_POINTS");
					LOOP = s.Serialize<bool>(LOOP, name: "LOOP");
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					PointsList = s.SerializeObject<PolyPointList>(PointsList, name: "PointsList");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					ConfigName = s.SerializeObject<Path>(ConfigName, name: "ConfigName");
					SwitchTexturePipeExtremity = s.Serialize<uint>(SwitchTexturePipeExtremity, name: "SwitchTexturePipeExtremity");
					SwitchExtremityStart = s.Serialize<bool>(SwitchExtremityStart, name: "SwitchExtremityStart", options: CSerializerObject.Options.BoolAsByte);
					SwitchExtremityStop = s.Serialize<bool>(SwitchExtremityStop, name: "SwitchExtremityStop", options: CSerializerObject.Options.BoolAsByte);
					FillUVOrigin = s.SerializeObject<Vec2d>(FillUVOrigin, name: "FillUVOrigin");
					PreComputedForCook = s.Serialize<bool>(PreComputedForCook, name: "PreComputedForCook", options: CSerializerObject.Options.BoolAsByte);
					XfForCook = s.SerializeObject<Transform2d>(XfForCook, name: "XfForCook");
					DepthForCook = s.Serialize<float>(DepthForCook, name: "DepthForCook");
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
							ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
							useStaticFog = s.Serialize<bool>(useStaticFog, name: "useStaticFog", options: CSerializerObject.Options.BoolAsByte);
							renderInRelection = s.Serialize<bool>(renderInRelection, name: "renderInRelection", options: CSerializerObject.Options.BoolAsByte);
						}
						PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
						DepthOffset = s.Serialize<float>(DepthOffset, name: "DepthOffset");
						UvX_Offset = s.Serialize<float>(UvX_Offset, name: "UvX_Offset");
						UvY_Offset = s.Serialize<float>(UvY_Offset, name: "UvY_Offset");
						UvX_Flip = s.Serialize<bool>(UvX_Flip, name: "UvX_Flip", options: CSerializerObject.Options.BoolAsByte);
						UvY_Flip = s.Serialize<bool>(UvY_Flip, name: "UvY_Flip", options: CSerializerObject.Options.BoolAsByte);
						uvY_Tile = s.Serialize<float>(uvY_Tile, name: "uvY_Tile");
						Filling_OffSetUv = s.SerializeObject<Vec2d>(Filling_OffSetUv, name: "Filling_OffSetUv");
						Anim_SyncGlobal = s.Serialize<float>(Anim_SyncGlobal, name: "Anim_SyncGlobal");
						AtlasIndex = s.Serialize<uint>(AtlasIndex, name: "AtlasIndex");
						AtlasTessellationIndex = s.Serialize<uint>(AtlasTessellationIndex, name: "AtlasTessellationIndex");
						Thickness = s.Serialize<float>(Thickness, name: "Thickness");
						UseMovingCollision = s.Serialize<bool>(UseMovingCollision, name: "UseMovingCollision", options: CSerializerObject.Options.BoolAsByte);
						UseTemplatePrimitiveParams = s.Serialize<bool>(UseTemplatePrimitiveParams, name: "UseTemplatePrimitiveParams", options: CSerializerObject.Options.BoolAsByte);
						lockTexture = s.Serialize<LockTexture>(lockTexture, name: "LockTexture");
						MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					}
				}
			} else if (s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					EventShowColorDst = s.SerializeObject<Color>(EventShowColorDst, name: "EventShowColorDst");
					disablePhysic = s.Serialize<bool>(disablePhysic, name: "disablePhysic");
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					collisionData = s.SerializeObject<Nullable<Frise.CollisionData>>(collisionData, name: "CollisionData");
					meshStaticData = s.SerializeObject<Nullable<Frise.MeshStaticData>>(meshStaticData, name: "MeshStaticData");
					meshAnimData = s.SerializeObject<Nullable<Frise.MeshAnimData>>(meshAnimData, name: "MeshAnimData");
					meshOverlayData = s.SerializeObject<Nullable<Frise.MeshOverlayData>>(meshOverlayData, name: "MeshOverlayData");
					VisualPolyline = s.SerializeObject<PolyLine>(VisualPolyline, name: "VisualPolyline");
					VisualPolyPointLocal = s.SerializeObject<PolyPointList>(VisualPolyPointLocal, name: "VisualPolyPointLocal");
					meshBuildData = s.SerializeObject<Nullable<Frise.MeshBuildData>>(meshBuildData, name: "MeshBuildData");
					meshFluidData = s.SerializeObject<Nullable<Frise.MeshFluidData>>(meshFluidData, name: "MeshFluidData");
					AABB_MinZ = s.Serialize<float>(AABB_MinZ, name: "AABB_MinZ");
					AABB_MaxZ = s.Serialize<float>(AABB_MaxZ, name: "AABB_MaxZ");
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					LOCAL_POINTS = s.SerializeObject<CListO<PolyLineEdge>>(LOCAL_POINTS, name: "LOCAL_POINTS");
					LOOP = s.Serialize<bool>(LOOP, name: "LOOP");
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					PointsList = s.SerializeObject<PolyPointList>(PointsList, name: "PointsList");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					ConfigName = s.SerializeObject<Path>(ConfigName, name: "ConfigName");
					SwitchTexturePipeExtremity = s.Serialize<uint>(SwitchTexturePipeExtremity, name: "SwitchTexturePipeExtremity");
					SwitchExtremityStart = s.Serialize<bool>(SwitchExtremityStart, name: "SwitchExtremityStart");
					SwitchExtremityStop = s.Serialize<bool>(SwitchExtremityStop, name: "SwitchExtremityStop");
					FillUVOrigin = s.SerializeObject<Vec2d>(FillUVOrigin, name: "FillUVOrigin");
					PreComputedForCook = s.Serialize<bool>(PreComputedForCook, name: "PreComputedForCook");
					XfForCook = s.SerializeObject<Transform2d>(XfForCook, name: "XfForCook");
					DepthForCook = s.Serialize<float>(DepthForCook, name: "DepthForCook");
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
							ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
							useStaticFog = s.Serialize<bool>(useStaticFog, name: "useStaticFog");
							renderInRelection = s.Serialize<bool>(renderInRelection, name: "renderInRelection");
						}
						PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
						DepthOffset = s.Serialize<float>(DepthOffset, name: "DepthOffset");
						UvX_Offset = s.Serialize<float>(UvX_Offset, name: "UvX_Offset");
						UvY_Offset = s.Serialize<float>(UvY_Offset, name: "UvY_Offset");
						UvX_Flip = s.Serialize<bool>(UvX_Flip, name: "UvX_Flip");
						UvY_Flip = s.Serialize<bool>(UvY_Flip, name: "UvY_Flip");
						uvY_Tile = s.Serialize<float>(uvY_Tile, name: "uvY_Tile");
						Filling_OffSetUv = s.SerializeObject<Vec2d>(Filling_OffSetUv, name: "Filling_OffSetUv");
						Anim_SyncGlobal = s.Serialize<float>(Anim_SyncGlobal, name: "Anim_SyncGlobal");
						AtlasIndex = s.Serialize<uint>(AtlasIndex, name: "AtlasIndex");
						AtlasTessellationIndex = s.Serialize<uint>(AtlasTessellationIndex, name: "AtlasTessellationIndex");
						Thickness = s.Serialize<float>(Thickness, name: "Thickness");
						UseMovingCollision = s.Serialize<bool>(UseMovingCollision, name: "UseMovingCollision");
						UseTemplatePrimitiveParams = s.Serialize<bool>(UseTemplatePrimitiveParams, name: "UseTemplatePrimitiveParams");
						lockTexture = s.Serialize<LockTexture>(lockTexture, name: "LockTexture");
						MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					}
				}
				Mesh3dSeed = s.Serialize<uint>(Mesh3dSeed, name: "Mesh3dSeed");
				MeshManualySet = s.SerializeObject<CListP<int>>(MeshManualySet, name: "MeshManualySet");
				animSpeedFactor = s.Serialize<float>(animSpeedFactor, name: "animSpeedFactor");
				animAmplitudeFactor = s.Serialize<float>(animAmplitudeFactor, name: "animAmplitudeFactor");
			} else {
				if (s.HasFlags(SerializeFlags.Persistent)) {
					EventShowColorDst = s.SerializeObject<Color>(EventShowColorDst, name: "EventShowColorDst");
					disablePhysic = s.Serialize<bool>(disablePhysic, name: "disablePhysic");
				}
				if (s.HasFlags(SerializeFlags.Flags10)) {
					collisionData = s.SerializeObject<Nullable<Frise.CollisionData>>(collisionData, name: "CollisionData");
					meshStaticData = s.SerializeObject<Nullable<Frise.MeshStaticData>>(meshStaticData, name: "MeshStaticData");
					meshAnimData = s.SerializeObject<Nullable<Frise.MeshAnimData>>(meshAnimData, name: "MeshAnimData");
					meshOverlayData = s.SerializeObject<Nullable<Frise.MeshOverlayData>>(meshOverlayData, name: "MeshOverlayData");
				}
				VisualPolyline = s.SerializeObject<PolyLine>(VisualPolyline, name: "VisualPolyline");
				VisualPolyPointLocal = s.SerializeObject<PolyPointList>(VisualPolyPointLocal, name: "VisualPolyPointLocal");
				meshBuildData = s.SerializeObject<Nullable<Frise.MeshBuildData>>(meshBuildData, name: "MeshBuildData");
				meshFluidData = s.SerializeObject<Nullable<Frise.MeshFluidData>>(meshFluidData, name: "MeshFluidData");
				AABB_MinZ = s.Serialize<float>(AABB_MinZ, name: "AABB_MinZ");
				AABB_MaxZ = s.Serialize<float>(AABB_MaxZ, name: "AABB_MaxZ");
				if (s.HasFlags(SerializeFlags.Flags8)) {
					LOCAL_POINTS = s.SerializeObject<CListO<PolyLineEdge>>(LOCAL_POINTS, name: "LOCAL_POINTS");
					LOOP = s.Serialize<bool>(LOOP, name: "LOOP");
				}
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Flags_xC0)) {
					PointsList = s.SerializeObject<PolyPointList>(PointsList, name: "PointsList");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					ConfigName = s.SerializeObject<Path>(ConfigName, name: "ConfigName");
					SwitchTexturePipeExtremity = s.Serialize<uint>(SwitchTexturePipeExtremity, name: "SwitchTexturePipeExtremity");
					SwitchExtremityStart = s.Serialize<bool>(SwitchExtremityStart, name: "SwitchExtremityStart");
					SwitchExtremityStop = s.Serialize<bool>(SwitchExtremityStop, name: "SwitchExtremityStop");
					FillUVOrigin = s.SerializeObject<Vec2d>(FillUVOrigin, name: "FillUVOrigin");
					PreComputedForCook = s.Serialize<bool>(PreComputedForCook, name: "PreComputedForCook");
					XfForCook = s.SerializeObject<Transform2d>(XfForCook, name: "XfForCook");
					DepthForCook = s.Serialize<float>(DepthForCook, name: "DepthForCook");
					if (s.HasFlags(SerializeFlags.Default)) {
						if (s.HasFlags(SerializeFlags.Flags8)) {
							ColorFactor = s.SerializeObject<Color>(ColorFactor, name: "ColorFactor");
							ColorFog = s.SerializeObject<Color>(ColorFog, name: "ColorFog");
						}
						PrimitiveParameters = s.SerializeObject<GFXPrimitiveParam>(PrimitiveParameters, name: "PrimitiveParameters");
						DepthOffset = s.Serialize<float>(DepthOffset, name: "DepthOffset");
						UvX_Offset = s.Serialize<float>(UvX_Offset, name: "UvX_Offset");
						UvY_Offset = s.Serialize<float>(UvY_Offset, name: "UvY_Offset");
						UvX_Flip = s.Serialize<bool>(UvX_Flip, name: "UvX_Flip");
						UvY_Flip = s.Serialize<bool>(UvY_Flip, name: "UvY_Flip");
						uvY_Tile = s.Serialize<float>(uvY_Tile, name: "uvY_Tile");
						Filling_OffSetUv = s.SerializeObject<Vec2d>(Filling_OffSetUv, name: "Filling_OffSetUv");
						Anim_SyncGlobal = s.Serialize<float>(Anim_SyncGlobal, name: "Anim_SyncGlobal");
						AtlasIndex = s.Serialize<uint>(AtlasIndex, name: "AtlasIndex");
						AtlasTessellationIndex = s.Serialize<uint>(AtlasTessellationIndex, name: "AtlasTessellationIndex");
						Thickness = s.Serialize<float>(Thickness, name: "Thickness");
						UseMovingCollision = s.Serialize<bool>(UseMovingCollision, name: "UseMovingCollision");
						UseTemplatePrimitiveParams = s.Serialize<bool>(UseTemplatePrimitiveParams, name: "UseTemplatePrimitiveParams");
						lockTexture = s.Serialize<LockTexture>(lockTexture, name: "LockTexture");
						MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					}
				}
				Mesh3dSeed = s.Serialize<uint>(Mesh3dSeed, name: "Mesh3dSeed");
				MeshManualySet = s.SerializeObject<CListP<int>>(MeshManualySet, name: "MeshManualySet");
				animSpeedFactor = s.Serialize<float>(animSpeedFactor, name: "animSpeedFactor");
				animAmplitudeFactor = s.Serialize<float>(animAmplitudeFactor, name: "animAmplitudeFactor");
				highlightOutlineColor = s.SerializeObject<Color>(highlightOutlineColor, name: "highlightOutlineColor");
				highlightFrontLightBrightness = s.Serialize<float>(highlightFrontLightBrightness, name: "highlightFrontLightBrightness");
				highlightOutlineWidth = s.Serialize<float>(highlightOutlineWidth, name: "highlightOutlineWidth");
				highlightPeriod = s.Serialize<float>(highlightPeriod, name: "highlightPeriod");
				highlightAmplitude = s.Serialize<float>(highlightAmplitude, name: "highlightAmplitude");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class MeshStaticData : CSerializable {
			public AABB LocalAABB;
			public AABB WorldAABB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				LocalAABB = s.SerializeObject<AABB>(LocalAABB, name: "LocalAABB");
				WorldAABB = s.SerializeObject<AABB>(WorldAABB, name: "WorldAABB");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class MeshAnimData : CSerializable {
			public AABB LocalAABB;
			public AABB WorldAABB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				LocalAABB = s.SerializeObject<AABB>(LocalAABB, name: "LocalAABB");
				WorldAABB = s.SerializeObject<AABB>(WorldAABB, name: "WorldAABB");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class MeshOverlayData : CSerializable {
			public AABB LocalAABB;
			public AABB WorldAABB;
			public float CosAngle;
			public float SinAngle;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				LocalAABB = s.SerializeObject<AABB>(LocalAABB, name: "LocalAABB");
				WorldAABB = s.SerializeObject<AABB>(WorldAABB, name: "WorldAABB");
				CosAngle = s.Serialize<float>(CosAngle, name: "CosAngle");
				SinAngle = s.Serialize<float>(SinAngle, name: "SinAngle");
			}
		}
		[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
		public partial class IndexList : CSerializable {
			public CListP<ushort> List;
			public uint IdTexConfig;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				List = s.SerializeObject<CListP<ushort>>(List, name: "List");
				IdTexConfig = s.Serialize<uint>(IdTexConfig, name: "IdTexConfig");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class MeshBuildData : CSerializable {
			public CListO<Frise.IndexList> AnimIndexList;
			public CListO<VertexPNC3T> AnimVertexList;
			public CListO<Frise.IndexList> StaticIndexList;
			public CListO<VertexPCT> StaticVertexList;
			public Frise.IndexList OverlayIndexList;
			public CListO<VertexPCBT> OverlayVertexList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				AnimIndexList = s.SerializeObject<CListO<Frise.IndexList>>(AnimIndexList, name: "AnimIndexList");
				AnimVertexList = s.SerializeObject<CListO<VertexPNC3T>>(AnimVertexList, name: "AnimVertexList");
				StaticIndexList = s.SerializeObject<CListO<Frise.IndexList>>(StaticIndexList, name: "StaticIndexList");
				StaticVertexList = s.SerializeObject<CListO<VertexPCT>>(StaticVertexList, name: "StaticVertexList");
				OverlayIndexList = s.SerializeObject<Frise.IndexList>(OverlayIndexList, name: "OverlayIndexList");
				OverlayVertexList = s.SerializeObject<CListO<VertexPCBT>>(OverlayVertexList, name: "OverlayVertexList");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class MeshFluidData : CSerializable {
			public DataFluid Data;
			public AABB LocalAABB;
			public AABB WorldAABB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Data = s.SerializeObject<DataFluid>(Data, name: "Data");
				LocalAABB = s.SerializeObject<AABB>(LocalAABB, name: "LocalAABB");
				WorldAABB = s.SerializeObject<AABB>(WorldAABB, name: "WorldAABB");
			}
		}
		[Games(GameFlags.VH | GameFlags.RA)]
		public partial class CollisionData : CSerializable {
			public CListO<PolyPointList> LocalCollisionList;
			public CListO<PolyLine> WorldCollisionList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				LocalCollisionList = s.SerializeObject<CListO<PolyPointList>>(LocalCollisionList, name: "LocalCollisionList");
				WorldCollisionList = s.SerializeObject<CListO<PolyLine>>(WorldCollisionList, name: "WorldCollisionList");
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

