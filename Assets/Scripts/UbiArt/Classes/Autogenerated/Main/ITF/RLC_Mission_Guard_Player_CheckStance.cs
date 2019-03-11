using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_Player_CheckStance : RLC_Mission_Guard {
		[Serialize("stance")] public uint stance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(stance));
		}
		public override uint? ClassCRC => 0x77F683AC;
	}
}

