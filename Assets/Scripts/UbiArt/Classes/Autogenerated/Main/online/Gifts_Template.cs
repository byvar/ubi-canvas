using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Gifts_Template : ITF.TemplateObj {
		public CMap<StringID, GiftPoolConfig> pools;
		public StringID currentPoolKeyStringID;
		public bool FacebookInviteRewardEnabled;
		public uint nbInviteRewardSpeedElixirs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			pools = s.SerializeObject<CMap<StringID, GiftPoolConfig>>(pools, name: "pools");
			currentPoolKeyStringID = s.SerializeObject<StringID>(currentPoolKeyStringID, name: "currentPoolKeyStringID");
			FacebookInviteRewardEnabled = s.Serialize<bool>(FacebookInviteRewardEnabled, name: "FacebookInviteRewardEnabled");
			nbInviteRewardSpeedElixirs = s.Serialize<uint>(nbInviteRewardSpeedElixirs, name: "nbInviteRewardSpeedElixirs");
		}
		public override uint? ClassCRC => 0x41A33734;
	}
}

