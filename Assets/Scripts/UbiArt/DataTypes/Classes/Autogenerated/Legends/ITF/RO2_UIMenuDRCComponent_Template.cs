namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuDRCComponent_Template : UIMenuScroll_Template {
		public float costumeTransitionTime;
		public CListO<MessageInfo> messageInfos;
		public CListO<UnlockMessageButton> unlockMessageButtons;
		public Path newContentPath;
		public StringID rumble_name;
		public float rumble_cycleDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumeTransitionTime = s.Serialize<float>(costumeTransitionTime, name: "costumeTransitionTime");
			messageInfos = s.SerializeObject<CListO<MessageInfo>>(messageInfos, name: "messageInfos");
			unlockMessageButtons = s.SerializeObject<CListO<UnlockMessageButton>>(unlockMessageButtons, name: "unlockMessageButtons");
			newContentPath = s.SerializeObject<Path>(newContentPath, name: "newContentPath");
			rumble_name = s.SerializeObject<StringID>(rumble_name, name: "rumble_name");
			rumble_cycleDelay = s.Serialize<float>(rumble_cycleDelay, name: "rumble_cycleDelay");
		}
		public override uint? ClassCRC => 0x7F8B4E1C;

		public partial class MessageInfo : CSerializable {
			public uint messageType;
			public Path messageIconPath;
			public int messageItemModel;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				messageType = s.Serialize<uint>(messageType, name: "messageType");
				messageIconPath = s.SerializeObject<Path>(messageIconPath, name: "messageIconPath");
				messageItemModel = s.Serialize<int>(messageItemModel, name: "messageItemModel");
			}
		}
		public partial class UnlockMessageButton : CSerializable {
			public StringID world;
			public Path button;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				world = s.SerializeObject<StringID>(world, name: "world");
				button = s.SerializeObject<Path>(button, name: "button");
			}
		}
	}
}

