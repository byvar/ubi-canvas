using UnityEngine;

namespace UbiArt.ITF {
	public partial class VertexPCT : CSerializable {
		[Serialize("pos"  )] public Vector3 pos;
		[Serialize("color")] public ColorInteger color;
		[Serialize("uv"   )] public Vector2 uv;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(uv));
		}
	}
}

