using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_Player_HasGround : RLC_Mission_Guard {
		public bool hasGround;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			hasGround = s.Serialize<bool>(hasGround, name: "hasGround");
		}
		public override uint? ClassCRC => 0xC9D1A137;
	}
}

