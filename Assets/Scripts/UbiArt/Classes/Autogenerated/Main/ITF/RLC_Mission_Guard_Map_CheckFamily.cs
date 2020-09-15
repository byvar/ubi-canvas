using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Map_CheckFamily : RLC_Mission_Guard {
		public uint family;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			family = s.Serialize<uint>(family, name: "family");
		}
		public override uint? ClassCRC => 0x9E64D362;
	}
}

