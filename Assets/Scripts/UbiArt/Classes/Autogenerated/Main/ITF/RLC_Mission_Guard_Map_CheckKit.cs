using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_Mission_Guard_Map_CheckKit : RLC_Mission_Guard {
		public uint kit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			kit = s.Serialize<uint>(kit, name: "kit");
		}
		public override uint? ClassCRC => 0xD8A81BD6;
	}
}

