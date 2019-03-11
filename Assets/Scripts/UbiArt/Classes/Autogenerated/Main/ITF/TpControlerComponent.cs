using UnityEngine;

namespace UbiArt.ITF {
	public partial class TpControlerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x641B1454;
	}
}

