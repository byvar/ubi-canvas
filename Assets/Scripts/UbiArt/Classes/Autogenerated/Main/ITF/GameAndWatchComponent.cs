using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GameAndWatchComponent : ActorComponent {
		[Serialize("uint__0"                   )] public uint uint__0;
		[Serialize("Enum_VH_0__1"              )] public Enum_VH_0 Enum_VH_0__1;
		[Serialize("float__2"                  )] public float float__2;
		[Serialize("float__3"                  )] public float float__3;
		[Serialize("float__4"                  )] public float float__4;
		[Serialize("float__5"                  )] public float float__5;
		[Serialize("uint__6"                   )] public uint uint__6;
		[Serialize("float__7"                  )] public float float__7;
		[Serialize("CArray<GAWSpawnElement>__8")] public CArray<GAWSpawnElement> CArray_GAWSpawnElement__8;
		[Serialize("CArray<GAWSpawnElement>__9")] public CArray<GAWSpawnElement> CArray_GAWSpawnElement__9;
		[Serialize("CArray<GAWPattern>__10"    )] public CArray<GAWPattern> CArray_GAWPattern__10;
		[Serialize("Enum_VH_1__11"             )] public Enum_VH_1 Enum_VH_1__11;
		[Serialize("float__12"                 )] public float float__12;
		[Serialize("float__13"                 )] public float float__13;
		[Serialize("float__14"                 )] public float float__14;
		[Serialize("float__15"                 )] public float float__15;
		[Serialize("Vector2__16"               )] public Vector2 Vector2__16;
		[Serialize("Vector2__17"               )] public Vector2 Vector2__17;
		[Serialize("float__18"                 )] public float float__18;
		[Serialize("float__19"                 )] public float float__19;
		[Serialize("float__20"                 )] public float float__20;
		[Serialize("float__21"                 )] public float float__21;
		[Serialize("float__22"                 )] public float float__22;
		[Serialize("ushort__23"                )] public ushort ushort__23;
		[Serialize("Vector2__24"               )] public Vector2 Vector2__24;
		[Serialize("float__25"                 )] public float float__25;
		[Serialize("float__26"                 )] public float float__26;
		[Serialize("Path__27"                  )] public Path Path__27;
		[Serialize("StringID__28"              )] public StringID StringID__28;
		[Serialize("StringID__29"              )] public StringID StringID__29;
		[Serialize("float__30"                 )] public float float__30;
		[Serialize("float__31"                 )] public float float__31;
		[Serialize("float__32"                 )] public float float__32;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(Enum_VH_0__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(float__3));
				SerializeField(s, nameof(float__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(uint__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(CArray_GAWSpawnElement__8));
				SerializeField(s, nameof(CArray_GAWSpawnElement__9));
				SerializeField(s, nameof(CArray_GAWPattern__10));
				SerializeField(s, nameof(Enum_VH_1__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(float__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(float__15));
				SerializeField(s, nameof(Vector2__16));
				SerializeField(s, nameof(Vector2__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(float__19));
				SerializeField(s, nameof(float__20));
				SerializeField(s, nameof(float__21));
				SerializeField(s, nameof(float__22));
				SerializeField(s, nameof(ushort__23));
				SerializeField(s, nameof(Vector2__24));
				SerializeField(s, nameof(float__25));
				SerializeField(s, nameof(float__26));
				SerializeField(s, nameof(Path__27));
				SerializeField(s, nameof(StringID__28));
				SerializeField(s, nameof(StringID__29));
				SerializeField(s, nameof(float__30));
				SerializeField(s, nameof(float__31));
				SerializeField(s, nameof(float__32));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(uint__0));
			}
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_VH_1 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
		}
		public override uint? ClassCRC => 0xE82468BE;
	}
}

