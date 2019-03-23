using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTDecider_Template : BTNode_Template {
		[Serialize("nodes"     )] public CList<BTNodeTemplate_Ref> nodes;
		[Serialize("reevaluate")] public bool reevaluate;
		[Serialize("clearFacts")] public CArray<StringID> clearFacts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
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

