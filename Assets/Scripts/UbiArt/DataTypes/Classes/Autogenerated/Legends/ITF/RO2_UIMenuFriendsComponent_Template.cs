namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuFriendsComponent_Template : UIMenuScroll_Template {
		public uint numPlayerPerPage;
		public float pageHeight;
		public Path playerActorPath;
		public Path flagIconPath;
		public Path costumeIconPath;
		public uint playerActorPoolSize;
		public Vec2d playerActorOffset;
		public SmartLocId friendText;
		public SmartLocId friendsText;
		public SmartLocId friends0Text;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numPlayerPerPage = s.Serialize<uint>(numPlayerPerPage, name: "numPlayerPerPage");
			pageHeight = s.Serialize<float>(pageHeight, name: "pageHeight");
			playerActorPath = s.SerializeObject<Path>(playerActorPath, name: "playerActorPath");
			flagIconPath = s.SerializeObject<Path>(flagIconPath, name: "flagIconPath");
			costumeIconPath = s.SerializeObject<Path>(costumeIconPath, name: "costumeIconPath");
			playerActorPoolSize = s.Serialize<uint>(playerActorPoolSize, name: "playerActorPoolSize");
			playerActorOffset = s.SerializeObject<Vec2d>(playerActorOffset, name: "playerActorOffset");
			friendText = s.SerializeObject<SmartLocId>(friendText, name: "friendText");
			friendsText = s.SerializeObject<SmartLocId>(friendsText, name: "friendsText");
			friends0Text = s.SerializeObject<SmartLocId>(friends0Text, name: "friends0Text");
		}
		public override uint? ClassCRC => 0xFC6594C4;
	}
}

