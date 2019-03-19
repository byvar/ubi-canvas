using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_PlayerBounce_CheckType : RLC_Mission_Guard {
		[Serialize("bounceType")] public uint bounceType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bounceType));
		}
		public override uint? ClassCRC => 0x99B19812;
	}
}

