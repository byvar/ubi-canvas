using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class PhysForceModifier : CSerializable {
		[Serialize("Vector2__0"                        )] public Vector2 Vector2__0;
		[Serialize("Vector2__1"                        )] public Vector2 Vector2__1;
		[Serialize("Angle__2"                          )] public Angle Angle__2;
		[Serialize("float__3"                          )] public float float__3;
		[Serialize("float__4"                          )] public float float__4;
		[Serialize("float__5"                          )] public float float__5;
		[Serialize("float__6"                          )] public float float__6;
		[Serialize("float__7"                          )] public float float__7;
		[Serialize("float__8"                          )] public float float__8;
		[Serialize("int__9"                            )] public int int__9;
		[Serialize("int__10"                           )] public int int__10;
		[Serialize("Enum_RJR_0__11"                    )] public Enum_RJR_0 Enum_RJR_0__11;
		[Serialize("PhysForceModifier.BoxData__12"     )] public PhysForceModifier.BoxData PhysForceModifier_BoxData__12;
		[Serialize("PhysForceModifier.PolylineData__13")] public PhysForceModifier.PolylineData PhysForceModifier_PolylineData__13;
		[Serialize("PhysForceModifier.CircleData__14"  )] public PhysForceModifier.CircleData PhysForceModifier_CircleData__14;
		[Serialize("Vector2__15"                       )] public Vector2 Vector2__15;
		[Serialize("Vector2__16"                       )] public Vector2 Vector2__16;
		[Serialize("Angle__17"                         )] public Angle Angle__17;
		[Serialize("float__18"                         )] public float float__18;
		[Serialize("float__19"                         )] public float float__19;
		[Serialize("float__20"                         )] public float float__20;
		[Serialize("float__21"                         )] public float float__21;
		[Serialize("float__22"                         )] public float float__22;
		[Serialize("float__23"                         )] public float float__23;
		[Serialize("int__24"                           )] public int int__24;
		[Serialize("int__25"                           )] public int int__25;
		[Serialize("Enum_RFR_0__26"                    )] public Enum_RFR_0 Enum_RFR_0__26;
		[Serialize("PhysForceModifier.BoxData__27"     )] public PhysForceModifier.BoxData PhysForceModifier_BoxData__27;
		[Serialize("PhysForceModifier.PolylineData__28")] public PhysForceModifier.PolylineData PhysForceModifier_PolylineData__28;
		[Serialize("PhysForceModifier.CircleData__29"  )] public PhysForceModifier.CircleData PhysForceModifier_CircleData__29;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Vector2__15));
				SerializeField(s, nameof(Vector2__16));
				SerializeField(s, nameof(Angle__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(float__20));
				SerializeField(s, nameof(float__21));
				SerializeField(s, nameof(float__22));
				SerializeField(s, nameof(float__23));
				SerializeField(s, nameof(int__24));
				SerializeField(s, nameof(int__25));
				SerializeField(s, nameof(Enum_RFR_0__26));
				SerializeField(s, nameof(PhysForceModifier_BoxData__27));
				SerializeField(s, nameof(PhysForceModifier_PolylineData__28));
				SerializeField(s, nameof(PhysForceModifier_CircleData__29));
			} else {
				SerializeField(s, nameof(Vector2__0));
				SerializeField(s, nameof(Vector2__1));
				SerializeField(s, nameof(Angle__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(int__9));
				SerializeField(s, nameof(int__10));
				SerializeField(s, nameof(Enum_RJR_0__11));
				SerializeField(s, nameof(PhysForceModifier_BoxData__12));
				SerializeField(s, nameof(PhysForceModifier_PolylineData__13));
				SerializeField(s, nameof(PhysForceModifier_CircleData__14));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class BoxData : CSerializable {
			[Serialize("float__0")] public float float__0;
			[Serialize("float__1")] public float float__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class CircleData : CSerializable {
			[Serialize("float__0")] public float float__0;
			[Serialize("Angle__1")] public Angle Angle__1;
			[Serialize("Angle__2")] public Angle Angle__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(Angle__1));
				SerializeField(s, nameof(Angle__2));
			}
		}
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class PolylineData : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x4F18F0CF;
	}
}

