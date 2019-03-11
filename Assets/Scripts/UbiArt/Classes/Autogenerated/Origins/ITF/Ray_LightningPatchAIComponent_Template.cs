using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_LightningPatchAIComponent_Template : CSerializable {
		[Serialize("maxLength"     )] public float maxLength;
		[Serialize("boneName"      )] public StringID boneName;
		[Serialize("effectboneName")] public StringID effectboneName;
		[Serialize("HeadPath"      )] public Path HeadPath;
		[Serialize("BodyPath"      )] public Path BodyPath;
		[Serialize("TailPath"      )] public Path TailPath;
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
		[Serialize("renderer"      )] public Placeholder renderer;
		[Serialize("playRate"      )] public float playRate;
		[Serialize("headZOffset"   )] public float headZOffset;
		[Serialize("tailZOffset"   )] public float tailZOffset;
		[Serialize("bodyZOffset"   )] public float bodyZOffset;
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
		}
		public override uint? ClassCRC => 0x120B97F1;
	}
}

