using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AABB3d : CSerializable {
		[Serialize("MIN")] public Vec3d MIN;
		[Serialize("MAX")] public Vec3d MAX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MIN));
			SerializeField(s, nameof(MAX));
		}
	}
}

