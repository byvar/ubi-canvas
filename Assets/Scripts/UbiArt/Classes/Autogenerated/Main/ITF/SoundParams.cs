using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class SoundParams : CSerializable {
		[Serialize("uint__0"                           )] public uint uint__0;
		[Serialize("int__1"                            )] public int int__1;
		[Serialize("Enum_RJR_0__2"                     )] public Enum_RJR_0 Enum_RJR_0__2;
		[Serialize("Volume__3"                         )] public Volume Volume__3;
		[Serialize("Volume__4"                         )] public Volume Volume__4;
		[Serialize("float__5"                          )] public float float__5;
		[Serialize("float__6"                          )] public float float__6;
		[Serialize("float__7"                          )] public float float__7;
		[Serialize("float__8"                          )] public float float__8;
		[Serialize("float__9"                          )] public float float__9;
		[Serialize("float__10"                         )] public float float__10;
		[Serialize("float__11"                         )] public float float__11;
		[Serialize("float__12"                         )] public float float__12;
		[Serialize("Enum_RJR_1__13"                    )] public Enum_RJR_1 Enum_RJR_1__13;
		[Serialize("uint__14"                          )] public uint uint__14;
		[Serialize("uint__15"                          )] public uint uint__15;
		[Serialize("CArray<Generic<SoundModifier>>__16")] public CArray<Generic<SoundModifier>> CArray_Generic_SoundModifier__16;
		[Serialize("uint__17"                          )] public uint uint__17;
		[Serialize("int__18"                           )] public int int__18;
		[Serialize("Enum_RFR_0__19"                    )] public Enum_RFR_0 Enum_RFR_0__19;
		[Serialize("Volume__20"                        )] public Volume Volume__20;
		[Serialize("Volume__21"                        )] public Volume Volume__21;
		[Serialize("float__22"                         )] public float float__22;
		[Serialize("float__23"                         )] public float float__23;
		[Serialize("float__24"                         )] public float float__24;
		[Serialize("float__25"                         )] public float float__25;
		[Serialize("float__26"                         )] public float float__26;
		[Serialize("float__27"                         )] public float float__27;
		[Serialize("float__28"                         )] public float float__28;
		[Serialize("float__29"                         )] public float float__29;
		[Serialize("Enum_RFR_1__30"                    )] public Enum_RFR_1 Enum_RFR_1__30;
		[Serialize("uint__31"                          )] public uint uint__31;
		[Serialize("uint__32"                          )] public uint uint__32;
		[Serialize("CArray<Generic<SoundModifier>>__33")] public CArray<Generic<SoundModifier>> CArray_Generic_SoundModifier__33;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(uint__17));
				SerializeField(s, nameof(int__18));
				SerializeField(s, nameof(Enum_RFR_0__19));
				SerializeField(s, nameof(Volume__20));
				SerializeField(s, nameof(Volume__21));
				SerializeField(s, nameof(float__22));
				SerializeField(s, nameof(float__23));
				SerializeField(s, nameof(float__24));
				SerializeField(s, nameof(float__25));
				SerializeField(s, nameof(float__26));
				SerializeField(s, nameof(float__27));
				SerializeField(s, nameof(float__28));
				SerializeField(s, nameof(float__29));
				SerializeField(s, nameof(Enum_RFR_1__30));
				SerializeField(s, nameof(uint__31));
				SerializeField(s, nameof(uint__32));
				SerializeField(s, nameof(CArray_Generic_SoundModifier__33));
			} else {
				SerializeField(s, nameof(uint__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(Enum_RJR_0__2));
				SerializeField(s, nameof(Volume__3));
				SerializeField(s, nameof(Volume__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(float__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(Enum_RJR_1__13));
				SerializeField(s, nameof(uint__14));
				SerializeField(s, nameof(uint__15));
				SerializeField(s, nameof(CArray_Generic_SoundModifier__16));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public enum Enum_RJR_1 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
			[Serialize("Value_5")] Value_5 = 5,
		}
		public enum Enum_RFR_1 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
			[Serialize("Value_4")] Value_4 = 4,
		}
	}
}

