using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class FlexMeshData : CSerializable {
		[Serialize("texture"             )] public Path texture;
		[Serialize("material"            )] public GFXMaterialSerializable material;
		[Serialize("name"                )] public StringID name;
		[Serialize("orientation"         )] public Vec2d orientation;
		[Serialize("orientationInfluence")] public float orientationInfluence;
		[Serialize("allowStretch"        )] public bool allowStretch;
		[Serialize("mode"                )] public FlexMode mode;
		[Serialize("orientationLookAt"   )] public float orientationLookAt;
		[Serialize("boneLookAt"          )] public float boneLookAt;
		[Serialize("animStart"           )] public uint animStart;
		[Serialize("animEnd"             )] public uint animEnd;
		[Serialize("animUVFreq"          )] public float animUVFreq;
		[Serialize("scaleX"              )] public float scaleX;
		[Serialize("scaleY"              )] public float scaleY;
		[Serialize("flexDelay"           )] public float flexDelay;
		[Serialize("flexTension"         )] public float flexTension;
		[Serialize("divMode"             )] public BezierDivMode divMode;
		[Serialize("tessellationLength"  )] public float tessellationLength;
		[Serialize("alphaBegin"          )] public float alphaBegin;
		[Serialize("alphaEnd"            )] public float alphaEnd;
		[Serialize("zOffset"             )] public float zOffset;
		[Serialize("rotate"              )] public bool rotate;
		[Serialize("flexBonesList"       )] public CList<StringID> flexBonesList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(texture));
			}
			SerializeField(s, nameof(material));
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(orientation));
			SerializeField(s, nameof(orientationInfluence));
			SerializeField(s, nameof(allowStretch));
			SerializeField(s, nameof(mode));
			SerializeField(s, nameof(orientationLookAt));
			SerializeField(s, nameof(boneLookAt));
			SerializeField(s, nameof(animStart));
			SerializeField(s, nameof(animEnd));
			SerializeField(s, nameof(animUVFreq));
			SerializeField(s, nameof(scaleX));
			SerializeField(s, nameof(scaleY));
			SerializeField(s, nameof(flexDelay));
			SerializeField(s, nameof(flexTension));
			SerializeField(s, nameof(divMode));
			SerializeField(s, nameof(tessellationLength));
			SerializeField(s, nameof(alphaBegin));
			SerializeField(s, nameof(alphaEnd));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(rotate));
			SerializeField(s, nameof(flexBonesList));
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

