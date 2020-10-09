using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class AnimMeshVertexPetData : CSerializable {
		public CListO<AnimMeshVertexPetPart> parts;
		public Vec3d position;
		public float angle;
		public Vec2d scale;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			parts = s.SerializeObject<CListO<AnimMeshVertexPetPart>>(parts, name: "parts");
			position = s.SerializeObject<Vec3d>(position, name: "position");
			angle = s.Serialize<float>(angle, name: "angle");
			scale = s.SerializeObject<Vec2d>(scale, name: "scale");
		}
	}
}

