using UnityEngine;

namespace UbiArt.ITF {
	public partial class ParticlePhysComponent : PhysComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xA5396A8F;
	}
}

