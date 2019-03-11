using UnityEngine;

namespace UbiArt.ITF {
	public partial class AIFallNoPhysAction_Template : AIAction_Template {
		[Serialize("duration"   )] public float duration;
		[Serialize("fakeGravity")] public float fakeGravity;
		[Serialize("maxSpeed"   )] public float maxSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(fakeGravity));
			SerializeField(s, nameof(maxSpeed));
		}
		public override uint? ClassCRC => 0xC0F9AD01;
	}
}

