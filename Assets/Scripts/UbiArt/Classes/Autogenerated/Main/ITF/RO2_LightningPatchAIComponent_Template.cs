using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LightningPatchAIComponent_Template : ActorComponent_Template {
		[Serialize("maxLength"     )] public float maxLength;
		[Serialize("boneName"      )] public StringID boneName;
		[Serialize("effectboneName")] public StringID effectboneName;
		[Serialize("HeadPath"      )] public GFXMaterialSerializable HeadPath;
		[Serialize("BodyPath"      )] public GFXMaterialSerializable BodyPath;
		[Serialize("TailPath"      )] public GFXMaterialSerializable TailPath;
		[Serialize("headMaxIndices")] public uint headMaxIndices;
		[Serialize("tailMaxIndices")] public uint tailMaxIndices;
		[Serialize("bodyMaxIndices")] public uint bodyMaxIndices;
		[Serialize("headLoopStart" )] public uint headLoopStart;
		[Serialize("headLoopStop"  )] public uint headLoopStop;
		[Serialize("tailLoopStart" )] public uint tailLoopStart;
		[Serialize("tailLoopStop"  )] public uint tailLoopStop;
		[Serialize("bodyLoopStart" )] public uint bodyLoopStart;
		[Serialize("bodyLoopStop"  )] public uint bodyLoopStop;
		[Serialize("headSize"      )] public Vector2 headSize;
		[Serialize("tailSize"      )] public Vector2 tailSize;
		[Serialize("speed"         )] public float speed;
		[Serialize("headCenter"    )] public Vector2 headCenter;
		[Serialize("tailCenter"    )] public Vector2 tailCenter;
		[Serialize("renderer"      )] public BezierCurveRenderer_Template renderer;
		[Serialize("playRate"      )] public float playRate;
		[Serialize("headZOffset"   )] public float headZOffset;
		[Serialize("tailZOffset"   )] public float tailZOffset;
		[Serialize("bodyZOffset"   )] public float bodyZOffset;
		[Serialize("ChargeFx"      )] public StringID ChargeFx;
		[Serialize("LoopFx"        )] public StringID LoopFx;
		[Serialize("EndFx"         )] public StringID EndFx;
		[Serialize("stimWidth"     )] public float stimWidth;
		[Serialize("useAnimInfo"   )] public bool useAnimInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxLength));
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(effectboneName));
			SerializeField(s, nameof(HeadPath));
			SerializeField(s, nameof(BodyPath));
			SerializeField(s, nameof(TailPath));
			SerializeField(s, nameof(headMaxIndices));
			SerializeField(s, nameof(tailMaxIndices));
			SerializeField(s, nameof(bodyMaxIndices));
			SerializeField(s, nameof(headLoopStart));
			SerializeField(s, nameof(headLoopStop));
			SerializeField(s, nameof(tailLoopStart));
			SerializeField(s, nameof(tailLoopStop));
			SerializeField(s, nameof(bodyLoopStart));
			SerializeField(s, nameof(bodyLoopStop));
			SerializeField(s, nameof(headSize));
			SerializeField(s, nameof(tailSize));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(headCenter));
			SerializeField(s, nameof(tailCenter));
			SerializeField(s, nameof(renderer));
			SerializeField(s, nameof(playRate));
			SerializeField(s, nameof(headZOffset));
			SerializeField(s, nameof(tailZOffset));
			SerializeField(s, nameof(bodyZOffset));
			SerializeField(s, nameof(ChargeFx));
			SerializeField(s, nameof(LoopFx));
			SerializeField(s, nameof(EndFx));
			SerializeField(s, nameof(stimWidth));
			SerializeField(s, nameof(useAnimInfo));
		}
		public override uint? ClassCRC => 0xAF5BE86E;
	}
}

