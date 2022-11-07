namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_BezierTreeAIComponent_Template : GraphicComponent_Template {
		public int lockFirstNode;
		public int lockLastNodeScale;
		public StringID attachBone;
		public Path gameMaterial;
		public PolylineMode polylineMode;
		public float polylineBeginLength;
		public float polylineEndLength;
		public float polylineBeginWidth;
		public float polylineMidWidth;
		public float polylineEndWidth;
		public float polylineStartOffset;
		public float polylineEndOffset;
		public float polylineTessellationLength;
		public Placeholder bezierRenderer;
		public uint mainSpriteIndex;
		public uint startSpriteIndex;
		public float startSpriteLength;
		public uint endSpriteIndex;
		public float endSpriteLength;
		public int uvStretch;
		public int uvAttachToHead;
		public float uvScrollSpeed;
		public Placeholder tweenInterpreter;
		public Path headActor;
		public float headAttachOffset;
		public Placeholder spawnables;
		public StringID fx;
		public Placeholder ai;
		public int polylineDisableOnTransition;
		public int int__0;
		public int int__1;
		public StringID StringID__2;
		public Path Path__3;
		public Enum_RJR_0 Enum_RJR_0__4;
		public float float__5;
		public float float__6;
		public float float__7;
		public float float__8;
		public float float__9;
		public float float__10;
		public float float__11;
		public float float__12;
		public BezierCurveRenderer_Template BezierCurveRenderer_Template__13;
		public uint uint__14;
		public uint uint__15;
		public float float__16;
		public uint uint__17;
		public float float__18;
		public int int__19;
		public int int__20;
		public float float__21;
		public TweenInterpreter_Template TweenInterpreter_Template__22;
		public Path Path__23;
		public float float__24;
		public CListO<Spawnable> CList_Spawnable__25;
		public StringID StringID__26;
		public int int__27;
		public int int__28;
		public int int__29;
		public StringID StringID__30;
		public Path Path__31;
		public Enum_RFR_0 Enum_RFR_0__32;
		public float float__33;
		public float float__34;
		public float float__35;
		public float float__36;
		public float float__37;
		public float float__38;
		public float float__39;
		public float float__40;
		public BezierCurveRenderer_Template BezierCurveRenderer_Template__41;
		public uint uint__42;
		public uint uint__43;
		public float float__44;
		public uint uint__45;
		public float float__46;
		public int int__47;
		public int int__48;
		public float float__49;
		public TweenInterpreter_Template TweenInterpreter_Template__50;
		public Path Path__51;
		public float float__52;
		public CListO<Spawnable> CList_Spawnable__53;
		public StringID StringID__54;
		public int int__55;
		public int int__56;
		public int int__57;
		public float float__58;
		public float float__59;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RFR) {
				int__28 = s.Serialize<int>(int__28, name: "int__28");
				int__29 = s.Serialize<int>(int__29, name: "int__29");
				StringID__30 = s.SerializeObject<StringID>(StringID__30, name: "StringID__30");
				Path__31 = s.SerializeObject<Path>(Path__31, name: "Path__31");
				Enum_RFR_0__32 = s.Serialize<Enum_RFR_0>(Enum_RFR_0__32, name: "Enum_RFR_0__32");
				float__33 = s.Serialize<float>(float__33, name: "float__33");
				float__34 = s.Serialize<float>(float__34, name: "float__34");
				float__35 = s.Serialize<float>(float__35, name: "float__35");
				float__36 = s.Serialize<float>(float__36, name: "float__36");
				float__37 = s.Serialize<float>(float__37, name: "float__37");
				float__38 = s.Serialize<float>(float__38, name: "float__38");
				float__39 = s.Serialize<float>(float__39, name: "float__39");
				float__40 = s.Serialize<float>(float__40, name: "float__40");
				BezierCurveRenderer_Template__41 = s.SerializeObject<BezierCurveRenderer_Template>(BezierCurveRenderer_Template__41, name: "BezierCurveRenderer_Template__41");
				uint__42 = s.Serialize<uint>(uint__42, name: "uint__42");
				uint__43 = s.Serialize<uint>(uint__43, name: "uint__43");
				float__44 = s.Serialize<float>(float__44, name: "float__44");
				uint__45 = s.Serialize<uint>(uint__45, name: "uint__45");
				float__46 = s.Serialize<float>(float__46, name: "float__46");
				int__47 = s.Serialize<int>(int__47, name: "int__47");
				int__48 = s.Serialize<int>(int__48, name: "int__48");
				float__49 = s.Serialize<float>(float__49, name: "float__49");
				TweenInterpreter_Template__50 = s.SerializeObject<TweenInterpreter_Template>(TweenInterpreter_Template__50, name: "TweenInterpreter_Template__50");
				Path__51 = s.SerializeObject<Path>(Path__51, name: "Path__51");
				float__52 = s.Serialize<float>(float__52, name: "float__52");
				CList_Spawnable__53 = s.SerializeObject<CListO<Spawnable>>(CList_Spawnable__53, name: "CList<Spawnable>__53");
				StringID__54 = s.SerializeObject<StringID>(StringID__54, name: "StringID__54");
				int__55 = s.Serialize<int>(int__55, name: "int__55");
				int__56 = s.Serialize<int>(int__56, name: "int__56");
				int__57 = s.Serialize<int>(int__57, name: "int__57");
				float__58 = s.Serialize<float>(float__58, name: "float__58");
				float__59 = s.Serialize<float>(float__59, name: "float__59");
			} else if (s.Settings.game == Settings.Game.RO) {
				lockFirstNode = s.Serialize<int>(lockFirstNode, name: "lockFirstNode");
				lockLastNodeScale = s.Serialize<int>(lockLastNodeScale, name: "lockLastNodeScale");
				attachBone = s.SerializeObject<StringID>(attachBone, name: "attachBone");
				gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
				polylineMode = s.Serialize<PolylineMode>(polylineMode, name: "polylineMode");
				polylineBeginLength = s.Serialize<float>(polylineBeginLength, name: "polylineBeginLength");
				polylineEndLength = s.Serialize<float>(polylineEndLength, name: "polylineEndLength");
				polylineBeginWidth = s.Serialize<float>(polylineBeginWidth, name: "polylineBeginWidth");
				polylineMidWidth = s.Serialize<float>(polylineMidWidth, name: "polylineMidWidth");
				polylineEndWidth = s.Serialize<float>(polylineEndWidth, name: "polylineEndWidth");
				polylineStartOffset = s.Serialize<float>(polylineStartOffset, name: "polylineStartOffset");
				polylineEndOffset = s.Serialize<float>(polylineEndOffset, name: "polylineEndOffset");
				polylineTessellationLength = s.Serialize<float>(polylineTessellationLength, name: "polylineTessellationLength");
				bezierRenderer = s.SerializeObject<Placeholder>(bezierRenderer, name: "bezierRenderer");
				mainSpriteIndex = s.Serialize<uint>(mainSpriteIndex, name: "mainSpriteIndex");
				startSpriteIndex = s.Serialize<uint>(startSpriteIndex, name: "startSpriteIndex");
				startSpriteLength = s.Serialize<float>(startSpriteLength, name: "startSpriteLength");
				endSpriteIndex = s.Serialize<uint>(endSpriteIndex, name: "endSpriteIndex");
				endSpriteLength = s.Serialize<float>(endSpriteLength, name: "endSpriteLength");
				uvStretch = s.Serialize<int>(uvStretch, name: "uvStretch");
				uvAttachToHead = s.Serialize<int>(uvAttachToHead, name: "uvAttachToHead");
				uvScrollSpeed = s.Serialize<float>(uvScrollSpeed, name: "uvScrollSpeed");
				tweenInterpreter = s.SerializeObject<Placeholder>(tweenInterpreter, name: "tweenInterpreter");
				headActor = s.SerializeObject<Path>(headActor, name: "headActor");
				headAttachOffset = s.Serialize<float>(headAttachOffset, name: "headAttachOffset");
				spawnables = s.SerializeObject<Placeholder>(spawnables, name: "spawnables");
				fx = s.SerializeObject<StringID>(fx, name: "fx");
				ai = s.SerializeObject<Placeholder>(ai, name: "ai");
				polylineDisableOnTransition = s.Serialize<int>(polylineDisableOnTransition, name: "polylineDisableOnTransition");
			} else {
				int__0 = s.Serialize<int>(int__0, name: "int__0");
				int__1 = s.Serialize<int>(int__1, name: "int__1");
				StringID__2 = s.SerializeObject<StringID>(StringID__2, name: "StringID__2");
				Path__3 = s.SerializeObject<Path>(Path__3, name: "Path__3");
				Enum_RJR_0__4 = s.Serialize<Enum_RJR_0>(Enum_RJR_0__4, name: "Enum_RJR_0__4");
				float__5 = s.Serialize<float>(float__5, name: "float__5");
				float__6 = s.Serialize<float>(float__6, name: "float__6");
				float__7 = s.Serialize<float>(float__7, name: "float__7");
				float__8 = s.Serialize<float>(float__8, name: "float__8");
				float__9 = s.Serialize<float>(float__9, name: "float__9");
				float__10 = s.Serialize<float>(float__10, name: "float__10");
				float__11 = s.Serialize<float>(float__11, name: "float__11");
				float__12 = s.Serialize<float>(float__12, name: "float__12");
				BezierCurveRenderer_Template__13 = s.SerializeObject<BezierCurveRenderer_Template>(BezierCurveRenderer_Template__13, name: "BezierCurveRenderer_Template__13");
				uint__14 = s.Serialize<uint>(uint__14, name: "uint__14");
				uint__15 = s.Serialize<uint>(uint__15, name: "uint__15");
				float__16 = s.Serialize<float>(float__16, name: "float__16");
				uint__17 = s.Serialize<uint>(uint__17, name: "uint__17");
				float__18 = s.Serialize<float>(float__18, name: "float__18");
				int__19 = s.Serialize<int>(int__19, name: "int__19");
				int__20 = s.Serialize<int>(int__20, name: "int__20");
				float__21 = s.Serialize<float>(float__21, name: "float__21");
				TweenInterpreter_Template__22 = s.SerializeObject<TweenInterpreter_Template>(TweenInterpreter_Template__22, name: "TweenInterpreter_Template__22");
				Path__23 = s.SerializeObject<Path>(Path__23, name: "Path__23");
				float__24 = s.Serialize<float>(float__24, name: "float__24");
				CList_Spawnable__25 = s.SerializeObject<CListO<Spawnable>>(CList_Spawnable__25, name: "CList<Spawnable>__25");
				StringID__26 = s.SerializeObject<StringID>(StringID__26, name: "StringID__26");
				int__27 = s.Serialize<int>(int__27, name: "int__27");
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public enum PolylineMode {
			[Serialize("PolylineMode_None"       )] None = 0,
			[Serialize("PolylineMode_Left"       )] Left = 1,
			[Serialize("PolylineMode_Right"      )] Right = 2,
			[Serialize("PolylineMode_DoubleSided")] DoubleSided = 3,
		}
		public override uint? ClassCRC => 0x4CAD7A22;
	}
}

