using UnityEngine;

namespace UbiArt.ITF {
	public partial class PolylineComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xFF243AF5;
	}
}

