using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_Actor_Rea : ActorComponent {
		[Serialize("float__0"                              )] public float float__0;
		[Serialize("float__1"                              )] public float float__1;
		[Serialize("float__2"                              )] public float float__2;
		[Serialize("float__3"                              )] public float float__3;
		[Serialize("float__4"                              )] public float float__4;
		[Serialize("float__5"                              )] public float float__5;
		[Serialize("float__6"                              )] public float float__6;
		[Serialize("float__7"                              )] public float float__7;
		[Serialize("bool__8"                               )] public bool bool__8;
		[Serialize("bool__9"                               )] public bool bool__9;
		[Serialize("bool__10"                              )] public bool bool__10;
		[Serialize("bool__11"                              )] public bool bool__11;
		[Serialize("bool__12"                              )] public bool bool__12;
		[Serialize("bool__13"                              )] public bool bool__13;
		[Serialize("float__14"                             )] public float float__14;
		[Serialize("Vector2__15"                           )] public Vec2d Vector2__15;
		[Serialize("bool__16"                              )] public bool bool__16;
		[Serialize("bool__17"                              )] public bool bool__17;
		[Serialize("bool__18"                              )] public bool bool__18;
		[Serialize("CArray<W1W_Actor_Rea.AvoidHitType>__19")] public CArray<W1W_Actor_Rea.AvoidHitType> CArray_W1W_Actor_Rea_AvoidHitType__19;
		[Serialize("EventSender__20"                       )] public EventSender EventSender__20;
		[Serialize("EventSender__21"                       )] public EventSender EventSender__21;
		[Serialize("Path__22"                              )] public Path Path__22;
		[Serialize("CArray<W1W_Actor_Rea.spawnStruct>__23" )] public CArray<W1W_Actor_Rea.spawnStruct> CArray_W1W_Actor_Rea_spawnStruct__23;
		[Serialize("Vector3__24"                           )] public Vec3d Vector3__24;
		[Serialize("StringID__25"                          )] public StringID StringID__25;
		[Serialize("bool__26"                              )] public bool bool__26;
		[Serialize("bool__27"                              )] public bool bool__27;
		[Serialize("bool__28"                              )] public bool bool__28;
		[Serialize("Enum_VH_0__29"                         )] public Enum_VH_0 Enum_VH_0__29;
		[Serialize("W1W_Actor_Rea.Orientation_Link__30"    )] public W1W_Actor_Rea.Orientation_Link W1W_Actor_Rea_Orientation_Link__30;
		[Serialize("W1W_Actor_Rea.Orientation_MC__31"      )] public W1W_Actor_Rea.Orientation_MC W1W_Actor_Rea_Orientation_MC__31;
		[Serialize("Angle__32"                             )] public Angle Angle__32;
		[Serialize("W1W_Actor_Rea.Orientation_Angle__33"   )] public W1W_Actor_Rea.Orientation_Angle W1W_Actor_Rea_Orientation_Angle__33;
		[Serialize("Path__34"                              )] public Path Path__34;
		[Serialize("bool__35"                              )] public bool bool__35;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(float__0));
				SerializeField(s, nameof(float__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(bool__8));
				SerializeField(s, nameof(bool__9));
				SerializeField(s, nameof(bool__10));
				SerializeField(s, nameof(bool__11));
				SerializeField(s, nameof(bool__12));
				SerializeField(s, nameof(bool__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(Vector2__15));
				SerializeField(s, nameof(bool__16));
				SerializeField(s, nameof(bool__17));
				SerializeField(s, nameof(bool__18));
				SerializeField(s, nameof(CArray_W1W_Actor_Rea_AvoidHitType__19));
				SerializeField(s, nameof(EventSender__20));
				SerializeField(s, nameof(EventSender__21));
				SerializeField(s, nameof(Path__22));
				SerializeField(s, nameof(CArray_W1W_Actor_Rea_spawnStruct__23));
				SerializeField(s, nameof(Vector3__24));
				SerializeField(s, nameof(StringID__25));
				SerializeField(s, nameof(bool__26));
				SerializeField(s, nameof(bool__27));
				SerializeField(s, nameof(bool__28));
				SerializeField(s, nameof(Enum_VH_0__29));
				SerializeField(s, nameof(W1W_Actor_Rea_Orientation_Link__30));
				SerializeField(s, nameof(W1W_Actor_Rea_Orientation_MC__31));
				SerializeField(s, nameof(Angle__32));
				SerializeField(s, nameof(W1W_Actor_Rea_Orientation_Angle__33));
				SerializeField(s, nameof(Path__34));
				SerializeField(s, nameof(bool__35));
			}
		}
		[Games(GameFlags.VH)]
		public partial class AvoidHitType : CSerializable {
			[Serialize("Enum_VH_0__0")] public Enum_VH_0 Enum_VH_0__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Enum_VH_0__0));
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
			[Serialize("Path__0"    )] public Path Path__0;
			[Serialize("StringID__1")] public StringID StringID__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Path__0));
				SerializeField(s, nameof(StringID__1));
			}
		}
		[Games(GameFlags.VH)]
		public partial class Orientation_Angle : CSerializable {
			[Serialize("Angle__0")] public Angle Angle__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(Angle__0));
			}
		}
		[Games(GameFlags.VH)]
		public partial class Orientation_Link : CSerializable {
			[Serialize("StringID__0")] public StringID StringID__0;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(StringID__0));
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

