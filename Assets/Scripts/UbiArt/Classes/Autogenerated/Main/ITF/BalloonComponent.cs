using UnityEngine;

namespace UbiArt.ITF {
	public partial class BalloonComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x83615A77;
	}
}

