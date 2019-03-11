using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeBlend_Template<AnimTreeResult> : BlendTreeNodeTemplate<AnimTreeResult> {
		[Serialize("leafs"            )] public CList<BlendTreeNodeTemplate<AnimTreeResult>> leafs;
		[Serialize("ignoreRuleChanges")] public bool ignoreRuleChanges;
		[Serialize("nodeName"         )] public StringID nodeName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(nodeName));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(leafs));
				}
				SerializeField(s, nameof(ignoreRuleChanges));
			} else {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(leafs));
				}
				SerializeField(s, nameof(ignoreRuleChanges));
			}
		}
		public override uint? ClassCRC => 0x422981DB;
	}
}

