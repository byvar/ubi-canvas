using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class ShapeData_Template : CSerializable {
		[Serialize("name"          )] public StringID name;
		[Serialize("shape"         )] public Generic<PhysShape> shape;
		[Serialize("offset"        )] public Vec2d offset;
		[Serialize("attachPolyline")] public StringID attachPolyline;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(shape));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(attachPolyline));
		}
	}
}

