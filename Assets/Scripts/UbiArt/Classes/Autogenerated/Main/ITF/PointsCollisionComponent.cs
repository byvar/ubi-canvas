using UnityEngine;

namespace UbiArt.ITF {
	public partial class PointsCollisionComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x12ACE724;
	}
}

