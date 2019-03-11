using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BezierBone : CSerializable {
		[Serialize("id"           )] public StringID id;
		[Serialize("distance"     )] public float distance;
		[Serialize("offset"       )] public float offset;
		[Serialize("followTangent")] public bool followTangent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
			SerializeField(s, nameof(distance));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(followTangent));
		}
	}
}

