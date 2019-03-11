using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIBallisticsAction_Template : AIAction_Template {
		[Serialize("duration")] public float duration;
		[Serialize("speed"   )] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(speed));
		}
		public override uint? ClassCRC => 0x60637C23;
	}
}

