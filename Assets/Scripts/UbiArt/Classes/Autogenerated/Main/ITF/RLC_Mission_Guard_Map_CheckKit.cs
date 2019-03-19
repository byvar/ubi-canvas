using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_Mission_Guard_Map_CheckKit : RLC_Mission_Guard {
		[Serialize("kit")] public uint kit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(kit));
		}
		public override uint? ClassCRC => 0xD8A81BD6;
	}
}

