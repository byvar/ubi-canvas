using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_182_sub_761540 : CSerializable {
		[Serialize("name"               )] public string name;
		[Serialize("mapPath"            )] public PathRef mapPath;
		[Serialize("hasOnlineContent"   )] public int hasOnlineContent;
		[Serialize("needFocusToActivate")] public int needFocusToActivate;
		[Serialize("highlightText"      )] public LocalisationId highlightText;
		[Serialize("highlightIcon"      )] public Path highlightIcon;
		[Serialize("highlightOffset"    )] public Vector3 highlightOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(mapPath));
				SerializeField(s, nameof(hasOnlineContent));
				SerializeField(s, nameof(needFocusToActivate));
				SerializeField(s, nameof(highlightText));
				SerializeField(s, nameof(highlightIcon));
				SerializeField(s, nameof(highlightOffset));
			}
		}
		public override uint? ClassCRC => 0x5732E6D6;
	}
}

