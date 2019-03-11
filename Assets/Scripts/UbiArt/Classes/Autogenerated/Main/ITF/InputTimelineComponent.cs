using UnityEngine;

namespace UbiArt.ITF {
	public partial class InputTimelineComponent : ActorComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0xED8C3223;
	}
}

