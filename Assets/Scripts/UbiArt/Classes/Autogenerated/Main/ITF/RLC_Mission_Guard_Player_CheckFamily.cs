using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Player_CheckFamily : RLC_Mission_Guard {
		[Serialize("playerFamily")] public string playerFamily;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(playerFamily));
		}
		public override uint? ClassCRC => 0x51A69AB0;
	}
}

