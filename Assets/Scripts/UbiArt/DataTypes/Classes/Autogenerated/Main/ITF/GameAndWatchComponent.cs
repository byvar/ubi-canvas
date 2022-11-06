using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class GameAndWatchComponent : ActorComponent {
		public uint uint__0;
		public Enum_VH_0 Enum_VH_0__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public uint uint__6;
		public float float__7;
		public CArrayO<GAWSpawnElement> CArray_GAWSpawnElement__8;
		public CArrayO<GAWSpawnElement> CArray_GAWSpawnElement__9;
		public CArrayO<GAWPattern> CArray_GAWPattern__10;
		public Enum_VH_1 Enum_VH_1__11;
		public float float__12;
		public float float__13;
		public float float__14;
		public float float__15;
		public Vec2d Vector2__16;
		public Vec2d Vector2__17;
		public float float__18;
		public float float__19;
		public float float__20;
		public float float__21;
		public float float__22;
		public ushort ushort__23;
		public Vec2d Vector2__24;
		public float float__25;
		public float float__26;
		public Path Path__27;
		public StringID StringID__28;
		public StringID StringID__29;
		public float float__30;
		public float float__31;
		public float float__32;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				Enum_VH_0__1 = s.Serialize<Enum_VH_0>(Enum_VH_0__1, name: "Enum_VH_0__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				float__3 = s.Serialize<float>(float__3, name: "float__3");
				float__4 = s.Serialize<float>(float__4, name: "float__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				uint__6 = s.Serialize<uint>(uint__6, name: "uint__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				CArray_GAWSpawnElement__8 = s.SerializeObject<CArrayO<GAWSpawnElement>>(CArray_GAWSpawnElement__8, name: "CArray<GAWSpawnElement>__8");
				CArray_GAWSpawnElement__9 = s.SerializeObject<CArrayO<GAWSpawnElement>>(CArray_GAWSpawnElement__9, name: "CArray<GAWSpawnElement>__9");
				CArray_GAWPattern__10 = s.SerializeObject<CArrayO<GAWPattern>>(CArray_GAWPattern__10, name: "CArray<GAWPattern>__10");
				Enum_VH_1__11 = s.Serialize<Enum_VH_1>(Enum_VH_1__11, name: "Enum_VH_1__11");
				float__12 = s.Serialize<float>(float__12, name: "float__12");
				float__13 = s.Serialize<float>(float__13, name: "float__13");
				float__14 = s.Serialize<float>(float__14, name: "float__14");
				float__15 = s.Serialize<float>(float__15, name: "float__15");
				Vector2__16 = s.SerializeObject<Vec2d>(Vector2__16, name: "Vector2__16");
				Vector2__17 = s.SerializeObject<Vec2d>(Vector2__17, name: "Vector2__17");
				float__18 = s.Serialize<float>(float__18, name: "float__18");
				float__19 = s.Serialize<float>(float__19, name: "float__19");
				float__20 = s.Serialize<float>(float__20, name: "float__20");
				float__21 = s.Serialize<float>(float__21, name: "float__21");
				float__22 = s.Serialize<float>(float__22, name: "float__22");
				ushort__23 = s.Serialize<ushort>(ushort__23, name: "ushort__23");
				Vector2__24 = s.SerializeObject<Vec2d>(Vector2__24, name: "Vector2__24");
				float__25 = s.Serialize<float>(float__25, name: "float__25");
				float__26 = s.Serialize<float>(float__26, name: "float__26");
				Path__27 = s.SerializeObject<Path>(Path__27, name: "Path__27");
				StringID__28 = s.SerializeObject<StringID>(StringID__28, name: "StringID__28");
				StringID__29 = s.SerializeObject<StringID>(StringID__29, name: "StringID__29");
				float__30 = s.Serialize<float>(float__30, name: "float__30");
				float__31 = s.Serialize<float>(float__31, name: "float__31");
				float__32 = s.Serialize<float>(float__32, name: "float__32");
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
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

