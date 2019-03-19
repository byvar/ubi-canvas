using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimMeshVertexPetData : CSerializable {
		[Serialize("parts"   )] public CList<AnimMeshVertexPetPart> parts;
		[Serialize("position")] public Vector3 position;
		[Serialize("angle"   )] public float angle;
		[Serialize("scale"   )] public Vector2 scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(parts));
			SerializeField(s, nameof(position));
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(scale));
		}
	}
}

