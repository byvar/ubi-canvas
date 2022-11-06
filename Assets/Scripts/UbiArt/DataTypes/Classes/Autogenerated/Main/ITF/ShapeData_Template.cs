using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class ShapeData_Template : CSerializable {
		public StringID name;
		public Generic<PhysShape> shape;
		public Vec2d offset;
		public StringID attachPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			name = s.SerializeObject<StringID>(name, name: "name");
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
			offset = s.SerializeObject<Vec2d>(offset, name: "offset");
			attachPolyline = s.SerializeObject<StringID>(attachPolyline, name: "attachPolyline");
		}
	}
}

