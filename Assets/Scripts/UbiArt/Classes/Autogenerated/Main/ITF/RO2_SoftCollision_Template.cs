using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_SoftCollision_Template : CSerializable {
		[Serialize("radius"   )] public float radius;
		[Serialize("exitSpeed")] public float exitSpeed;
		[Serialize("exitForce")] public float exitForce;
		[Serialize("offset"   )] public Vector2 offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(radius));
			SerializeField(s, nameof(exitSpeed));
			SerializeField(s, nameof(exitForce));
			SerializeField(s, nameof(offset));
		}
	}
}

