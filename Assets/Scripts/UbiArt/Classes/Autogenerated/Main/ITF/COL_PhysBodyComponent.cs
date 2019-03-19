using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_PhysBodyComponent : CSerializable {
		[Serialize("isStatic"         )] public int isStatic;
		[Serialize("collisionGroup"   )] public Enum_collisionGroup collisionGroup;
		[Serialize("weight"           )] public float weight;
		[Serialize("gravity"          )] public Vector2 gravity;
		[Serialize("gravityMultiplier")] public float gravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(isStatic));
			SerializeField(s, nameof(collisionGroup));
			SerializeField(s, nameof(weight));
			SerializeField(s, nameof(gravity));
			SerializeField(s, nameof(gravityMultiplier));
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

