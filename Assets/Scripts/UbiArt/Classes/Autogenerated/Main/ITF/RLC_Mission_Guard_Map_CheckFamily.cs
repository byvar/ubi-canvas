using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_Mission_Guard_Map_CheckFamily : RLC_Mission_Guard {
		[Serialize("family")] public uint family;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(family));
		}
		public override uint? ClassCRC => 0x9E64D362;
	}
}

