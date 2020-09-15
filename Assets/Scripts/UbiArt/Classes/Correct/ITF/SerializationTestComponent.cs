using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SerializationTestComponent : ActorComponent {
		public bool m_bool;
		public bool m_bbool;
		public char m_char;
		public short m_short;
		public short m_i16;
		public int m_i32;
		public ushort m_u16;
		public uint m_u32;
		public float m_float;
		public float m_f32;
		public double m_f64;
		public double m_double;
		public StringID m_stringId;
		public StringID m_wwiseStringId;
		public string m_string8;
		public Path m_path;
		public ObjectPath m_objectPath;
		public Vec2d m_vec2d;
		public Vec3d m_vec3d;
		public Matrix44 m_matrix44;
		public Color m_color;
		public ColorInteger m_colorInteger;
		public Angle m_angle;
		public AngleAmount m_angleAmount;
		public Flag m_flags;
		public SerializationTestComponent.SubClass m_object;
		public CList<uint> m_u32Vector;
		public CList<SerializationTestComponent.TestEnum> m_enumVector;
		public CList<SerializationTestComponent.SubClass> m_objectVector;
		public CArray<string> m_stringVector;
		public CList<StringID> m_stringIdVector;
		public CArray<Vec3d> m_vec3Vector;
		public CMap<uint, uint> m_U32ToU32Map;
		public CMap<string, string> m_StringToStringMap;
		public CMap<string, SerializationTestComponent.SubClass> m_StringToSubClassMap;
		public CMap<SerializationTestComponent.TestEnum, string> m_EnumToStringMap;
		public CMap<StringID, SerializationTestComponent.TestEnum> m_StringIDToEnumMap;
		public LocalisationId m_locId;
		public Platform m_platform;
		public Generic<BaseRttiTest> m_objectWithFactory;
		public CArray<Generic<BaseRttiTest>> m_vectorWithFactory;
		public CMap<StringID, Generic<BaseRttiTest>> m_mapWithFactory;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			m_bool = s.Serialize<bool>(m_bool, name: "m_bool");
			m_bbool = s.Serialize<bool>(m_bbool, name: "m_bbool");
			m_char = s.Serialize<char>(m_char, name: "m_char");
			m_short = s.Serialize<short>(m_short, name: "m_short");
			m_i16 = s.Serialize<short>(m_i16, name: "m_i16");
			m_i32 = s.Serialize<int>(m_i32, name: "m_i32");
			m_u16 = s.Serialize<ushort>(m_u16, name: "m_u16");
			m_u32 = s.Serialize<uint>(m_u32, name: "m_u32");
			m_float = s.Serialize<float>(m_float, name: "m_float");
			m_f32 = s.Serialize<float>(m_f32, name: "m_f32");
			m_f64 = s.Serialize<double>(m_f64, name: "m_f64");
			m_double = s.Serialize<double>(m_double, name: "m_double");
			m_stringId = s.SerializeObject<StringID>(m_stringId, name: "m_stringId");
			m_wwiseStringId = s.SerializeObject<StringID>(m_wwiseStringId, name: "m_wwiseStringId");
			m_string8 = s.Serialize<string>(m_string8, name: "m_string8");
			m_path = s.SerializeObject<Path>(m_path, name: "m_path");
			m_objectPath = s.SerializeObject<ObjectPath>(m_objectPath, name: "m_objectPath");
			m_vec2d = s.SerializeObject<Vec2d>(m_vec2d, name: "m_vec2d");
			m_vec3d = s.SerializeObject<Vec3d>(m_vec3d, name: "m_vec3d");
			m_matrix44 = s.SerializeObject<Matrix44>(m_matrix44, name: "m_matrix44");
			m_color = s.SerializeObject<Color>(m_color, name: "m_color");
			m_colorInteger = s.SerializeObject<ColorInteger>(m_colorInteger, name: "m_colorInteger");
			m_angle = s.SerializeObject<Angle>(m_angle, name: "m_angle");
			m_angleAmount = s.SerializeObject<AngleAmount>(m_angleAmount, name: "m_angleAmount");
			m_flags = s.Serialize<Flag>(m_flags, name: "m_flags");
			m_object = s.SerializeObject<SerializationTestComponent.SubClass>(m_object, name: "m_object");
			m_u32Vector = s.SerializeObject<CList<uint>>(m_u32Vector, name: "m_u32Vector");
			m_enumVector = s.SerializeObject<CList<SerializationTestComponent.TestEnum>>(m_enumVector, name: "m_enumVector");
			m_objectVector = s.SerializeObject<CList<SerializationTestComponent.SubClass>>(m_objectVector, name: "m_objectVector");
			m_stringVector = s.SerializeObject<CArray<string>>(m_stringVector, name: "m_stringVector");
			m_stringVector = s.SerializeObject<CArray<string>>(m_stringVector, name: "m_stringVector");
			m_stringIdVector = s.SerializeObject<CList<StringID>>(m_stringIdVector, name: "m_stringIdVector");
			m_vec3Vector = s.SerializeObject<CArray<Vec3d>>(m_vec3Vector, name: "m_vec3Vector");
			m_vec3Vector = s.SerializeObject<CArray<Vec3d>>(m_vec3Vector, name: "m_vec3Vector");
			m_U32ToU32Map = s.SerializeObject<CMap<uint, uint>>(m_U32ToU32Map, name: "m_U32ToU32Map");
			m_StringToStringMap = s.SerializeObject<CMap<string, string>>(m_StringToStringMap, name: "m_StringToStringMap");
			m_StringToSubClassMap = s.SerializeObject<CMap<string, SerializationTestComponent.SubClass>>(m_StringToSubClassMap, name: "m_StringToSubClassMap");
			m_EnumToStringMap = s.SerializeObject<CMap<SerializationTestComponent.TestEnum, string>>(m_EnumToStringMap, name: "m_EnumToStringMap");
			m_StringIDToEnumMap = s.SerializeObject<CMap<StringID, SerializationTestComponent.TestEnum>>(m_StringIDToEnumMap, name: "m_StringIDToEnumMap");
			m_locId = s.SerializeObject<LocalisationId>(m_locId, name: "m_locId");
			m_platform = s.SerializeObject<Platform>(m_platform, name: "m_platform");
			m_objectWithFactory = s.SerializeObject<Generic<BaseRttiTest>>(m_objectWithFactory, name: "m_objectWithFactory");
			m_vectorWithFactory = s.SerializeObject<CArray<Generic<BaseRttiTest>>>(m_vectorWithFactory, name: "m_vectorWithFactory");
			m_mapWithFactory = s.SerializeObject<CMap<StringID, Generic<BaseRttiTest>>>(m_mapWithFactory, name: "m_mapWithFactory");
		}
		[Games(GameFlags.RA)]
		public partial class SubClass : CSerializable {
			public uint m_u32;
			public string m_string8;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				m_u32 = s.Serialize<uint>(m_u32, name: "m_u32");
				m_string8 = s.Serialize<string>(m_string8, name: "m_string8");
			}
		}
		[Flags]
		public enum Flag {
			[Serialize("Flag_1")] Flag1 = 1,
			[Serialize("Flag_2")] Flag2 = 2,
			[Serialize("Flag_3")] Flag3 = 4,
			[Serialize("Flag_4")] Flag4 = 8,
			[Serialize("Flag_5")] Flag5 = 16,
		}

		public enum TestEnum {
			[Serialize("SerializationTestComponent::TestEnum_Val1")] Val1 = 0,
			[Serialize("SerializationTestComponent::TestEnum_Val2")] Val2 = 1,
			[Serialize("SerializationTestComponent::TestEnum_Val3")] Val3 = 2,
			[Serialize("SerializationTestComponent::TestEnum_Val4")] Val4 = 3,
			[Serialize("SerializationTestComponent::TestEnum_Val5")] Val5 = 4,
		}
		public override uint? ClassCRC => 0x867ED04C;
	}
}

