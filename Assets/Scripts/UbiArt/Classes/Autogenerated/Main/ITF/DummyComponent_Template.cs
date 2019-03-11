using UnityEngine;

namespace UbiArt.ITF {
	public partial class DummyComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x7DF03683;
	}
}

