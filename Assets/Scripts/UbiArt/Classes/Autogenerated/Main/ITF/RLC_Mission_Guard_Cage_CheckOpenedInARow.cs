using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RM)]
	public partial class RLC_Mission_Guard_Cage_CheckOpenedInARow : CSerializable {
		public uint numberOfCages;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			numberOfCages = s.Serialize<uint>(numberOfCages, name: "numberOfCages");
		}
		public override uint? ClassCRC => 0x3F37E4D8;
	}
}

