using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_EasterEggStock : RLC_InventoryItem {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDAB51AA4;
	}
}

