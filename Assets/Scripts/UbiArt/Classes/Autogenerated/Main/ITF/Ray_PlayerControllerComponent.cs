using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_PlayerControllerComponent : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class StateDeadSoul_Template : CSerializable {
			[Serialize("Generic<PhysShape>__0")] public Generic<PhysShape> Generic_PhysShape__0;
			[Serialize("float__1"             )] public float float__1;
			[Serialize("int__2"               )] public int int__2;
			[Serialize("float__3"             )] public float float__3;
			[Serialize("float__4"             )] public float float__4;
			[Serialize("float__5"             )] public float float__5;
			[Serialize("float__6"             )] public float float__6;
			[Serialize("float__7"             )] public float float__7;
			[Serialize("float__8"             )] public float float__8;
			[Serialize("Vector2__9"           )] public Vector2 Vector2__9;
			[Serialize("float__10"            )] public float float__10;
			[Serialize("Angle__11"            )] public Angle Angle__11;
			[Serialize("float__12"            )] public float float__12;
			[Serialize("float__13"            )] public float float__13;
			[Serialize("float__14"            )] public float float__14;
			[Serialize("float__15"            )] public float float__15;
			[Serialize("int__16"              )] public int int__16;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Generic_PhysShape__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(int__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(Vector2__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(Angle__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(int__16));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class StateRevive_Template : CSerializable {
			[Serialize("float__0")] public float float__0;
			[Serialize("float__1")] public float float__1;
			[Serialize("float__2")] public float float__2;
			[Serialize("float__3")] public float float__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
			}
		}
		[Games(GameFlags.RO)]
		public partial class StateStargate : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
			public override uint? ClassCRC => 0xB7FAF178;
		}
		public override uint? ClassCRC => 0xA9E2930D;
	}
}

