using UnityEngine;

namespace UbiArt.online {
	[Games(GameFlags.RA)]
	public partial class Gifts_Template : ITF.TemplateObj {
		[Serialize("pools"                      )] public CMap<ITF.StringID, GiftPoolConfig> pools;
		[Serialize("currentPoolKeyStringID"     )] public StringID currentPoolKeyStringID;
		[Serialize("FacebookInviteRewardEnabled")] public bool FacebookInviteRewardEnabled;
		[Serialize("nbInviteRewardSpeedElixirs" )] public uint nbInviteRewardSpeedElixirs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pools));
			SerializeField(s, nameof(currentPoolKeyStringID));
			SerializeField(s, nameof(FacebookInviteRewardEnabled));
			SerializeField(s, nameof(nbInviteRewardSpeedElixirs));
		}
		public override uint? ClassCRC => 0x41A33734;
	}
}

