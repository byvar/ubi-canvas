using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_GemsPack : RLC_VirtualCurrencyPack {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x176D4FCB;
	}
}

