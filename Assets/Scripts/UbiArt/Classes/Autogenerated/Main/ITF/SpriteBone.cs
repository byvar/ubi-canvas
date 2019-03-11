using UnityEngine;

namespace UbiArt.ITF {
	public partial class SpriteBone : CSerializable {
		[Serialize("name")] public StringID name;
		[Serialize("p0"  )] public Vector2 p0;
		[Serialize("p1"  )] public Vector2 p1;
		[Serialize("uv0" )] public Vector2 uv0;
		[Serialize("uv1" )] public Vector2 uv1;
		[Serialize("z"   )] public float z;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(p0));
			SerializeField(s, nameof(p1));
			SerializeField(s, nameof(uv0));
			SerializeField(s, nameof(uv1));
			SerializeField(s, nameof(z));
		}
	}
}

