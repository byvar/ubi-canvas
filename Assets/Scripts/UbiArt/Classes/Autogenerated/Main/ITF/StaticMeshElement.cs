using UnityEngine;

namespace UbiArt.ITF {
	public partial class StaticMeshElement : CSerializable {
		[Serialize("pos"             )] public Vector3 pos;
		[Serialize("color"           )] public Color color;
		[Serialize("animated"        )] public bool animated;
		[Serialize("frisePath"       )] public ObjectPath frisePath;
		[Serialize("staticVertexList")] public CList<VertexPNC3T> staticVertexList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(pos));
			SerializeField(s, nameof(color));
			SerializeField(s, nameof(animated));
			SerializeField(s, nameof(frisePath));
			SerializeField(s, nameof(staticVertexList));
		}
	}
}

