using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimMeshVertexPetData : CSerializable {
		[Serialize("parts"   )] public CList<AnimMeshVertexPetPart> parts;
		[Serialize("position")] public Vec3d position;
		[Serialize("angle"   )] public float angle;
		[Serialize("scale"   )] public Vec2d scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(parts));
			SerializeField(s, nameof(position));
			SerializeField(s, nameof(angle));
			SerializeField(s, nameof(scale));
		}
	}
}

