namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class AnimLightComponent : GraphicComponent {
		public float syncOffset;
		public float startOffset;
		public SubAnimSet subAnimInfo;
		public Path MatShader;
		public StringID subSkeleton;
		public StringID defaultAnim;
		public bool useZOffset = true;
		public bool EmitFluid;
		public bool BasicRender = true;
		public StringID lastAnim;
		public StringID playAnim;
		public uint playAnimFrames = 0xFFFFFFFF;
		public CListO<AnimLightFrameInfo> currentFrameSubAnims;
		public Path animInstance;
		public bool bool__5;
		public bool bool__6;
		public bool bool__7;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					animInstance = s.SerializeObject<Path>(animInstance, name: "animInstance");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					playAnim = s.SerializeObject<StringID>(playAnim, name: "playAnim");
					playAnimFrames = s.Serialize<uint>(playAnimFrames, name: "playAnimFrames");
					currentFrameSubAnims = s.SerializeObject<CListO<AnimLightFrameInfo>>(currentFrameSubAnims, name: "currentFrameSubAnims");
				}
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					startOffset = s.Serialize<float>(startOffset, name: "startOffset");
					subAnimInfo = s.SerializeObject<SubAnimSet>(subAnimInfo, name: "subAnimInfo");
					MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
					defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
					useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					playAnim = s.SerializeObject<StringID>(playAnim, name: "playAnim");
					playAnimFrames = s.Serialize<uint>(playAnimFrames, name: "playAnimFrames");
					currentFrameSubAnims = s.SerializeObject<CListO<AnimLightFrameInfo>>(currentFrameSubAnims, name: "currentFrameSubAnims");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					startOffset = s.Serialize<float>(startOffset, name: "startOffset");
					MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
					defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
					useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					playAnim = s.SerializeObject<StringID>(playAnim, name: "playAnim");
					playAnimFrames = s.Serialize<uint>(playAnimFrames, name: "playAnimFrames");
					currentFrameSubAnims = s.SerializeObject<CListO<AnimLightFrameInfo>>(currentFrameSubAnims, name: "currentFrameSubAnims");
				}
			} else if (s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					startOffset = s.Serialize<float>(startOffset, name: "startOffset");
					subAnimInfo = s.SerializeObject<SubAnimSet>(subAnimInfo, name: "subAnimInfo");
					MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
					bool__5 = s.Serialize<bool>(bool__5, name: "bool__5");
					bool__6 = s.Serialize<bool>(bool__6, name: "bool__6");
					bool__7 = s.Serialize<bool>(bool__7, name: "bool__7");
					defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
					useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					lastAnim = s.SerializeObject<StringID>(lastAnim, name: "lastAnim");
					playAnim = s.SerializeObject<StringID>(playAnim, name: "playAnim");
					playAnimFrames = s.Serialize<uint>(playAnimFrames, name: "playAnimFrames");
					currentFrameSubAnims = s.SerializeObject<CListO<AnimLightFrameInfo>>(currentFrameSubAnims, name: "currentFrameSubAnims");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
					startOffset = s.Serialize<float>(startOffset, name: "startOffset");
					subAnimInfo = s.SerializeObject<SubAnimSet>(subAnimInfo, name: "subAnimInfo");
					MatShader = s.SerializeObject<Path>(MatShader, name: "MatShader");
					subSkeleton = s.SerializeObject<StringID>(subSkeleton, name: "subSkeleton");
					defaultAnim = s.SerializeObject<StringID>(defaultAnim, name: "defaultAnim");
					useZOffset = s.Serialize<bool>(useZOffset, name: "useZOffset");
				}
				if (s.HasFlags(SerializeFlags.Flags8)) {
					EmitFluid = s.Serialize<bool>(EmitFluid, name: "EmitFluid");
					BasicRender = s.Serialize<bool>(BasicRender, name: "BasicRender");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					lastAnim = s.SerializeObject<StringID>(lastAnim, name: "lastAnim");
					playAnim = s.SerializeObject<StringID>(playAnim, name: "playAnim");
					playAnimFrames = s.Serialize<uint>(playAnimFrames, name: "playAnimFrames");
					currentFrameSubAnims = s.SerializeObject<CListO<AnimLightFrameInfo>>(currentFrameSubAnims, name: "currentFrameSubAnims");
				}
			}
		}
		public override uint? ClassCRC => 0xA6E4EFBA;
	}
}

