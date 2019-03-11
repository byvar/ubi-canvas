using UnityEngine;

namespace UbiArt.ITF {
	public partial class MetaFriezeParams : CSerializable {
		[Serialize("path"       )] public Path path;
		[Serialize("worldOffset")] public Vector3 worldOffset;
		[Serialize("localOffset")] public float localOffset;
		[Serialize("scale"      )] public float scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(path));
			SerializeField(s, nameof(worldOffset));
			SerializeField(s, nameof(localOffset));
			SerializeField(s, nameof(scale));
		}
	}
}

