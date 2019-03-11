using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicTreeNodeSequence_Template : BlendTreeNodeBlend_Template<Q23ITF15MusicTreeResult> {
		[Serialize("nodeName"             )] public StringID nodeName;
		[Serialize("leafs"                )] public Placeholder leafs;
		[Serialize("ignoreRuleChanges"    )] public bool ignoreRuleChanges;
		[Serialize("startingLeaf"         )] public uint startingLeaf;
		[Serialize("looping"              )] public bool looping;
		[Serialize("useIntro"             )] public bool useIntro;
		[Serialize("pauseInsensitiveFlags")] public uint pauseInsensitiveFlags;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(useIntro));
				SerializeField(s, nameof(pauseInsensitiveFlags));
			} else {
				SerializeField(s, nameof(nodeName));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(leafs));
				}
				SerializeField(s, nameof(ignoreRuleChanges));
				SerializeField(s, nameof(startingLeaf));
				SerializeField(s, nameof(looping));
				SerializeField(s, nameof(useIntro));
			}
		}
		public override uint? ClassCRC => 0xA7DEF63F;
	}
}

