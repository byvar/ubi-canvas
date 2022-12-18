namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuDRCComponent_Template : CSerializable {
		public float costumeTransitionTime;
		public Placeholder messageInfos;
		public Placeholder unlockMessageButtons;
		public Path newContentPath;
		public StringID rumble_name;
		public float rumble_cycleDelay;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			costumeTransitionTime = s.Serialize<float>(costumeTransitionTime, name: "costumeTransitionTime");
			messageInfos = s.SerializeObject<Placeholder>(messageInfos, name: "messageInfos");
			unlockMessageButtons = s.SerializeObject<Placeholder>(unlockMessageButtons, name: "unlockMessageButtons");
			newContentPath = s.SerializeObject<Path>(newContentPath, name: "newContentPath");
			rumble_name = s.SerializeObject<StringID>(rumble_name, name: "rumble_name");
			rumble_cycleDelay = s.Serialize<float>(rumble_cycleDelay, name: "rumble_cycleDelay");
		}
		public override uint? ClassCRC => 0x7F8B4E1C;
	}
}

