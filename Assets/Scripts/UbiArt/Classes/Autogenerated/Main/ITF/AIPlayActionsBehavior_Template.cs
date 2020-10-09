using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AIPlayActionsBehavior_Template : TemplateAIBehavior {
		public CArrayO<Generic<AIAction_Template>> actions;
		public bool resetAnimTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				actions = s.SerializeObject<CArrayO<Generic<AIAction_Template>>>(actions, name: "actions");
			} else {
				actions = s.SerializeObject<CArrayO<Generic<AIAction_Template>>>(actions, name: "actions");
				resetAnimTime = s.Serialize<bool>(resetAnimTime, name: "resetAnimTime");
			}
		}
		public override uint? ClassCRC => 0xC4941695;
	}
}

