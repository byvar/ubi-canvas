using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class RO2_SubAnchor_Template : CSerializable {
		public StringID name;
		public Vec3d defaultPos;
		public Color color;
		public AABB clampAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			defaultPos = s.SerializeObject<Vec3d>(defaultPos, name: "defaultPos");
			color = s.SerializeObject<Color>(color, name: "color");
			clampAABB = s.SerializeObject<AABB>(clampAABB, name: "clampAABB");
		}
	}
}

