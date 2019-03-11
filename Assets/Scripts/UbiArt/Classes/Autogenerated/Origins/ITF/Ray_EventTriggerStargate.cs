using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventTriggerStargate : Event {
		[Serialize("start")] public Vector3 start;
		[Serialize("speed")] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(start));
			SerializeField(s, nameof(speed));
		}
		public override uint? ClassCRC => 0xBA526589;
	}
}

