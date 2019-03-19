using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimMeshVertexPetPart : CSerializable {
		[Serialize("type"   )] public char type;
		[Serialize("variant")] public int variant;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(type));
			SerializeField(s, nameof(variant));
		}
	}
}

