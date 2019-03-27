using UnityEngine;

namespace UbiArt.UV {
	public class UVdata : CSerializable {
		[Serialize("uvs")] public CArray<Vector2> uvs;

		protected override void SerializeImpl(CSerializerObject s) {
			SerializeField(s, nameof(uvs));
		}
	}
}
