using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventSwipe : Event {
		[Serialize("angle")] public Angle angle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(angle));
		}
		public override uint? ClassCRC => 0x4FECC5D6;
	}
}

