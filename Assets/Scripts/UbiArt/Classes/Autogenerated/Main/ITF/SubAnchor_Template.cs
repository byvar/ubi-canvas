using UnityEngine;

namespace UbiArt.ITF {
	public partial class SubAnchor_Template : CSerializable {
		[Serialize("name"      )] public StringID name;
		[Serialize("defaultPos")] public Vector3 defaultPos;
		[Serialize("clampAABB" )] public AABB clampAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(defaultPos));
			SerializeField(s, nameof(clampAABB));
		}
	}
}

