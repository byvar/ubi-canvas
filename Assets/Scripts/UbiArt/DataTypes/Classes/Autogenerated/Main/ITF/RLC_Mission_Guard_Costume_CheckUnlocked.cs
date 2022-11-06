using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_Mission_Guard_Costume_CheckUnlocked : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xC33D8E74;
	}
}

