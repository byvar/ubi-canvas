using UnityEngine;

namespace UbiArt.ITF {
	public partial class RewardContainer_Template : TemplateObj {
		[Serialize("rewards"     )] public CList<RewardDetail> rewards;
		[Serialize("statsHandler")] public RewardStatHandler statsHandler;
		[Serialize("isSilent"    )] public bool isSilent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(rewards));
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

