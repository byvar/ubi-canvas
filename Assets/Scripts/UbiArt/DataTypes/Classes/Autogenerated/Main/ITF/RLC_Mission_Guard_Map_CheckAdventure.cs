using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_Mission_Guard_Map_CheckAdventure : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x5F8D435A;
	}
}

