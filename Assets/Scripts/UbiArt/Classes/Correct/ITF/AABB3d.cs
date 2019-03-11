using UnityEngine;

namespace UbiArt.ITF {
	public partial class AABB3d : CSerializable {
		[Serialize("MIN")] public Vector3 MIN;
		[Serialize("MAX")] public Vector3 MAX;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(MIN));
			SerializeField(s, nameof(MAX));
		}
	}
}

