using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_376_sub_B04180 : CSerializable {
		[Serialize("smartLocID"        )] public Placeholder smartLocID;
		[Serialize("displayDuration"   )] public float displayDuration;
		[Serialize("transitionDuration")] public float transitionDuration;
		[Serialize("nbRebound"         )] public uint nbRebound;
		[Serialize("startOffset"       )] public Vector2 startOffset;
		[Serialize("fastIncreaseTime"  )] public float fastIncreaseTime;
		[Serialize("maxIncreaseTime"   )] public float maxIncreaseTime;
		[Serialize("maxValueRef"       )] public float maxValueRef;
		[Serialize("minIncreaseTime"   )] public float minIncreaseTime;
		[Serialize("minValueRef"       )] public float minValueRef;
		[Serialize("loopingSound"      )] public StringID loopingSound;
		[Serialize("endSound"          )] public StringID endSound;
		[Serialize("tagColorSettings"  )] public Placeholder tagColorSettings;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(smartLocID));
			SerializeField(s, nameof(displayDuration));
			SerializeField(s, nameof(transitionDuration));
			SerializeField(s, nameof(nbRebound));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(fastIncreaseTime));
			SerializeField(s, nameof(maxIncreaseTime));
			SerializeField(s, nameof(maxValueRef));
			SerializeField(s, nameof(minIncreaseTime));
			SerializeField(s, nameof(minValueRef));
			SerializeField(s, nameof(loopingSound));
			SerializeField(s, nameof(endSound));
			SerializeField(s, nameof(tagColorSettings));
		}
		public override uint? ClassCRC => 0x4FDE15AC;
	}
}

