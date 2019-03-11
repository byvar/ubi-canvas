using UnityEngine;

namespace UbiArt.ITF {
	public partial class BTDecider_Template : BTNode_Template {
		[Serialize("nodes"     )] public CList<BTNodeTemplate_Ref> nodes;
		[Serialize("reevaluate")] public bool reevaluate;
		[Serialize("clearFacts")] public Placeholder clearFacts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(nodes));
				SerializeField(s, nameof(clearFacts));
				SerializeField(s, nameof(reevaluate));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(nodes));
				SerializeField(s, nameof(clearFacts));
				SerializeField(s, nameof(reevaluate));
			} else {
				SerializeField(s, nameof(nodes));
				SerializeField(s, nameof(reevaluate));
			}
		}
		public override uint? ClassCRC => 0x1F80085C;
	}
}

