using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_GameManagerConfig_Template : GameManagerConfig_Template {
		public Path Path__0;
		public Path Path__1;
		public Path Path__2;
		public Path Path__3;
		public Path Path__4;
		public Path Path__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public Path Path__9;
		public Path Path__10;
		public PathRef PathRef__11;
		public Path Path__12;
		public CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo> CArray_W1W_GameManagerConfig_Template_LocalisedVideo__13;
		public Path Path__14;
		public CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo> CArray_W1W_GameManagerConfig_Template_LocalisedVideo__15;
		public PathRef PathRef__16;
		public CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo> CArray_W1W_GameManagerConfig_Template_LocalisedVideo__17;
		public Path Path__18;
		public CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo> CArray_W1W_GameManagerConfig_Template_LocalisedVideo__19;
		public Path Path__20;
		public CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo> CArray_W1W_GameManagerConfig_Template_LocalisedVideo__21;
		public Path Path__22;
		public CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo> CArray_W1W_GameManagerConfig_Template_LocalisedVideo__23;
		public Path Path__24;
		public CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo> CArray_W1W_GameManagerConfig_Template_LocalisedVideo__25;
		public PathRef PathRef__26;
		public CArrayO<W1W_GameManagerConfig_Template.MapConfig> CArray_W1W_GameManagerConfig_Template_MapConfig__27;
		public CArrayO<W1W_GameManagerConfig_Template.EpisodeConfig> CArray_W1W_GameManagerConfig_Template_EpisodeConfig__28;
		public CArrayO<W1W_GameManagerConfig_Template.WikiMapConfig> CArray_W1W_GameManagerConfig_Template_WikiMapConfig__29;
		public CArrayO<W1W_GameManagerConfig_Template.LocalNotificationConfig> CArray_W1W_GameManagerConfig_Template_LocalNotificationConfig__30;
		public CArrayO<PathRef> CArray_PathRef__31;
		public CArrayO<W1W_GameManagerConfig_Template.CharDiaMapConfig> CArray_W1W_GameManagerConfig_Template_CharDiaMapConfig__32;
		public CArrayO<W1W_GameManagerConfig_Template.ChardiaJumpCharConfig> CArray_W1W_GameManagerConfig_Template_ChardiaJumpCharConfig__33;
		public CArrayP<uint> CArray_uint__34;
		public float float__35;
		public float float__36;
		public float float__37;
		public float float__38;
		public float float__39;
		public float float__40;
		public float float__41;
		public float float__42;
		public float float__43;
		public Path Path__44;
		public Path Path__45;
		public float float__46;
		public Path Path__47;
		public Vec2d Vector2__48;
		public Path Path__49;
		public Vec2d Vector2__50;
		public Path Path__51;
		public Vec2d Vector2__52;
		public Path Path__53;
		public Vec2d Vector2__54;
		public Path Path__55;
		public Vec2d Vector2__56;
		public Path Path__57;
		public Vec2d Vector2__58;
		public uint uint__59;
		public CArrayO<W1W_GameManagerConfig_Template.ClueTimedType> CArray_W1W_GameManagerConfig_Template_ClueTimedType__60;
		public float float__61;
		public float float__62;
		public float float__63;
		public Path Path__64;
		public Path Path__65;
		public Path Path__66;
		public Path Path__67;
		public Path Path__68;
		public Path Path__69;
		public Vec2d Vector2__70;
		public Path Path__71;
		public Path Path__72;
		public Path Path__73;
		public string string__74;
		public string string__75;
		public string string__76;
		public string string__77;
		public string string__78;
		public string string__79;
		public string string__80;
		public string string__81;
		public string string__82;
		public string string__83;
		public string string__84;
		public Path Path__85;
		public Path Path__86;
		public Vec2d Vector2__87;
		public Vec2d Vector2__88;
		public Vec2d Vector2__89;
		public Vec2d Vector2__90;
		public Path Path__91;
		public float float__92;
		public float float__93;
		public float float__94;
		public Path Path__95;
		public Path Path__96;
		public Color Color__97;
		public Color Color__98;
		public Vec2d Vector2__99;
		public uint uint__100;
		public uint uint__101;
		public CArrayP<uint> CArray_uint__102;
		public CArrayP<uint> CArray_uint__103;
		public Vec2d Vector2__104;
		public Vec2d Vector2__105;
		public Vec2d Vector2__106;
		public float float__107;
		public float float__108;
		public float float__109;
		public float float__110;
		public uint uint__111;
		public float float__112;
		public float float__113;
		public Generic<Event> Generic_Event__114;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Path__0 = s.SerializeObject<Path>(Path__0, name: "Path__0");
			Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
			Path__2 = s.SerializeObject<Path>(Path__2, name: "Path__2");
			Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
			Path__4 = s.SerializeObject<Path>(Path__4, name: "Path__4");
			Path__5 = s.SerializeObject<Path>(Path__5, name: "Path__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			Path__9 = s.SerializeObject<Path>(Path__9, name: "Path__9");
			Path__10 = s.SerializeObject<Path>(Path__10, name: "Path__10");
			PathRef__11 = s.SerializeObject<PathRef>(PathRef__11, name: "PathRef__11");
			Path__12 = s.SerializeObject<Path>(Path__12, name: "Path__12");
			CArray_W1W_GameManagerConfig_Template_LocalisedVideo__13 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo>>(CArray_W1W_GameManagerConfig_Template_LocalisedVideo__13, name: "CArray<W1W_GameManagerConfig_Template.LocalisedVideo>__13");
			Path__14 = s.SerializeObject<Path>(Path__14, name: "Path__14");
			CArray_W1W_GameManagerConfig_Template_LocalisedVideo__15 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo>>(CArray_W1W_GameManagerConfig_Template_LocalisedVideo__15, name: "CArray<W1W_GameManagerConfig_Template.LocalisedVideo>__15");
			PathRef__16 = s.SerializeObject<PathRef>(PathRef__16, name: "PathRef__16");
			CArray_W1W_GameManagerConfig_Template_LocalisedVideo__17 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo>>(CArray_W1W_GameManagerConfig_Template_LocalisedVideo__17, name: "CArray<W1W_GameManagerConfig_Template.LocalisedVideo>__17");
			Path__18 = s.SerializeObject<Path>(Path__18, name: "Path__18");
			CArray_W1W_GameManagerConfig_Template_LocalisedVideo__19 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo>>(CArray_W1W_GameManagerConfig_Template_LocalisedVideo__19, name: "CArray<W1W_GameManagerConfig_Template.LocalisedVideo>__19");
			Path__20 = s.SerializeObject<Path>(Path__20, name: "Path__20");
			CArray_W1W_GameManagerConfig_Template_LocalisedVideo__21 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo>>(CArray_W1W_GameManagerConfig_Template_LocalisedVideo__21, name: "CArray<W1W_GameManagerConfig_Template.LocalisedVideo>__21");
			Path__22 = s.SerializeObject<Path>(Path__22, name: "Path__22");
			CArray_W1W_GameManagerConfig_Template_LocalisedVideo__23 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo>>(CArray_W1W_GameManagerConfig_Template_LocalisedVideo__23, name: "CArray<W1W_GameManagerConfig_Template.LocalisedVideo>__23");
			Path__24 = s.SerializeObject<Path>(Path__24, name: "Path__24");
			CArray_W1W_GameManagerConfig_Template_LocalisedVideo__25 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalisedVideo>>(CArray_W1W_GameManagerConfig_Template_LocalisedVideo__25, name: "CArray<W1W_GameManagerConfig_Template.LocalisedVideo>__25");
			PathRef__26 = s.SerializeObject<PathRef>(PathRef__26, name: "PathRef__26");
			CArray_W1W_GameManagerConfig_Template_MapConfig__27 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.MapConfig>>(CArray_W1W_GameManagerConfig_Template_MapConfig__27, name: "CArray<W1W_GameManagerConfig_Template.MapConfig>__27");
			CArray_W1W_GameManagerConfig_Template_EpisodeConfig__28 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.EpisodeConfig>>(CArray_W1W_GameManagerConfig_Template_EpisodeConfig__28, name: "CArray<W1W_GameManagerConfig_Template.EpisodeConfig>__28");
			CArray_W1W_GameManagerConfig_Template_WikiMapConfig__29 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.WikiMapConfig>>(CArray_W1W_GameManagerConfig_Template_WikiMapConfig__29, name: "CArray<W1W_GameManagerConfig_Template.WikiMapConfig>__29");
			CArray_W1W_GameManagerConfig_Template_LocalNotificationConfig__30 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.LocalNotificationConfig>>(CArray_W1W_GameManagerConfig_Template_LocalNotificationConfig__30, name: "CArray<W1W_GameManagerConfig_Template.LocalNotificationConfig>__30");
			CArray_PathRef__31 = s.SerializeObject<CArrayO<PathRef>>(CArray_PathRef__31, name: "CArray<PathRef>__31");
			CArray_W1W_GameManagerConfig_Template_CharDiaMapConfig__32 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.CharDiaMapConfig>>(CArray_W1W_GameManagerConfig_Template_CharDiaMapConfig__32, name: "CArray<W1W_GameManagerConfig_Template.CharDiaMapConfig>__32");
			CArray_W1W_GameManagerConfig_Template_ChardiaJumpCharConfig__33 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.ChardiaJumpCharConfig>>(CArray_W1W_GameManagerConfig_Template_ChardiaJumpCharConfig__33, name: "CArray<W1W_GameManagerConfig_Template.ChardiaJumpCharConfig>__33");
			CArray_uint__34 = s.SerializeObject<CArrayP<uint>>(CArray_uint__34, name: "CArray<uint>__34");
			float__35 = s.Serialize<float>(float__35, name: "float__35");
			float__36 = s.Serialize<float>(float__36, name: "float__36");
			float__37 = s.Serialize<float>(float__37, name: "float__37");
			float__38 = s.Serialize<float>(float__38, name: "float__38");
			float__39 = s.Serialize<float>(float__39, name: "float__39");
			float__40 = s.Serialize<float>(float__40, name: "float__40");
			float__41 = s.Serialize<float>(float__41, name: "float__41");
			float__42 = s.Serialize<float>(float__42, name: "float__42");
			float__43 = s.Serialize<float>(float__43, name: "float__43");
			Path__44 = s.SerializeObject<Path>(Path__44, name: "Path__44");
			Path__45 = s.SerializeObject<Path>(Path__45, name: "Path__45");
			float__46 = s.Serialize<float>(float__46, name: "float__46");
			Path__47 = s.SerializeObject<Path>(Path__47, name: "Path__47");
			Vector2__48 = s.SerializeObject<Vec2d>(Vector2__48, name: "Vector2__48");
			Path__49 = s.SerializeObject<Path>(Path__49, name: "Path__49");
			Vector2__50 = s.SerializeObject<Vec2d>(Vector2__50, name: "Vector2__50");
			Path__51 = s.SerializeObject<Path>(Path__51, name: "Path__51");
			Vector2__52 = s.SerializeObject<Vec2d>(Vector2__52, name: "Vector2__52");
			Path__53 = s.SerializeObject<Path>(Path__53, name: "Path__53");
			Vector2__54 = s.SerializeObject<Vec2d>(Vector2__54, name: "Vector2__54");
			Path__55 = s.SerializeObject<Path>(Path__55, name: "Path__55");
			Vector2__56 = s.SerializeObject<Vec2d>(Vector2__56, name: "Vector2__56");
			Path__57 = s.SerializeObject<Path>(Path__57, name: "Path__57");
			Vector2__58 = s.SerializeObject<Vec2d>(Vector2__58, name: "Vector2__58");
			uint__59 = s.Serialize<uint>(uint__59, name: "uint__59");
			CArray_W1W_GameManagerConfig_Template_ClueTimedType__60 = s.SerializeObject<CArrayO<W1W_GameManagerConfig_Template.ClueTimedType>>(CArray_W1W_GameManagerConfig_Template_ClueTimedType__60, name: "CArray<W1W_GameManagerConfig_Template.ClueTimedType>__60");
			float__61 = s.Serialize<float>(float__61, name: "float__61");
			float__62 = s.Serialize<float>(float__62, name: "float__62");
			float__63 = s.Serialize<float>(float__63, name: "float__63");
			Path__64 = s.SerializeObject<Path>(Path__64, name: "Path__64");
			Path__65 = s.SerializeObject<Path>(Path__65, name: "Path__65");
			Path__66 = s.SerializeObject<Path>(Path__66, name: "Path__66");
			Path__67 = s.SerializeObject<Path>(Path__67, name: "Path__67");
			Path__68 = s.SerializeObject<Path>(Path__68, name: "Path__68");
			Path__69 = s.SerializeObject<Path>(Path__69, name: "Path__69");
			Vector2__70 = s.SerializeObject<Vec2d>(Vector2__70, name: "Vector2__70");
			Path__71 = s.SerializeObject<Path>(Path__71, name: "Path__71");
			Path__72 = s.SerializeObject<Path>(Path__72, name: "Path__72");
			Path__73 = s.SerializeObject<Path>(Path__73, name: "Path__73");
			string__74 = s.Serialize<string>(string__74, name: "string__74");
			string__75 = s.Serialize<string>(string__75, name: "string__75");
			string__76 = s.Serialize<string>(string__76, name: "string__76");
			string__77 = s.Serialize<string>(string__77, name: "string__77");
			string__78 = s.Serialize<string>(string__78, name: "string__78");
			string__79 = s.Serialize<string>(string__79, name: "string__79");
			string__80 = s.Serialize<string>(string__80, name: "string__80");
			string__81 = s.Serialize<string>(string__81, name: "string__81");
			string__82 = s.Serialize<string>(string__82, name: "string__82");
			string__83 = s.Serialize<string>(string__83, name: "string__83");
			string__84 = s.Serialize<string>(string__84, name: "string__84");
			Path__85 = s.SerializeObject<Path>(Path__85, name: "Path__85");
			Path__86 = s.SerializeObject<Path>(Path__86, name: "Path__86");
			Vector2__87 = s.SerializeObject<Vec2d>(Vector2__87, name: "Vector2__87");
			Vector2__88 = s.SerializeObject<Vec2d>(Vector2__88, name: "Vector2__88");
			Vector2__89 = s.SerializeObject<Vec2d>(Vector2__89, name: "Vector2__89");
			Vector2__90 = s.SerializeObject<Vec2d>(Vector2__90, name: "Vector2__90");
			Path__91 = s.SerializeObject<Path>(Path__91, name: "Path__91");
			float__92 = s.Serialize<float>(float__92, name: "float__92");
			float__93 = s.Serialize<float>(float__93, name: "float__93");
			float__94 = s.Serialize<float>(float__94, name: "float__94");
			Path__95 = s.SerializeObject<Path>(Path__95, name: "Path__95");
			Path__96 = s.SerializeObject<Path>(Path__96, name: "Path__96");
			Color__97 = s.SerializeObject<Color>(Color__97, name: "Color__97");
			Color__98 = s.SerializeObject<Color>(Color__98, name: "Color__98");
			Vector2__99 = s.SerializeObject<Vec2d>(Vector2__99, name: "Vector2__99");
			uint__100 = s.Serialize<uint>(uint__100, name: "uint__100");
			uint__101 = s.Serialize<uint>(uint__101, name: "uint__101");
			CArray_uint__102 = s.SerializeObject<CArrayP<uint>>(CArray_uint__102, name: "CArray<uint>__102");
			CArray_uint__103 = s.SerializeObject<CArrayP<uint>>(CArray_uint__103, name: "CArray<uint>__103");
			Vector2__104 = s.SerializeObject<Vec2d>(Vector2__104, name: "Vector2__104");
			Vector2__105 = s.SerializeObject<Vec2d>(Vector2__105, name: "Vector2__105");
			Vector2__106 = s.SerializeObject<Vec2d>(Vector2__106, name: "Vector2__106");
			float__107 = s.Serialize<float>(float__107, name: "float__107");
			float__108 = s.Serialize<float>(float__108, name: "float__108");
			float__109 = s.Serialize<float>(float__109, name: "float__109");
			float__110 = s.Serialize<float>(float__110, name: "float__110");
			uint__111 = s.Serialize<uint>(uint__111, name: "uint__111");
			float__112 = s.Serialize<float>(float__112, name: "float__112");
			float__113 = s.Serialize<float>(float__113, name: "float__113");
			Generic_Event__114 = s.SerializeObject<Generic<Event>>(Generic_Event__114, name: "Generic<Event>__114");
		}
		[Games(GameFlags.VH)]
		public partial class ClueTimedType : CSerializable {
			public float float__0;
			public float float__1;
			public float float__2;
			public string string__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				float__0 = s.Serialize<float>(float__0, name: "float__0");
				float__1 = s.Serialize<float>(float__1, name: "float__1");
				float__2 = s.Serialize<float>(float__2, name: "float__2");
				string__3 = s.Serialize<string>(string__3, name: "string__3");
			}
		}
		[Games(GameFlags.VH)]
		public partial class FadeConfig : CSerializable {
			public Color Color__0;
			public Color Color__1;
			public Color Color__2;
			public Color Color__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Color__0 = s.SerializeObject<Color>(Color__0, name: "Color__0");
				Color__1 = s.SerializeObject<Color>(Color__1, name: "Color__1");
				Color__2 = s.SerializeObject<Color>(Color__2, name: "Color__2");
				Color__3 = s.SerializeObject<Color>(Color__3, name: "Color__3");
			}
		}
		[Games(GameFlags.VH)]
		public partial class EpisodeConfig : CSerializable {
			public Enum_VH_0 Enum_VH_0__0;
			public StringID StringID__1;
			public StringID StringID__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
				StringID__1 = s.SerializeObject<StringID>(StringID__1, name: "StringID__1");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
			}
			public enum Enum_VH_0 {
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
				[Serialize("Value_3")] Value_3 = 3,
				[Serialize("Value_4")] Value_4 = 4,
			}
		}
		[Games(GameFlags.VH)]
		public partial class WikiMapConfig : CSerializable {
			public StringID StringID__0;
			public PathRef PathRef__1;
			public uint uint__2;
			public int int__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				PathRef__1 = s.SerializeObject<PathRef>(PathRef__1, name: "PathRef__1");
				uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
				int__3 = s.Serialize<int>(int__3, name: "int__3");
			}
		}
		[Games(GameFlags.VH)]
		public partial class LocalNotificationConfig : CSerializable {
			public uint uint__0;
			public string string__1;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				string__1 = s.Serialize<string>(string__1, name: "string__1");
			}
		}
		[Games(GameFlags.VH)]
		public partial class CharDiaMapConfig : CSerializable {
			public PathRef PathRef__0;
			public uint uint__1;
			public uint uint__2;
			public uint uint__3;
			public uint uint__4;
			public uint uint__5;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				PathRef__0 = s.SerializeObject<PathRef>(PathRef__0, name: "PathRef__0");
				uint__1 = s.Serialize<uint>(uint__1, name: "uint__1");
				uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
				uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
				uint__4 = s.Serialize<uint>(uint__4, name: "uint__4");
				uint__5 = s.Serialize<uint>(uint__5, name: "uint__5");
			}
		}
		[Games(GameFlags.VH)]
		public partial class ChardiaJumpCharConfig : CSerializable {
			public uint uint__0;
			public int int__1;
			public int int__2;
			public int int__3;
			public int int__4;
			public int int__5;
			public int int__6;
			public int int__7;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				uint__0 = s.Serialize<uint>(uint__0, name: "uint__0");
				int__1 = s.Serialize<int>(int__1, name: "int__1");
				int__2 = s.Serialize<int>(int__2, name: "int__2");
				int__3 = s.Serialize<int>(int__3, name: "int__3");
				int__4 = s.Serialize<int>(int__4, name: "int__4");
				int__5 = s.Serialize<int>(int__5, name: "int__5");
				int__6 = s.Serialize<int>(int__6, name: "int__6");
				int__7 = s.Serialize<int>(int__7, name: "int__7");
			}
		}
		[Games(GameFlags.VH)]
		public partial class LocalisedVideo : CSerializable {
			public Enum_VH_0 Enum_VH_0__0;
			public Path Path__1;
			public int int__2;
			public int int__3;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				Enum_VH_0__0 = s.Serialize<Enum_VH_0>(Enum_VH_0__0, name: "Enum_VH_0__0");
				Path__1 = s.SerializeObject<Path>(Path__1, name: "Path__1");
				int__2 = s.Serialize<int>(int__2, name: "int__2");
				int__3 = s.Serialize<int>(int__3, name: "int__3");
			}
			public enum Enum_VH_0 {
			}
		}
		[Games(GameFlags.VH)]
		public partial class MapConfig : CSerializable {
			public StringID StringID__0;
			public PathRef PathRef__1;
			public uint uint__2;
			public uint uint__3;
			public Enum_VH_0 Enum_VH_0__4;
			public uint uint__5;
			public uint uint__6;
			public uint uint__7;
			public StringID StringID__8;
			public Path Path__9;
			public W1W_GameManagerConfig_Template.FadeConfig W1W_GameManagerConfig_Template_FadeConfig__10;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				StringID__0 = s.SerializeObject<StringID>(StringID__0, name: "StringID__0");
				PathRef__1 = s.SerializeObject<PathRef>(PathRef__1, name: "PathRef__1");
				uint__2 = s.Serialize<uint>(uint__2, name: "uint__2");
				uint__3 = s.Serialize<uint>(uint__3, name: "uint__3");
				Enum_VH_0__4 = s.Serialize<Enum_VH_0>(Enum_VH_0__4, name: "Enum_VH_0__4");
				uint__5 = s.Serialize<uint>(uint__5, name: "uint__5");
				uint__6 = s.Serialize<uint>(uint__6, name: "uint__6");
				uint__7 = s.Serialize<uint>(uint__7, name: "uint__7");
				StringID__8 = s.SerializeObject<StringID>(StringID__8, name: "StringID__8");
				Path__9 = s.SerializeObject<Path>(Path__9, name: "Path__9");
				W1W_GameManagerConfig_Template_FadeConfig__10 = s.SerializeObject<W1W_GameManagerConfig_Template.FadeConfig>(W1W_GameManagerConfig_Template_FadeConfig__10, name: "W1W_GameManagerConfig_Template.FadeConfig__10");
			}
			public enum Enum_VH_0 {
				[Serialize("Value_1")] Value_1 = 1,
				[Serialize("Value_2")] Value_2 = 2,
				[Serialize("Value_3")] Value_3 = 3,
				[Serialize("Value_4")] Value_4 = 4,
			}
		}
		public override uint? ClassCRC => 0x9ED961A9;
	}
}

