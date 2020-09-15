using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class AABB : CSerializable {
		[Serialize("MIN")] public Vec2d MIN;
		[Serialize("MAX")] public Vec2d MAX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MIN));
			SerializeField(s, nameof(MAX));
		}
	}
}

