using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class RewardContainer_Template : TemplateObj {
		[Serialize("rewards"     )] public CList<RewardDetail> rewards;
		[Serialize("statsHandler")] public RewardStatHandler statsHandler;
		[Serialize("isSilent"    )] public bool isSilent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(rewards));
				SerializeField(s, nameof(isSilent));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(isSilent));
			} else {
				SerializeField(s, nameof(rewards));
				SerializeField(s, nameof(statsHandler));
				SerializeField(s, nameof(isSilent));
			}
		}
		public override uint? ClassCRC => 0x3ABE1DA8;
	}
}

