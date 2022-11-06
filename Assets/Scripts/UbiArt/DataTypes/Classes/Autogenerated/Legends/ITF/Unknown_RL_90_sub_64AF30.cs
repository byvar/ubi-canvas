using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_90_sub_64AF30 : CSerializable {
		public uint numPlayerPerPage;
		public float pageHeight;
		public Path playerActorPath;
		public Path flagIconPath;
		public Path costumeIconPath;
		public uint playerActorPoolSize;
		public Vec2d playerActorOffset;
		public Placeholder friendText;
		public Placeholder friendsText;
		public Placeholder friends0Text;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numPlayerPerPage = s.Serialize<uint>(numPlayerPerPage, name: "numPlayerPerPage");
			pageHeight = s.Serialize<float>(pageHeight, name: "pageHeight");
			playerActorPath = s.SerializeObject<Path>(playerActorPath, name: "playerActorPath");
			flagIconPath = s.SerializeObject<Path>(flagIconPath, name: "flagIconPath");
			costumeIconPath = s.SerializeObject<Path>(costumeIconPath, name: "costumeIconPath");
			playerActorPoolSize = s.Serialize<uint>(playerActorPoolSize, name: "playerActorPoolSize");
			playerActorOffset = s.SerializeObject<Vec2d>(playerActorOffset, name: "playerActorOffset");
			friendText = s.SerializeObject<Placeholder>(friendText, name: "friendText");
			friendsText = s.SerializeObject<Placeholder>(friendsText, name: "friendsText");
			friends0Text = s.SerializeObject<Placeholder>(friends0Text, name: "friends0Text");
		}
		public override uint? ClassCRC => 0xFC6594C4;
	}
}

