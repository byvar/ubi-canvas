using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventForceConstantSpeed : Event {
		[Serialize("enter"           )] public bool enter;
		[Serialize("speed"           )] public float speed;
		[Serialize("blendInDuration" )] public float blendInDuration;
		[Serialize("blendOutDuration")] public float blendOutDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(enter));
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(blendInDuration));
			SerializeField(s, nameof(blendOutDuration));
		}
		public override uint? ClassCRC => 0x0491AD14;
	}
}

