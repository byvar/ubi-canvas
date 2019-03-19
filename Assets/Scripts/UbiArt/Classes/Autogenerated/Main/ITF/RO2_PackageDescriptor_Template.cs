using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PackageDescriptor_Template : PackageDescriptor_Template {
		[Serialize("decorationBrickPath")] public Path decorationBrickPath;
		[Serialize("hideDecoration"     )] public bool hideDecoration;
		[Serialize("priority"           )] public int priority;
		[Serialize("alternatePriority"  )] public int alternatePriority;
		[Serialize("mapName"            )] public string mapName;
		[Serialize("subHubPaths"        )] public CArray<string> subHubPaths;
		[Serialize("mapPath"            )] public PathRef mapPath;
		[Serialize("hubPath"            )] public Path hubPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(decorationBrickPath));
				SerializeField(s, nameof(hideDecoration));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(alternatePriority));
				SerializeField(s, nameof(mapName));
				SerializeField(s, nameof(subHubPaths));
				SerializeField(s, nameof(mapPath));
				SerializeField(s, nameof(hubPath));
			} else {
				SerializeField(s, nameof(decorationBrickPath));
				SerializeField(s, nameof(hideDecoration));
				SerializeField(s, nameof(priority));
				SerializeField(s, nameof(alternatePriority));
				SerializeField(s, nameof(mapName));
				SerializeField(s, nameof(subHubPaths));
				SerializeField(s, nameof(subHubPaths));
				SerializeField(s, nameof(mapPath));
				SerializeField(s, nameof(hubPath));
			}
		}
		public override uint? ClassCRC => 0xCCE5AFFD;
	}
}

