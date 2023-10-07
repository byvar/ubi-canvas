namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_PackageDescriptor_Template : PackageDescriptor_Template {
		public Path decorationBrickPath;
		public bool hideDecoration;
		public int priority = 1;
		public int alternatePriority = 1;
		public string mapName;
		public CArrayP<string> subHubPaths;
		public PathRef mapPath;
		public Path hubPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			decorationBrickPath = s.SerializeObject<Path>(decorationBrickPath, name: "decorationBrickPath");
			hideDecoration = s.Serialize<bool>(hideDecoration, name: "hideDecoration");
			priority = s.Serialize<int>(priority, name: "priority");
			if (s.Settings.Platform == GamePlatform.Vita) {
				alternatePriority = priority;
			} else {
				alternatePriority = s.Serialize<int>(alternatePriority, name: "alternatePriority");
			}
			mapName = s.Serialize<string>(mapName, name: "mapName");
			subHubPaths = s.SerializeObject<CArrayP<string>>(subHubPaths, name: "subHubPaths");
			mapPath = s.SerializeObject<PathRef>(mapPath, name: "mapPath");
			hubPath = s.SerializeObject<Path>(hubPath, name: "hubPath");
		}
		public override uint? ClassCRC => 0xCCE5AFFD;
	}
}

