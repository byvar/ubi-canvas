using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MurphyComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xDE4656DA;
	}
}

