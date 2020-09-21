using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea : ActorComponent {
		public float float__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public bool bool__8;
		public bool bool__9;
		public bool bool__10;
		public bool bool__11;
		public bool bool__12;
		public bool bool__13;
		public float float__14;
		public Vec2d Vector2__15;
		public bool bool__16;
		public bool bool__17;
		public bool bool__18;
		public CArrayO<W1W_Actor_Rea.AvoidHitType> CArray_W1W_Actor_Rea_AvoidHitType__19;
		public EventSender EventSender__20;
		public EventSender EventSender__21;
		public Path Path__22;
		public CArrayO<W1W_Actor_Rea.spawnStruct> CArray_W1W_Actor_Rea_spawnStruct__23;
		public Vec3d Vector3__24;
		public StringID StringID__25;
		public bool bool__26;
		public bool bool__27;
		public bool bool__28;
		public Enum_VH_0 Enum_VH_0__29;
		public W1W_Actor_Rea.Orientation_Link W1W_Actor_Rea_Orientation_Link__30;
		public W1W_Actor_Rea.Orientation_MC W1W_Actor_Rea_Orientation_MC__31;
		public Angle Angle__32;
		public W1W_Actor_Rea.Orientation_Angle W1W_Actor_Rea_Orientation_Angle__33;
		public Path Path__34;
		public bool bool__35;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				bool__8 = s.Serialize<bool>(bool__8, name: "bool__8");
				bool__9 = s.Serialize<bool>(bool__9, name: "bool__9");
				bool__10 = s.Serialize<bool>(bool__10, name: "bool__10");
				bool__11 = s.Serialize<bool>(bool__11, name: "bool__11");
				bool__12 = s.Serialize<bool>(bool__12, name: "bool__12");
				bool__13 = s.Serialize<bool>(bool__13, name: "bool__13");
				float__14 = s.Serialize<float>(float__14, name: "float__14");
				Vector2__15 = s.SerializeObject<Vec2d>(Vector2__15, name: "Vector2__15");
				bool__16 = s.Serialize<bool>(bool__16, name: "bool__16");
				bool__17 = s.Serialize<bool>(bool__17, name: "bool__17");
				bool__18 = s.Serialize<bool>(bool__18, name: "bool__18");
				CArray_W1W_Actor_Rea_AvoidHitType__19 = s.SerializeObject<CArrayO<W1W_Actor_Rea.AvoidHitType>>(CArray_W1W_Actor_Rea_AvoidHitType__19, name: "CArray_W1W_Actor_Rea_AvoidHitType__19");
				EventSender__20 = s.SerializeObject<EventSender>(EventSender__20, name: "EventSender__20");
				EventSender__21 = s.SerializeObject<EventSender>(EventSender__21, name: "EventSender__21");
				Path__22 = s.SerializeObject<Path>(Path__22, name: "Path__22");
				CArray_W1W_Actor_Rea_spawnStruct__23 = s.SerializeObject<CArrayO<W1W_Actor_Rea.spawnStruct>>(CArray_W1W_Actor_Rea_spawnStruct__23, name: "CArray_W1W_Actor_Rea_spawnStruct__23");
				Vector3__24 = s.SerializeObject<Vec3d>(Vector3__24, name: "Vector3__24");
				StringID__25 = s.SerializeObject<StringID>(StringID__25, name: "StringID__25");
				bool__26 = s.Serialize<bool>(bool__26, name: "bool__26");
				bool__27 = s.Serialize<bool>(bool__27, name: "bool__27");
				bool__28 = s.Serialize<bool>(bool__28, name: "bool__28");
				Enum_VH_0__29 = s.Serialize<Enum_VH_0>(Enum_VH_0__29, name: "Enum_VH_0__29");
				W1W_Actor_Rea_Orientation_Link__30 = s.SerializeObject<W1W_Actor_Rea.Orientation_Link>(W1W_Actor_Rea_Orientation_Link__30, name: "W1W_Actor_Rea_Orientation_Link__30");
				W1W_Actor_Rea_Orientation_MC__31 = s.SerializeObject<W1W_Actor_Rea.Orientation_MC>(W1W_Actor_Rea_Orientation_MC__31, name: "W1W_Actor_Rea_Orientation_MC__31");
				Angle__32 = s.SerializeObject<Angle>(Angle__32, name: "Angle__32");
				W1W_Actor_Rea_Orientation_Angle__33 = s.SerializeObject<W1W_Actor_Rea.Orientation_Angle>(W1W_Actor_Rea_Orientation_Angle__33, name: "W1W_Actor_Rea_Orientation_Angle__33");
				Path__34 = s.SerializeObject<Path>(Path__34, name: "Path__34");
				bool__35 = s.Serialize<bool>(bool__35, name: "bool__35");
			}
		}
		[Games(GameFlags.VH)]
		public partial class AvoidHitType : CSerializable {
			public Enum_VH_0 Enum_VH_0__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
			}
			public enum Enum_VH_0 {
				[Serialize("Value_0"  )] Value_0 = 0,
				[Serialize("Value_1"  )] Value_1 = 1,
				[Serialize("Value_2"  )] Value_2 = 2,
				[Serialize("Value_4"  )] Value_4 = 4,
				[Serialize("Value_8"  )] Value_8 = 8,
				[Serialize("Value_12" )] Value_12 = 12,
				[Serialize("Value_14" )] Value_14 = 14,
				[Serialize("Value_16" )] Value_16 = 16,
				[Serialize("Value_32" )] Value_32 = 32,
				[Serialize("Value_33" )] Value_33 = 33,
				[Serialize("Value_64" )] Value_64 = 64,
				[Serialize("Value_128")] Value_128 = 128,
				[Serialize("Value__1" )] Value__1 = -1,
			}
		}
		[Games(GameFlags.VH)]
		public partial class spawnStruct : CSerializable {
			public Path Path__0;
			public StringID StringID__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
			}
		}
		[Games(GameFlags.VH)]
		public partial class Orientation_Angle : CSerializable {
			public Angle Angle__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Angle__0 = s.SerializeObject<Angle>(Angle__0, name: "Angle__0");
			}
		}
		[Games(GameFlags.VH)]
		public partial class Orientation_Link : CSerializable {
			public StringID StringID__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
			}
		}
		[Games(GameFlags.VH)]
		public partial class Orientation_MC : CSerializable {
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0"  )] Value_0 = 0,
			[Serialize("Value_1"  )] Value_1 = 1,
			[Serialize("Value_2"  )] Value_2 = 2,
			[Serialize("Value_255")] Value_255 = 255,
		}
		public override uint? ClassCRC => 0x34AAF86B;
	}
}

