using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeBranchTransition_Template<AnimTreeResult> : BlendTreeNodeBlend_Template<AnimTreeResult> {
		[Serialize("blendTime"        )] public float blendTime;
		[Serialize("nodeName"         )] public StringID nodeName;
		[Serialize("leafs"            )] public Placeholder leafs;
		[Serialize("ignoreRuleChanges")] public bool ignoreRuleChanges;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(nodeName));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(leafs));
				}
				SerializeField(s, nameof(ignoreRuleChanges));
				SerializeField(s, nameof(blendTime));
			} else {
				SerializeField(s, nameof(blendTime));
			}
		}
		public override uint? ClassCRC => 0xB8CF072C;
	}
}

