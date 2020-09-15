using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimMeshVertexPetData : CSerializable {
		public CList<AnimMeshVertexPetPart> parts;
		public Vec3d position;
		public float angle;
		public Vec2d scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			parts = s.SerializeObject<CList<AnimMeshVertexPetPart>>(parts, name: "parts");
			position = s.SerializeObject<Vec3d>(position, name: "position");
			angle = s.Serialize<float>(angle, name: "angle");
			scale = s.SerializeObject<Vec2d>(scale, name: "scale");
		}
	}
}

