using UnityEngine;

namespace UbiArt.ITF {
	public partial class GravityComponent : PhysForceModifierComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xBF680BCE;
	}
}

