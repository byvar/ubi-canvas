using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_LuckyTicketRewardWeight : CSerializable {
		[Serialize("luckyTicketReward")] public RLC_LuckyTicketReward luckyTicketReward;
		[Serialize("weight"           )] public uint weight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(luckyTicketReward));
			SerializeField(s, nameof(weight));
		}
	}
}

