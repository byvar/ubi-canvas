using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_LumsCounterComponent_Template : ActorComponent_Template {
		[Serialize("smartLocID"        )] public SmartLocId smartLocID;
		[Serialize("displayDuration"   )] public float displayDuration;
		[Serialize("transitionDuration")] public float transitionDuration;
		[Serialize("nbRebound"         )] public uint nbRebound;
		[Serialize("startOffset"       )] public Vec2d startOffset;
		[Serialize("maxIncreaseTime"   )] public float maxIncreaseTime;
		[Serialize("maxValueRef"       )] public float maxValueRef;
		[Serialize("minIncreaseTime"   )] public float minIncreaseTime;
		[Serialize("minValueRef"       )] public float minValueRef;
		[Serialize("loopingSound"      )] public StringID loopingSound;
		[Serialize("endSound"          )] public StringID endSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(smartLocID));
			SerializeField(s, nameof(displayDuration));
			SerializeField(s, nameof(transitionDuration));
			SerializeField(s, nameof(nbRebound));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(maxIncreaseTime));
			SerializeField(s, nameof(maxValueRef));
			SerializeField(s, nameof(minIncreaseTime));
			SerializeField(s, nameof(minValueRef));
			SerializeField(s, nameof(loopingSound));
			SerializeField(s, nameof(endSound));
		}
		public override uint? ClassCRC => 0x73483516;
	}
}

