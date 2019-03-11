using UnityEngine;

namespace UbiArt.ITF {
	public partial class ShapeData_Template : CSerializable {
		[Serialize("name"          )] public StringID name;
		[Serialize("shape"         )] public Generic<PhysShape> shape;
		[Serialize("offset"        )] public Vector2 offset;
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

