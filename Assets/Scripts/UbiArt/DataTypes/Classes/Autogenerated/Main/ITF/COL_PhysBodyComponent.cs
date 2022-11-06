using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PhysBodyComponent : CSerializable {
		public int isStatic;
		public Enum_collisionGroup collisionGroup;
		public float weight;
		public Vec2d gravity;
		public float gravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			isStatic = s.Serialize<int>(isStatic, name: "isStatic");
			collisionGroup = s.Serialize<Enum_collisionGroup>(collisionGroup, name: "collisionGroup");
			weight = s.Serialize<float>(weight, name: "weight");
			gravity = s.SerializeObject<Vec2d>(gravity, name: "gravity");
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
		}
		public enum Enum_collisionGroup {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value_8" )] Value_8 = 8,
			[Serialize("Value_16")] Value_16 = 16,
		}
		public override uint? ClassCRC => 0xA882E9E2;
	}
}

