using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_PlayerAttack_CheckType : RLC_Mission_Guard {
		[Serialize("hitType")] public uint hitType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(hitType));
		}
		public override uint? ClassCRC => 0xA31C4830;
	}
}

