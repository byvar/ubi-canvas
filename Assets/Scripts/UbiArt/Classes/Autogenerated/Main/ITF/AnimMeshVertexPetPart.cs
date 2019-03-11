using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimMeshVertexPetPart : CSerializable {
		[Serialize("variant")] public int variant;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(variant));
		}
	}
}

