using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_LumsCounterComponent_Template : ActorComponent_Template {
		public SmartLocId smartLocID;
		public float displayDuration;
		public float transitionDuration;
		public uint nbRebound;
		public Vec2d startOffset;
		public float maxIncreaseTime;
		public float maxValueRef;
		public float minIncreaseTime;
		public float minValueRef;
		public StringID loopingSound;
		public StringID endSound;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			smartLocID = s.SerializeObject<SmartLocId>(smartLocID, name: "smartLocID");
			displayDuration = s.Serialize<float>(displayDuration, name: "displayDuration");
			transitionDuration = s.Serialize<float>(transitionDuration, name: "transitionDuration");
			nbRebound = s.Serialize<uint>(nbRebound, name: "nbRebound");
			startOffset = s.SerializeObject<Vec2d>(startOffset, name: "startOffset");
			maxIncreaseTime = s.Serialize<float>(maxIncreaseTime, name: "maxIncreaseTime");
			maxValueRef = s.Serialize<float>(maxValueRef, name: "maxValueRef");
			minIncreaseTime = s.Serialize<float>(minIncreaseTime, name: "minIncreaseTime");
			minValueRef = s.Serialize<float>(minValueRef, name: "minValueRef");
			loopingSound = s.SerializeObject<StringID>(loopingSound, name: "loopingSound");
			endSound = s.SerializeObject<StringID>(endSound, name: "endSound");
		}
		public override uint? ClassCRC => 0x73483516;
	}
}

