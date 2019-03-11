using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_SNS_CheckConnected : RLC_Mission_Guard {
		[Serialize("sns")] public uint sns;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sns));
		}
		public override uint? ClassCRC => 0xCA662B40;
	}
}

