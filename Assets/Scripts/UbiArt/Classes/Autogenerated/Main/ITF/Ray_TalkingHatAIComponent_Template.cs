using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TalkingHatAIComponent_Template : CSerializable {
		public float playerDetectRadiusAppear;
		public float playerDetectRadiusDisappear;
		public StringID bubbleBone;
		public Path bubblePath;
		public float bubbleZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerDetectRadiusAppear = s.Serialize<float>(playerDetectRadiusAppear, name: "playerDetectRadiusAppear");
			playerDetectRadiusDisappear = s.Serialize<float>(playerDetectRadiusDisappear, name: "playerDetectRadiusDisappear");
			bubbleBone = s.SerializeObject<StringID>(bubbleBone, name: "bubbleBone");
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			bubbleZOffset = s.Serialize<float>(bubbleZOffset, name: "bubbleZOffset");
		}
		public override uint? ClassCRC => 0xF7FD6EA9;
	}
}

