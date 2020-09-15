using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class BTDecider_Template : BTNode_Template {
		public CList<BTNodeTemplate_Ref> nodes;
		public bool reevaluate;
		public CArray<StringID> clearFacts;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.COL) {
				nodes = s.SerializeObject<CList<BTNodeTemplate_Ref>>(nodes, name: "nodes");
				clearFacts = s.SerializeObject<CArray<StringID>>(clearFacts, name: "clearFacts");
				reevaluate = s.Serialize<bool>(reevaluate, name: "reevaluate");
			} else {
				nodes = s.SerializeObject<CList<BTNodeTemplate_Ref>>(nodes, name: "nodes");
				reevaluate = s.Serialize<bool>(reevaluate, name: "reevaluate");
			}
		}
		public override uint? ClassCRC => 0x1F80085C;
	}
}

