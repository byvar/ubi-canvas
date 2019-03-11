using UnityEngine;

namespace UbiArt.ITF {
	public partial class Mesh3dData : CSerializable {
		[Serialize("uvMin"   )] public Vector2 uvMin;
		[Serialize("uvMax"   )] public Vector2 uvMax;
		[Serialize("meshList")] public CList<Mesh3dDataElement> meshList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uvMin));
			SerializeField(s, nameof(uvMax));
			SerializeField(s, nameof(meshList));
		}
	}
}

