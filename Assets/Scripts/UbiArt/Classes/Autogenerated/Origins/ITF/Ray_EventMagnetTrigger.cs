using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventMagnetTrigger : EventTrigger {
		[Serialize("magnetForce")] public float magnetForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(magnetForce));
		}
		public override uint? ClassCRC => 0x0660A7C6;
	}
}

