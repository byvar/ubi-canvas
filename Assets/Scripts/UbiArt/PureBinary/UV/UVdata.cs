using UnityEngine;

namespace UbiArt.UV {
	public class UVdata : CSerializable {
		[Serialize("uvs")] public CArray<Vector2> uvs;
		[Serialize("uv0")] public Vector2 uv0;
		[Serialize("uv1")] public Vector2 uv1;

		protected override void SerializeImpl(CSerializerObject s) {
			if (Settings.s.engineVersion == Settings.EngineVersion.RO) {
				SerializeField(s, nameof(uv0));
				SerializeField(s, nameof(uv1));
			} else {
				SerializeField(s, nameof(uvs));
			}
		}
	}
}
