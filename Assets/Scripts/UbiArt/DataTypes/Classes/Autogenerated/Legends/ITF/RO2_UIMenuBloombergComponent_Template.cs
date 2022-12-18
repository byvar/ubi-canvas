namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuBloombergComponent_Template : CSerializable {
		public uint cycleDisplayCountByMessage;
		public float cycleDelay;
		public Path itemPath;
		public uint itemPoolSize;
		public float itemSpace;
		public float itemSpeed;
		public Placeholder iconeReferences;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cycleDisplayCountByMessage = s.Serialize<uint>(cycleDisplayCountByMessage, name: "cycleDisplayCountByMessage");
			cycleDelay = s.Serialize<float>(cycleDelay, name: "cycleDelay");
			itemPath = s.SerializeObject<Path>(itemPath, name: "itemPath");
			itemPoolSize = s.Serialize<uint>(itemPoolSize, name: "itemPoolSize");
			itemSpace = s.Serialize<float>(itemSpace, name: "itemSpace");
			itemSpeed = s.Serialize<float>(itemSpeed, name: "itemSpeed");
			iconeReferences = s.SerializeObject<Placeholder>(iconeReferences, name: "iconeReferences");
		}
		public override uint? ClassCRC => 0x28166084;
	}
}

