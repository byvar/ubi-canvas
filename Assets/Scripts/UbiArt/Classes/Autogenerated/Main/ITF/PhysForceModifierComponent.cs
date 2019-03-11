using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysForceModifierComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xD76EC5F5;
	}
}

