using UnityEngine;

namespace UbiArt.ITF {
	public partial class EditableShape : CSerializable {
		[Serialize("shape")] public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(shape));
			}
		}
	}
}

