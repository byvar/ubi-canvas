namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_MurphyAIComponent_Template : ActorComponent_Template {
		public float playerDetectRadiusAppear;
		public float playerDetectRadiusDisappear;
		public StringID bubbleBone;
		public Path bubblePath;
		public float bubbleZOffset;
		public StringID appearAnim;
		public StringID talkAnim;
		public StringID disappearAnim;
		public StringID idleAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			playerDetectRadiusAppear = s.Serialize<float>(playerDetectRadiusAppear, name: "playerDetectRadiusAppear");
			playerDetectRadiusDisappear = s.Serialize<float>(playerDetectRadiusDisappear, name: "playerDetectRadiusDisappear");
			bubbleBone = s.SerializeObject<StringID>(bubbleBone, name: "bubbleBone");
			bubblePath = s.SerializeObject<Path>(bubblePath, name: "bubblePath");
			bubbleZOffset = s.Serialize<float>(bubbleZOffset, name: "bubbleZOffset");
			appearAnim = s.SerializeObject<StringID>(appearAnim, name: "appearAnim");
			talkAnim = s.SerializeObject<StringID>(talkAnim, name: "talkAnim");
			disappearAnim = s.SerializeObject<StringID>(disappearAnim, name: "disappearAnim");
			idleAnim = s.SerializeObject<StringID>(idleAnim, name: "idleAnim");
		}
		public override uint? ClassCRC => 0x2700A571;
	}
}

