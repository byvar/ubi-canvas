namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PaintSnakeComponent_Template : ActorComponent_Template {
		public StringID BubonBoneL;
		public StringID BubonBoneR;
		public float RadiusTouchScreen;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BubonBoneL = s.SerializeObject<StringID>(BubonBoneL, name: "BubonBoneL");
			BubonBoneR = s.SerializeObject<StringID>(BubonBoneR, name: "BubonBoneR");
			RadiusTouchScreen = s.Serialize<float>(RadiusTouchScreen, name: "RadiusTouchScreen");
		}
		public override uint? ClassCRC => 0xC89B8AA0;
	}
}

