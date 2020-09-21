using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PackageDescriptor_Template : PackageDescriptor_Template {
		public Path decorationBrickPath;
		public bool hideDecoration;
		public int priority;
		public int alternatePriority;
		public string mapName;
		public CArrayP<string> subHubPaths;
		public PathRef mapPath;
		public Path hubPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				decorationBrickPath = s.SerializeObject<Path>(decorationBrickPath, name: "decorationBrickPath");
				hideDecoration = s.Serialize<bool>(hideDecoration, name: "hideDecoration");
				priority = s.Serialize<int>(priority, name: "priority");
				alternatePriority = s.Serialize<int>(alternatePriority, name: "alternatePriority");
				mapName = s.Serialize<string>(mapName, name: "mapName");
				subHubPaths = s.SerializeObject<CArrayP<string>>(subHubPaths, name: "subHubPaths");
				mapPath = s.SerializeObject<PathRef>(mapPath, name: "mapPath");
				hubPath = s.SerializeObject<Path>(hubPath, name: "hubPath");
			} else {
				decorationBrickPath = s.SerializeObject<Path>(decorationBrickPath, name: "decorationBrickPath");
				hideDecoration = s.Serialize<bool>(hideDecoration, name: "hideDecoration");
				priority = s.Serialize<int>(priority, name: "priority");
				alternatePriority = s.Serialize<int>(alternatePriority, name: "alternatePriority");
				mapName = s.Serialize<string>(mapName, name: "mapName");
				subHubPaths = s.SerializeObject<CArrayP<string>>(subHubPaths, name: "subHubPaths");
				subHubPaths = s.SerializeObject<CArrayP<string>>(subHubPaths, name: "subHubPaths");
				mapPath = s.SerializeObject<PathRef>(mapPath, name: "mapPath");
				hubPath = s.SerializeObject<Path>(hubPath, name: "hubPath");
			}
		}
		public override uint? ClassCRC => 0xCCE5AFFD;
	}
}

