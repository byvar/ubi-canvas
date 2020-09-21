using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class RewardContainer_Template : TemplateObj {
		public CListO<RewardDetail> rewards;
		public RewardStatHandler statsHandler;
		public bool isSilent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				rewards = s.SerializeObject<CListO<RewardDetail>>(rewards, name: "rewards");
				isSilent = s.Serialize<bool>(isSilent, name: "isSilent");
			} else if (Settings.s.game == Settings.Game.COL) {
				isSilent = s.Serialize<bool>(isSilent, name: "isSilent");
			} else {
				rewards = s.SerializeObject<CListO<RewardDetail>>(rewards, name: "rewards");
				statsHandler = s.SerializeObject<RewardStatHandler>(statsHandler, name: "statsHandler");
				isSilent = s.Serialize<bool>(isSilent, name: "isSilent");
			}
		}
		public override uint? ClassCRC => 0x3ABE1DA8;
	}
}

