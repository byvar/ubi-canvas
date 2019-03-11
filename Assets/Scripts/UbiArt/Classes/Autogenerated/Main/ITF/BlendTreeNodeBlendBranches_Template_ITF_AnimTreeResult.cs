using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeBlendBranches_Template<AnimTreeResult> : BlendTreeNodeBlend_Template<AnimTreeResult> {
		[Serialize("blendInput"       )] public StringID blendInput;
		[Serialize("nodeName"         )] public StringID nodeName;
		[Serialize("leafs"            )] public Placeholder leafs;
		[Serialize("ignoreRuleChanges")] public bool ignoreRuleChanges;
		[Serialize("blendParams"      )] public Placeholder blendParams;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(nodeName));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(leafs));
				}
				SerializeField(s, nameof(ignoreRuleChanges));
				SerializeField(s, nameof(blendParams));
				SerializeField(s, nameof(blendInput));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(blendParams));
				SerializeField(s, nameof(blendInput));
			} else {
				SerializeField(s, nameof(blendInput));
			}
		}
		public override uint? ClassCRC => 0xC1143887;
	}
}

