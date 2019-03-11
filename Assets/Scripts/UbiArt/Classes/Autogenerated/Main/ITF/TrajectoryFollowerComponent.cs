using UnityEngine;

namespace UbiArt.ITF {
	public partial class TrajectoryFollowerComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xAA03F900;
	}
}

