using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimMarkerTriggerComponent : TriggerComponent {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		public override uint? ClassCRC => 0x49A14955;
	}
}

