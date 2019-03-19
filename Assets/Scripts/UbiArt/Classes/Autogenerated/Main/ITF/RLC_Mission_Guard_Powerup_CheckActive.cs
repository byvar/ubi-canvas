using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Powerup_CheckActive : RLC_Mission_Guard {
		[Serialize("powerup")] public StringID powerup;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(powerup));
		}
		public override uint? ClassCRC => 0x2C248BB3;
	}
}

