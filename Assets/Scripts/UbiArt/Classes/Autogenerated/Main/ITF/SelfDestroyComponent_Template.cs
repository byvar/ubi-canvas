using UnityEngine;

namespace UbiArt.ITF {
	public partial class SelfDestroyComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB86719AC;
	}
}

