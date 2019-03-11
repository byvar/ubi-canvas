using UnityEngine;

namespace UbiArt.ITF {
	public partial class PendulumComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xB4648C0E;
	}
}

