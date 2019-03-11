using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierBranchRendererSegment_Template : CSerializable {
		[Serialize("name"                         )] public StringID name;
		[Serialize("startRatio"                   )] public float startRatio;
		[Serialize("startOffset"                  )] public float startOffset;
		[Serialize("endRatio"                     )] public float endRatio;
		[Serialize("endOffset"                    )] public float endOffset;
		[Serialize("spriteMinIndex"               )] public uint spriteMinIndex;
		[Serialize("spriteMaxIndex"               )] public uint spriteMaxIndex;
		[Serialize("spritePlayRate"               )] public float spritePlayRate;
		[Serialize("spritePlayRateSpeedMultiplier")] public float spritePlayRateSpeedMultiplier;
		[Serialize("tileLength"                   )] public float tileLength;
		[Serialize("uvAttachToEnd"                )] public bool uvAttachToEnd;
		[Serialize("uvScrollSpeed"                )] public float uvScrollSpeed;
		[Serialize("beginLength"                  )] public float beginLength;
		[Serialize("endLength"                    )] public float endLength;
		[Serialize("beginWidth"                   )] public float beginWidth;
		[Serialize("beginAlpha"                   )] public float beginAlpha;
		[Serialize("startLengthRatio"             )] public float startLengthRatio;
		[Serialize("startLengthOffset"            )] public float startLengthOffset;
		[Serialize("endLengthRatio"               )] public float endLengthRatio;
		[Serialize("endLengthOffset"              )] public float endLengthOffset;
		[Serialize("startWidth"                   )] public float startWidth;
		[Serialize("midWidth"                     )] public float midWidth;
		[Serialize("endWidth"                     )] public float endWidth;
		[Serialize("startAlpha"                   )] public float startAlpha;
		[Serialize("midAlpha"                     )] public float midAlpha;
		[Serialize("endAlpha"                     )] public float endAlpha;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(startRatio));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(endRatio));
			SerializeField(s, nameof(endOffset));
			SerializeField(s, nameof(spriteMinIndex));
			SerializeField(s, nameof(spriteMaxIndex));
			SerializeField(s, nameof(spritePlayRate));
			SerializeField(s, nameof(spritePlayRateSpeedMultiplier));
			SerializeField(s, nameof(tileLength));
			SerializeField(s, nameof(uvAttachToEnd));
			SerializeField(s, nameof(uvScrollSpeed));
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(beginLength));
				SerializeField(s, nameof(endLength));
				SerializeField(s, nameof(beginWidth));
				SerializeField(s, nameof(beginAlpha));
			}
			SerializeField(s, nameof(startLengthRatio));
			SerializeField(s, nameof(startLengthOffset));
			SerializeField(s, nameof(endLengthRatio));
			SerializeField(s, nameof(endLengthOffset));
			SerializeField(s, nameof(startWidth));
			SerializeField(s, nameof(midWidth));
			SerializeField(s, nameof(endWidth));
			SerializeField(s, nameof(startAlpha));
			SerializeField(s, nameof(midAlpha));
			SerializeField(s, nameof(endAlpha));
		}
	}
}

