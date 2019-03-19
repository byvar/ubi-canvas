using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class RO2_DigRegionComponent : ActorComponent {
		[Serialize("Enum_VH_0__0"                      )] public Enum_VH_0 Enum_VH_0__0;
		[Serialize("Enum_VH_1__1"                      )] public Enum_VH_1 Enum_VH_1__1;
		[Serialize("uint__2"                           )] public uint uint__2;
		[Serialize("uint__3"                           )] public uint uint__3;
		[Serialize("int__4"                            )] public int int__4;
		[Serialize("Vector2__5"                        )] public Vector2 Vector2__5;
		[Serialize("int__6"                            )] public int int__6;
		[Serialize("float__7"                          )] public float float__7;
		[Serialize("float__8"                          )] public float float__8;
		[Serialize("float__9"                          )] public float float__9;
		[Serialize("bool__10"                          )] public bool bool__10;
		[Serialize("Angle__11"                         )] public Angle Angle__11;
		[Serialize("float__12"                         )] public float float__12;
		[Serialize("float__13"                         )] public float float__13;
		[Serialize("float__14"                         )] public float float__14;
		[Serialize("float__15"                         )] public float float__15;
		[Serialize("float__16"                         )] public float float__16;
		[Serialize("int__17"                           )] public int int__17;
		[Serialize("float__18"                         )] public float float__18;
		[Serialize("float__19"                         )] public float float__19;
		[Serialize("float__20"                         )] public float float__20;
		[Serialize("float__21"                         )] public float float__21;
		[Serialize("float__22"                         )] public float float__22;
		[Serialize("RO2_DigRegionComponent.ParamUV__23")] public RO2_DigRegionComponent.ParamUV RO2_DigRegionComponent_ParamUV__23;
		[Serialize("RO2_DigRegionComponent.ParamUV__24")] public RO2_DigRegionComponent.ParamUV RO2_DigRegionComponent_ParamUV__24;
		[Serialize("float__25"                         )] public float float__25;
		[Serialize("bool__26"                          )] public bool bool__26;
		[Serialize("GFXPrimitiveParam__27"             )] public GFXPrimitiveParam GFXPrimitiveParam__27;
		[Serialize("bool__28"                          )] public bool bool__28;
		[Serialize("bool__29"                          )] public bool bool__29;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(Enum_VH_0__0));
				SerializeField(s, nameof(Enum_VH_1__1));
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(uint__2));
				SerializeField(s, nameof(uint__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(Vector2__5));
				SerializeField(s, nameof(int__6));
				if (s.HasFlags(SerializeFlags.Flags_x03)) {
					SerializeField(s, nameof(float__7));
					SerializeField(s, nameof(float__8));
					SerializeField(s, nameof(float__9));
					SerializeField(s, nameof(bool__10));
					SerializeField(s, nameof(Angle__11));
					SerializeField(s, nameof(float__12));
					SerializeField(s, nameof(float__13));
					SerializeField(s, nameof(float__14));
					SerializeField(s, nameof(float__15));
					SerializeField(s, nameof(float__16));
					SerializeField(s, nameof(int__17));
					SerializeField(s, nameof(float__18));
					SerializeField(s, nameof(float__19));
					SerializeField(s, nameof(float__20));
					SerializeField(s, nameof(float__21));
					SerializeField(s, nameof(float__22));
					SerializeField(s, nameof(RO2_DigRegionComponent_ParamUV__23));
					SerializeField(s, nameof(RO2_DigRegionComponent_ParamUV__24));
					SerializeField(s, nameof(float__25));
					SerializeField(s, nameof(bool__26));
					SerializeField(s, nameof(GFXPrimitiveParam__27));
					SerializeField(s, nameof(bool__28));
				}
			}
			SerializeField(s, nameof(bool__29));
		}
		[Games(GameFlags.VH)]
		public partial class ParamUV : CSerializable {
			[Serialize("bool__0"   )] public bool bool__0;
			[Serialize("Vector2__1")] public Vector2 Vector2__1;
			[Serialize("Vector2__2")] public Vector2 Vector2__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(bool__0));
				SerializeField(s, nameof(Vector2__1));
				SerializeField(s, nameof(Vector2__2));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x0C4BD15D;
	}
}

