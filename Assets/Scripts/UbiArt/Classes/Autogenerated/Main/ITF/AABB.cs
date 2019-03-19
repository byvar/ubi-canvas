using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class AABB : CSerializable {
		[Serialize("MIN")] public Vector2 MIN;
		[Serialize("MAX")] public Vector2 MAX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MIN));
			SerializeField(s, nameof(MAX));
		}
	}
}

