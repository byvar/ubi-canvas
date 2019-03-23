using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL)]
	public partial class AIPlayActionsBehavior_Template : TemplateAIBehavior {
		[Serialize("actions"      )] public CArray<Generic<AIAction_Template>> actions;
		[Serialize("resetAnimTime")] public bool resetAnimTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(actions));
			} else {
				SerializeField(s, nameof(actions));
				SerializeField(s, nameof(resetAnimTime));
			}
		}
		public override uint? ClassCRC => 0xC4941695;
	}
}

