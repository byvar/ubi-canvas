using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class AnimMeshVertexPetPart : CSerializable {
		public char type;
		public int variant;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			type = s.Serialize<char>(type, name: "type");
			variant = s.Serialize<int>(variant, name: "variant");
		}
	}
}

