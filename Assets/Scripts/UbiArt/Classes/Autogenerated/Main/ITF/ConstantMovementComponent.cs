using UnityEngine;

namespace UbiArt.ITF {
	public partial class ConstantMovementComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBCD916DE;
	}
}

