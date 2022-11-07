namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class FlexMeshData : CSerializable {
		public Path texture;
		public GFXMaterialSerializable material;
		public StringID name;
		public Vec2d orientation;
		public float orientationInfluence;
		public bool allowStretch;
		public FlexMode mode;
		public float orientationLookAt;
		public float boneLookAt;
		public uint animStart;
		public uint animEnd;
		public float animUVFreq;
		public float scaleX;
		public float scaleY;
		public float flexDelay;
		public float flexTension;
		public BezierDivMode divMode;
		public float tessellationLength;
		public float alphaBegin;
		public float alphaEnd;
		public float zOffset;
		public bool rotate;
		public CListO<StringID> flexBonesList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				texture = s.SerializeObject<Path>(texture, name: "texture");
			}
			material = s.SerializeObject<GFXMaterialSerializable>(material, name: "material");
			name = s.SerializeObject<StringID>(name, name: "name");
			orientation = s.SerializeObject<Vec2d>(orientation, name: "orientation");
			orientationInfluence = s.Serialize<float>(orientationInfluence, name: "orientationInfluence");
			allowStretch = s.Serialize<bool>(allowStretch, name: "allowStretch");
			mode = s.Serialize<FlexMode>(mode, name: "mode");
			orientationLookAt = s.Serialize<float>(orientationLookAt, name: "orientationLookAt");
			boneLookAt = s.Serialize<float>(boneLookAt, name: "boneLookAt");
			animStart = s.Serialize<uint>(animStart, name: "animStart");
			animEnd = s.Serialize<uint>(animEnd, name: "animEnd");
			animUVFreq = s.Serialize<float>(animUVFreq, name: "animUVFreq");
			scaleX = s.Serialize<float>(scaleX, name: "scaleX");
			scaleY = s.Serialize<float>(scaleY, name: "scaleY");
			flexDelay = s.Serialize<float>(flexDelay, name: "flexDelay");
			flexTension = s.Serialize<float>(flexTension, name: "flexTension");
			divMode = s.Serialize<BezierDivMode>(divMode, name: "divMode");
			tessellationLength = s.Serialize<float>(tessellationLength, name: "tessellationLength");
			alphaBegin = s.Serialize<float>(alphaBegin, name: "alphaBegin");
			alphaEnd = s.Serialize<float>(alphaEnd, name: "alphaEnd");
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
			rotate = s.Serialize<bool>(rotate, name: "rotate");
			flexBonesList = s.SerializeObject<CListO<StringID>>(flexBonesList, name: "flexBonesList");
		}
		public enum FlexMode {
			[Serialize("FlexMode_Actor"     )] Actor = 0,
			[Serialize("FlexMode_Bone"      )] Bone = 1,
			[Serialize("FlexMode_Procedural")] Procedural = 2,
		}
		public enum BezierDivMode {
			[Serialize("BezierDivMode_Adaptive1")] Adaptive1 = 5,
			[Serialize("BezierDivMode_Adaptive2")] Adaptive2 = 6,
			[Serialize("BezierDivMode_Adaptive4")] Adaptive4 = 7,
			[Serialize("BezierDivMode_Fix82"    )] Fix82 = 1,
			[Serialize("BezierDivMode_Fix22"    )] Fix22 = 2,
			[Serialize("BezierDivMode_Fix44"    )] Fix44 = 4,
		}
	}
}

