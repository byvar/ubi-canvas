using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_Powerup_CheckActive : RLC_Mission_Guard {
		public StringID powerup;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			powerup = s.SerializeObject<StringID>(powerup, name: "powerup");
		}
		public override uint? ClassCRC => 0x2C248BB3;
	}
}

