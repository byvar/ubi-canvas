using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_PlayerBounce_CheckType : RLC_Mission_Guard {
		public uint bounceType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bounceType = s.Serialize<uint>(bounceType, name: "bounceType");
		}
		public override uint? ClassCRC => 0x99B19812;
	}
}

