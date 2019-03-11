using UnityEngine;

namespace UbiArt.ITF {
	public partial class RenderSimpleAnimComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x81832143;
	}
}

