namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimLightComponent_Template : GraphicComponent_Template {
		public bool useBase;
		public bool smoothAnim;
		public bool blendAnimTrack;
		public bool canonizeTransitions = true;
		public uint defaultBlendFrames;
		public uint draw2D;
		public StringID visualAABBanimID;
		public SubAnimSet_Template animSet;
		public StringID defaultAnimation;
		public StringID subSkeleton;
		public Color defaultColor = Color.White;
		public bool flip;
		public float backZOffset;
		public float frontZOffset;
		public float zOrderExtract;
		public float zAmplify;
		public bool restoreStateAtCheckpoint;
		public bool disableVisiblePrediction;
		public bool notifyAnimUpdate;
		public Vec2d scale = Vec2d.One;
		public bool useZOffset = true;
		public bool allowRenderInTexture;
		public uint renderInTectureSizeX = 0x800;
		public uint renderInTectureSizeY = 0x800;
		public CListO<BoneMapping> boneList;
		public Path animationPath;
		public bool isSynchronous;

		public uint Vita_00 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				animationPath = s.SerializeObject<Path>(animationPath, name: "animationPath");
				useBase = s.Serialize<bool>(useBase, name: "useBase");
				smoothAnim = s.Serialize<bool>(smoothAnim, name: "smoothAnim");
				canonizeTransitions = s.Serialize<bool>(canonizeTransitions, name: "canonizeTransitions");
				defaultBlendFrames = s.Serialize<uint>(defaultBlendFrames, name: "defaultBlendFrames");
				draw2D = s.Serialize<uint>(draw2D, name: "draw2D");
				visualAABBanimID = s.SerializeObject<StringID>(visualAABBanimID, name: "visualAABBanimID");
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					animSet = s.SerializeObject<SubAnimSet_Template>(animSet, name: "animSet");
				}
				defaultAnimation = s.SerializeObject<StringID>(defaultAnimation, name: "defaultAnimation");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				flip = s.Serialize<bool>(flip, name: "flip");
				backZOffset = s.Serialize<float>(backZOffset, name: "backZOffset");
				frontZOffset = s.Serialize<float>(frontZOffset, name: "frontZOffset");
				isSynchronous = s.Serialize<bool>(isSynchronous, name: "isSynchronous");
				restoreStateAtCheckpoint = s.Serialize<bool>(restoreStateAtCheckpoint, name: "restoreStateAtCheckpoint");
				boneList = s.SerializeObject<CListO<BoneMapping>>(boneList, name: "boneList");
				disableVisiblePrediction = s.Serialize<bool>(disableVisiblePrediction, name: "disableVisiblePrediction");
			} else if (s.Settings.game == Settings.Game.RL) {
				useBase = s.Serialize<bool>(useBase, name: "useBase");
				smoothAnim = s.Serialize<bool>(smoothAnim, name: "smoothAnim");
				canonizeTransitions = s.Serialize<bool>(canonizeTransitions, name: "canonizeTransitions");
				defaultBlendFrames = s.Serialize<uint>(defaultBlendFrames, name: "defaultBlendFrames");
				draw2D = s.Serialize<uint>(draw2D, name: "draw2D");
				visualAABBanimID = s.SerializeObject<StringID>(visualAABBanimID, name: "visualAABBanimID");
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					animSet = s.SerializeObject<SubAnimSet_Template>(animSet, name: "animSet");
				}
				defaultAnimation = s.SerializeObject<StringID>(defaultAnimation, name: "defaultAnimation");
				subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				flip = s.Serialize<bool>(flip, name: "flip");
				backZOffset = s.Serialize<float>(backZOffset, name: "backZOffset");
				frontZOffset = s.Serialize<float>(frontZOffset, name: "frontZOffset");
				zOrderExtract = s.Serialize<float>(zOrderExtract, name: "zOrderExtract");
				zAmplify = s.Serialize<float>(zAmplify, name: "zAmplify");
				isSynchronous = s.Serialize<bool>(isSynchronous, name: "isSynchronous");
				restoreStateAtCheckpoint = s.Serialize<bool>(restoreStateAtCheckpoint, name: "restoreStateAtCheckpoint");
				disableVisiblePrediction = s.Serialize<bool>(disableVisiblePrediction, name: "disableVisiblePrediction");
				notifyAnimUpdate = s.Serialize<bool>(notifyAnimUpdate, name: "notifyAnimUpdate");
				scale = s.SerializeObject<Vec2d>(scale, name: "scale");
				useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset");
				boneList = s.SerializeObject<CListO<BoneMapping>>(boneList, name: "boneList");
				if (s.Settings.platform == Settings.Platform.Vita) {
					Vita_00 = s.Serialize<uint>(Vita_00, name: nameof(Vita_00));
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				useBase = s.Serialize<bool>(useBase, name: "useBase", options: CSerializerObject.Options.BoolAsByte);
				smoothAnim = s.Serialize<bool>(smoothAnim, name: "smoothAnim", options: CSerializerObject.Options.BoolAsByte);
				canonizeTransitions = s.Serialize<bool>(canonizeTransitions, name: "canonizeTransitions", options: CSerializerObject.Options.BoolAsByte);
				defaultBlendFrames = s.Serialize<uint>(defaultBlendFrames, name: "defaultBlendFrames");
				draw2D = s.Serialize<uint>(draw2D, name: "draw2D");
				visualAABBanimID = s.SerializeObject<StringID>(visualAABBanimID, name: "visualAABBanimID");
				defaultAnimation = s.SerializeObject<StringID>(defaultAnimation, name: "defaultAnimation");
				subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				flip = s.Serialize<bool>(flip, name: "flip", options: CSerializerObject.Options.BoolAsByte);
				backZOffset = s.Serialize<float>(backZOffset, name: "backZOffset");
				frontZOffset = s.Serialize<float>(frontZOffset, name: "frontZOffset");
				zOrderExtract = s.Serialize<float>(zOrderExtract, name: "zOrderExtract");
				zAmplify = s.Serialize<float>(zAmplify, name: "zAmplify");
				isSynchronous = s.Serialize<bool>(isSynchronous, name: "isSynchronous", options: CSerializerObject.Options.BoolAsByte);
				restoreStateAtCheckpoint = s.Serialize<bool>(restoreStateAtCheckpoint, name: "restoreStateAtCheckpoint", options: CSerializerObject.Options.BoolAsByte);
				disableVisiblePrediction = s.Serialize<bool>(disableVisiblePrediction, name: "disableVisiblePrediction", options: CSerializerObject.Options.BoolAsByte);
				notifyAnimUpdate = s.Serialize<bool>(notifyAnimUpdate, name: "notifyAnimUpdate", options: CSerializerObject.Options.BoolAsByte);
				scale = s.SerializeObject<Vec2d>(scale, name: "scale");
				useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset", options: CSerializerObject.Options.BoolAsByte);
			} else if (s.Settings.game == Settings.Game.VH) {
				useBase = s.Serialize<bool>(useBase, name: "useBase");
				smoothAnim = s.Serialize<bool>(smoothAnim, name: "smoothAnim");
				canonizeTransitions = s.Serialize<bool>(canonizeTransitions, name: "canonizeTransitions");
				defaultBlendFrames = s.Serialize<uint>(defaultBlendFrames, name: "defaultBlendFrames");
				draw2D = s.Serialize<uint>(draw2D, name: "draw2D");
				visualAABBanimID = s.SerializeObject<StringID>(visualAABBanimID, name: "visualAABBanimID");
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					animSet = s.SerializeObject<SubAnimSet_Template>(animSet, name: "animSet");
				}
				defaultAnimation = s.SerializeObject<StringID>(defaultAnimation, name: "defaultAnimation");
				subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				flip = s.Serialize<bool>(flip, name: "flip");
				backZOffset = s.Serialize<float>(backZOffset, name: "backZOffset");
				frontZOffset = s.Serialize<float>(frontZOffset, name: "frontZOffset");
				zOrderExtract = s.Serialize<float>(zOrderExtract, name: "zOrderExtract");
				zAmplify = s.Serialize<float>(zAmplify, name: "zAmplify");
				restoreStateAtCheckpoint = s.Serialize<bool>(restoreStateAtCheckpoint, name: "restoreStateAtCheckpoint");
				disableVisiblePrediction = s.Serialize<bool>(disableVisiblePrediction, name: "disableVisiblePrediction");
				notifyAnimUpdate = s.Serialize<bool>(notifyAnimUpdate, name: "notifyAnimUpdate");
				scale = s.SerializeObject<Vec2d>(scale, name: "scale");
				useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset");
				allowRenderInTexture = s.Serialize<bool>(allowRenderInTexture, name: "allowRenderInTexture");
				renderInTectureSizeX = s.Serialize<uint>(renderInTectureSizeX, name: "renderInTectureSizeX");
				renderInTectureSizeY = s.Serialize<uint>(renderInTectureSizeY, name: "renderInTectureSizeY");
				boneList = s.SerializeObject<CListO<BoneMapping>>(boneList, name: "boneList");
			} else {
				useBase = s.Serialize<bool>(useBase, name: "useBase");
				smoothAnim = s.Serialize<bool>(smoothAnim, name: "smoothAnim");
				blendAnimTrack = s.Serialize<bool>(blendAnimTrack, name: "blendAnimTrack");
				canonizeTransitions = s.Serialize<bool>(canonizeTransitions, name: "canonizeTransitions");
				defaultBlendFrames = s.Serialize<uint>(defaultBlendFrames, name: "defaultBlendFrames");
				draw2D = s.Serialize<uint>(draw2D, name: "draw2D");
				visualAABBanimID = s.SerializeObject<StringID>(visualAABBanimID, name: "visualAABBanimID");
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					animSet = s.SerializeObject<SubAnimSet_Template>(animSet, name: "animSet");
				}
				defaultAnimation = s.SerializeObject<StringID>(defaultAnimation, name: "defaultAnimation");
				subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
				defaultColor = s.SerializeObject<Color>(defaultColor, name: "defaultColor");
				flip = s.Serialize<bool>(flip, name: "flip");
				backZOffset = s.Serialize<float>(backZOffset, name: "backZOffset");
				frontZOffset = s.Serialize<float>(frontZOffset, name: "frontZOffset");
				zOrderExtract = s.Serialize<float>(zOrderExtract, name: "zOrderExtract");
				zAmplify = s.Serialize<float>(zAmplify, name: "zAmplify");
				restoreStateAtCheckpoint = s.Serialize<bool>(restoreStateAtCheckpoint, name: "restoreStateAtCheckpoint");
				disableVisiblePrediction = s.Serialize<bool>(disableVisiblePrediction, name: "disableVisiblePrediction");
				notifyAnimUpdate = s.Serialize<bool>(notifyAnimUpdate, name: "notifyAnimUpdate");
				scale = s.SerializeObject<Vec2d>(scale, name: "scale");
				useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset");
				allowRenderInTexture = s.Serialize<bool>(allowRenderInTexture, name: "allowRenderInTexture");
				renderInTectureSizeX = s.Serialize<uint>(renderInTectureSizeX, name: "renderInTectureSizeX");
				renderInTectureSizeY = s.Serialize<uint>(renderInTectureSizeY, name: "renderInTectureSizeY");
				boneList = s.SerializeObject<CListO<BoneMapping>>(boneList, name: "boneList");
			}
		}
		public override uint? ClassCRC => 0xA3557351;
	}
}

