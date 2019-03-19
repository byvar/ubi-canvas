using System;
using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class SerializationTestComponent : ActorComponent {
		[Serialize("m_bool"               )] public bool m_bool;
		[Serialize("m_bbool"              )] public bool m_bbool;
		[Serialize("m_char"               )] public char m_char;
		[Serialize("m_short"              )] public short m_short;
		[Serialize("m_i16"                )] public short m_i16;
		[Serialize("m_i32"                )] public int m_i32;
		[Serialize("m_u16"                )] public ushort m_u16;
		[Serialize("m_u32"                )] public uint m_u32;
		[Serialize("m_float"              )] public float m_float;
		[Serialize("m_f32"                )] public float m_f32;
		[Serialize("m_f64"                )] public double m_f64;
		[Serialize("m_double"             )] public double m_double;
		[Serialize("m_stringId"           )] public StringID m_stringId;
		[Serialize("m_wwiseStringId"      )] public StringID m_wwiseStringId;
		[Serialize("m_string8"            )] public string m_string8;
		[Serialize("m_path"               )] public Path m_path;
		[Serialize("m_objectPath"         )] public ObjectPath m_objectPath;
		[Serialize("m_vec2d"              )] public Vector2 m_vec2d;
		[Serialize("m_vec3d"              )] public Vector3 m_vec3d;
		[Serialize("m_matrix44"           )] public Matrix44 m_matrix44;
		[Serialize("m_color"              )] public Color m_color;
		[Serialize("m_colorInteger"       )] public ColorInteger m_colorInteger;
		[Serialize("m_angle"              )] public Angle m_angle;
		[Serialize("m_angleAmount"        )] public AngleAmount m_angleAmount;
		[Serialize("m_flags"              )] public Flag m_flags;
		[Serialize("m_object"             )] public SerializationTestComponent.SubClass m_object;
		[Serialize("m_u32Vector"          )] public CList<uint> m_u32Vector;
		[Serialize("m_enumVector"         )] public CList<SerializationTestComponent.TestEnum> m_enumVector;
		[Serialize("m_objectVector"       )] public CList<SerializationTestComponent.SubClass> m_objectVector;
		[Serialize("m_stringVector"       )] public CArray<string> m_stringVector;
		[Serialize("m_stringIdVector"     )] public CList<StringID> m_stringIdVector;
		[Serialize("m_vec3Vector"         )] public CArray<Vector3> m_vec3Vector;
		[Serialize("m_U32ToU32Map"        )] public CMap<uint, uint> m_U32ToU32Map;
		[Serialize("m_StringToStringMap"  )] public CMap<string, string> m_StringToStringMap;
		[Serialize("m_StringToSubClassMap")] public CMap<string, SerializationTestComponent.SubClass> m_StringToSubClassMap;
		[Serialize("m_EnumToStringMap"    )] public CMap<SerializationTestComponent.TestEnum, string> m_EnumToStringMap;
		[Serialize("m_StringIDToEnumMap"  )] public CMap<StringID, SerializationTestComponent.TestEnum> m_StringIDToEnumMap;
		[Serialize("m_locId"              )] public LocalisationId m_locId;
		[Serialize("m_platform"           )] public Platform m_platform;
		[Serialize("m_objectWithFactory"  )] public Generic<BaseRttiTest> m_objectWithFactory;
		[Serialize("m_vectorWithFactory"  )] public CArray<Generic<BaseRttiTest>> m_vectorWithFactory;
		[Serialize("m_mapWithFactory"     )] public CMap<StringID, BaseRttiTest> m_mapWithFactory;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(m_bool));
			SerializeField(s, nameof(m_bbool));
			SerializeField(s, nameof(m_char));
			SerializeField(s, nameof(m_short));
			SerializeField(s, nameof(m_i16));
			SerializeField(s, nameof(m_i32));
			SerializeField(s, nameof(m_u16));
			SerializeField(s, nameof(m_u32));
			SerializeField(s, nameof(m_float));
			SerializeField(s, nameof(m_f32));
			SerializeField(s, nameof(m_f64));
			SerializeField(s, nameof(m_double));
			SerializeField(s, nameof(m_stringId));
			SerializeField(s, nameof(m_wwiseStringId));
			SerializeField(s, nameof(m_string8));
			SerializeField(s, nameof(m_path));
			SerializeField(s, nameof(m_objectPath));
			SerializeField(s, nameof(m_vec2d));
			SerializeField(s, nameof(m_vec3d));
			SerializeField(s, nameof(m_matrix44));
			SerializeField(s, nameof(m_color));
			SerializeField(s, nameof(m_colorInteger));
			SerializeField(s, nameof(m_angle));
			SerializeField(s, nameof(m_angleAmount));
			SerializeField(s, nameof(m_flags));
			SerializeField(s, nameof(m_object));
			SerializeField(s, nameof(m_u32Vector));
			SerializeField(s, nameof(m_enumVector));
			SerializeField(s, nameof(m_objectVector));
			SerializeField(s, nameof(m_stringVector));
			SerializeField(s, nameof(m_stringVector));
			SerializeField(s, nameof(m_stringIdVector));
			SerializeField(s, nameof(m_vec3Vector));
			SerializeField(s, nameof(m_vec3Vector));
			SerializeField(s, nameof(m_U32ToU32Map));
			SerializeField(s, nameof(m_StringToStringMap));
			SerializeField(s, nameof(m_StringToSubClassMap));
			SerializeField(s, nameof(m_EnumToStringMap));
			SerializeField(s, nameof(m_StringIDToEnumMap));
			SerializeField(s, nameof(m_locId));
			SerializeField(s, nameof(m_platform));
			SerializeField(s, nameof(m_objectWithFactory));
			SerializeField(s, nameof(m_vectorWithFactory));
			SerializeField(s, nameof(m_mapWithFactory));
		}
		[Games(GameFlags.RA)]
		public partial class SubClass : CSerializable {
			[Serialize("m_u32"    )] public uint m_u32;
			[Serialize("m_string8")] public string m_string8;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(m_u32));
				SerializeField(s, nameof(m_string8));
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

