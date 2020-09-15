using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_SNS_CheckConnected : RLC_Mission_Guard {
		public uint sns;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sns = s.Serialize<uint>(sns, name: "sns");
		}
		public override uint? ClassCRC => 0xCA662B40;
	}
}

