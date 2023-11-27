namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIItemLeaderboardGraphNodeComponent : UIItemBasic {
		public uint highlightTextStyle;
		public Vec3d flagIconOffset;
		public Vec3d costumeIconOffset;
		public Vec2d costumeIconScale;
		public Vec3d rankIconOffset;
		public Vec3d checkIconOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			highlightTextStyle = s.Serialize<uint>(highlightTextStyle, name: "highlightTextStyle");
			flagIconOffset = s.SerializeObject<Vec3d>(flagIconOffset, name: "flagIconOffset");
			costumeIconOffset = s.SerializeObject<Vec3d>(costumeIconOffset, name: "costumeIconOffset");
			costumeIconScale = s.SerializeObject<Vec2d>(costumeIconScale, name: "costumeIconScale");
			rankIconOffset = s.SerializeObject<Vec3d>(rankIconOffset, name: "rankIconOffset");
			checkIconOffset = s.SerializeObject<Vec3d>(checkIconOffset, name: "checkIconOffset");
		}
		public override uint? ClassCRC => 0x5D7B614E;
	}
}

