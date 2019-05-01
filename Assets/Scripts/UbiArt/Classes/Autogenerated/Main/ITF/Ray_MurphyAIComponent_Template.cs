using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MurphyAIComponent_Template : ActorComponent_Template {
		[Serialize("playerDetectRadiusAppear"   )] public float playerDetectRadiusAppear;
		[Serialize("playerDetectRadiusDisappear")] public float playerDetectRadiusDisappear;
		[Serialize("bubbleBone"                 )] public StringID bubbleBone;
		[Serialize("bubblePath"                 )] public Path bubblePath;
		[Serialize("bubbleZOffset"              )] public float bubbleZOffset;
		[Serialize("appearAnim"                 )] public StringID appearAnim;
		[Serialize("talkAnim"                   )] public StringID talkAnim;
		[Serialize("disappearAnim"              )] public StringID disappearAnim;
		[Serialize("idleAnim"                   )] public StringID idleAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerDetectRadiusAppear));
			SerializeField(s, nameof(playerDetectRadiusDisappear));
			SerializeField(s, nameof(bubbleBone));
			SerializeField(s, nameof(bubblePath));
			SerializeField(s, nameof(bubbleZOffset));
			SerializeField(s, nameof(appearAnim));
			SerializeField(s, nameof(talkAnim));
			SerializeField(s, nameof(disappearAnim));
			SerializeField(s, nameof(idleAnim));
		}
		public override uint? ClassCRC => 0x2700A571;
	}
}

