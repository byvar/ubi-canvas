using UnityEngine;

namespace UbiArt.ITF {
	public partial class BlendTreeNodeChooseBranch_Template<AnimTreeResult> : BlendTreeNodeBlend_Template<AnimTreeResult> {
		[Serialize("blendTime"        )] public float blendTime;
		[Serialize("startingLeaf"     )] public uint startingLeaf;
		[Serialize("noUpdateInactive" )] public bool noUpdateInactive;
		[Serialize("nodeName"         )] public StringID nodeName;
		[Serialize("leafs"            )] public Placeholder leafs;
		[Serialize("ignoreRuleChanges")] public bool ignoreRuleChanges;
		[Serialize("leafsCriterias"   )] public Placeholder leafsCriterias;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(nodeName));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(leafs));
				}
				SerializeField(s, nameof(ignoreRuleChanges));
				SerializeField(s, nameof(blendTime));
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(leafsCriterias));
				SerializeField(s, nameof(noUpdateInactive));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(blendTime));
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(leafsCriterias));
				SerializeField(s, nameof(noUpdateInactive));
			} else {
				SerializeField(s, nameof(blendTime));
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(noUpdateInactive));
			}
		}
		public override uint? ClassCRC => 0x9627D8B1;
	}
}

