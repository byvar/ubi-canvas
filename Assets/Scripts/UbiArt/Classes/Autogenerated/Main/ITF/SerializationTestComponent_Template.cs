using UnityEngine;

namespace UbiArt.ITF {
	public partial class SerializationTestComponent_Template : ActorComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD7A5BF8A;
	}
}

