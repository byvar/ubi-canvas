namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_FirePatchAIComponent_Template : GraphicComponent_Template {
		public float float__0;
		public float float__1;
		public float float__2;
		public float float__3;
		public float float__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public uint uint__10;
		public uint uint__11;
		public float float__12;
		public float float__13;
		public float float__14;
		public float float__15;
		public uint uint__16;
		public uint uint__17;
		public uint uint__18;
		public uint uint__19;
		public uint uint__20;
		public uint uint__21;
		public uint uint__22;
		public uint uint__23;
		public uint uint__24;
		public uint uint__25;
		public uint uint__26;
		public uint uint__27;
		public bool bool__28;
		public float float__29;
		public float float__30;
		public GFXMaterialSerializable GFXMaterialSerializable__31;
		public GFXMaterialSerializable GFXMaterialSerializable__32;
		public float float__33;
		public uint uint__34;
		public float float__35;
		public float float__36;
		public float float__37;
		public float float__38;
		public float float__39;
		public float float__40;
		public float float__41;
		public float float__42;
		public float float__43;
		public float float__44;
		public uint uint__45;
		public float float__46;
		public StringID StringID__47;
		public StringID StringID__48;
		public bool bool__49;
		public bool bool__50;
		public bool bool__51;
		public uint uint__52;
		public uint uint__53;
		public bool bool__54;
		public bool bool__55;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			float__0 = s.Serialize<float>(float__0, name: "float__0");
			float__1 = s.Serialize<float>(float__1, name: "float__1");
			float__2 = s.Serialize<float>(float__2, name: "float__2");
			float__3 = s.Serialize<float>(float__3, name: "float__3");
			float__4 = s.Serialize<float>(float__4, name: "float__4");
			float__5 = s.Serialize<float>(float__5, name: "float__5");
			float__6 = s.Serialize<float>(float__6, name: "float__6");
			float__7 = s.Serialize<float>(float__7, name: "float__7");
			float__8 = s.Serialize<float>(float__8, name: "float__8");
			float__9 = s.Serialize<float>(float__9, name: "float__9");
			uint__10 = s.Serialize<uint>(uint__10, name: "uint__10");
			uint__11 = s.Serialize<uint>(uint__11, name: "uint__11");
			float__12 = s.Serialize<float>(float__12, name: "float__12");
			float__13 = s.Serialize<float>(float__13, name: "float__13");
			float__14 = s.Serialize<float>(float__14, name: "float__14");
			float__15 = s.Serialize<float>(float__15, name: "float__15");
			uint__16 = s.Serialize<uint>(uint__16, name: "uint__16");
			uint__17 = s.Serialize<uint>(uint__17, name: "uint__17");
			uint__18 = s.Serialize<uint>(uint__18, name: "uint__18");
			uint__19 = s.Serialize<uint>(uint__19, name: "uint__19");
			uint__20 = s.Serialize<uint>(uint__20, name: "uint__20");
			uint__21 = s.Serialize<uint>(uint__21, name: "uint__21");
			uint__22 = s.Serialize<uint>(uint__22, name: "uint__22");
			uint__23 = s.Serialize<uint>(uint__23, name: "uint__23");
			uint__24 = s.Serialize<uint>(uint__24, name: "uint__24");
			uint__25 = s.Serialize<uint>(uint__25, name: "uint__25");
			uint__26 = s.Serialize<uint>(uint__26, name: "uint__26");
			uint__27 = s.Serialize<uint>(uint__27, name: "uint__27");
			bool__28 = s.Serialize<bool>(bool__28, name: "bool__28");
			float__29 = s.Serialize<float>(float__29, name: "float__29");
			float__30 = s.Serialize<float>(float__30, name: "float__30");
			GFXMaterialSerializable__31 = s.SerializeObject<GFXMaterialSerializable>(GFXMaterialSerializable__31, name: "GFXMaterialSerializable__31");
			GFXMaterialSerializable__32 = s.SerializeObject<GFXMaterialSerializable>(GFXMaterialSerializable__32, name: "GFXMaterialSerializable__32");
			float__33 = s.Serialize<float>(float__33, name: "float__33");
			uint__34 = s.Serialize<uint>(uint__34, name: "uint__34");
			float__35 = s.Serialize<float>(float__35, name: "float__35");
			float__36 = s.Serialize<float>(float__36, name: "float__36");
			float__37 = s.Serialize<float>(float__37, name: "float__37");
			float__38 = s.Serialize<float>(float__38, name: "float__38");
			float__39 = s.Serialize<float>(float__39, name: "float__39");
			float__40 = s.Serialize<float>(float__40, name: "float__40");
			float__41 = s.Serialize<float>(float__41, name: "float__41");
			float__42 = s.Serialize<float>(float__42, name: "float__42");
			float__43 = s.Serialize<float>(float__43, name: "float__43");
			float__44 = s.Serialize<float>(float__44, name: "float__44");
			uint__45 = s.Serialize<uint>(uint__45, name: "uint__45");
			float__46 = s.Serialize<float>(float__46, name: "float__46");
			StringID__47 = s.SerializeObject<StringID>(StringID__47, name: "StringID__47");
			StringID__48 = s.SerializeObject<StringID>(StringID__48, name: "StringID__48");
			bool__49 = s.Serialize<bool>(bool__49, name: "bool__49");
			bool__50 = s.Serialize<bool>(bool__50, name: "bool__50");
			bool__51 = s.Serialize<bool>(bool__51, name: "bool__51");
			uint__52 = s.Serialize<uint>(uint__52, name: "uint__52");
			uint__53 = s.Serialize<uint>(uint__53, name: "uint__53");
			bool__54 = s.Serialize<bool>(bool__54, name: "bool__54");
			bool__55 = s.Serialize<bool>(bool__55, name: "bool__55");
		}
		public override uint? ClassCRC => 0x8A65CD69;
	}
}

