using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class AIPlayActionsBehavior_Template : TemplateAIBehavior {
		public CArray<Generic<AIAction_Template>> actions;
		public bool resetAnimTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				actions = s.SerializeObject<CArray<Generic<AIAction_Template>>>(actions, name: "actions");
			} else {
				actions = s.SerializeObject<CArray<Generic<AIAction_Template>>>(actions, name: "actions");
				resetAnimTime = s.Serialize<bool>(resetAnimTime, name: "resetAnimTime");
			}
		}
		public override uint? ClassCRC => 0xC4941695;
	}
}

