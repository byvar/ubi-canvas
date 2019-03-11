using UnityEngine;

namespace UbiArt.ITF {
	public partial class VertexPNC3T : CSerializable {
		[Serialize("pos"  )] public Vector3 pos;
		[Serialize("color")] public ColorInteger color;
		[Serialize("uv1"  )] public Vector2 uv1;
		[Serialize("uv2"  )] public GFX_Vector4 uv2;
		[Serialize("uv3"  )] public GFX_Vector4 uv3;
		[Serialize("uv4"  )] public Vector2 uv4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(uv1));
			SerializeField(s, nameof(uv2));
			SerializeField(s, nameof(uv3));
			SerializeField(s, nameof(uv4));
		}
	}
}

