using UnityEngine;

namespace UbiArt.ITF {
	public partial class SteeringComponent_Template : ActorComponent_Template {
		[Serialize("walkSpeed")] public float walkSpeed;
		[Serialize("runSpeed" )] public float runSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(walkSpeed));
			SerializeField(s, nameof(runSpeed));
		}
		public override uint? ClassCRC => 0x7D7DAF2F;
	}
}

