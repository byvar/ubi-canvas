using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_TalkingHatAIComponent_Template : CSerializable {
		[Serialize("playerDetectRadiusAppear"   )] public float playerDetectRadiusAppear;
		[Serialize("playerDetectRadiusDisappear")] public float playerDetectRadiusDisappear;
		[Serialize("bubbleBone"                 )] public StringID bubbleBone;
		[Serialize("bubblePath"                 )] public Path bubblePath;
		[Serialize("bubbleZOffset"              )] public float bubbleZOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerDetectRadiusAppear));
			SerializeField(s, nameof(playerDetectRadiusDisappear));
			SerializeField(s, nameof(bubbleBone));
			SerializeField(s, nameof(bubblePath));
			SerializeField(s, nameof(bubbleZOffset));
		}
		public override uint? ClassCRC => 0xF7FD6EA9;
	}
}

