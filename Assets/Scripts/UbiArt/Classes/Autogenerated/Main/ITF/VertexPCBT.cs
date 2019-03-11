using UnityEngine;

namespace UbiArt.ITF {
	public partial class VertexPCBT : CSerializable {
		[Serialize("pos"         )] public Vector3 pos;
		[Serialize("color"       )] public ColorInteger color;
		[Serialize("blendIndices")] public uint blendIndices;
		[Serialize("uv"          )] public Vector2 uv;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(blendIndices));
			SerializeField(s, nameof(uv));
		}
	}
}

