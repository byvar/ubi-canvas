using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BezierTreeAIComponent_Template : GraphicComponent_Template {
		[Serialize("lockFirstNode"                   )] public int lockFirstNode;
		[Serialize("lockLastNodeScale"               )] public int lockLastNodeScale;
		[Serialize("attachBone"                      )] public StringID attachBone;
		[Serialize("gameMaterial"                    )] public Path gameMaterial;
		[Serialize("polylineMode"                    )] public PolylineMode polylineMode;
		[Serialize("polylineBeginLength"             )] public float polylineBeginLength;
		[Serialize("polylineEndLength"               )] public float polylineEndLength;
		[Serialize("polylineBeginWidth"              )] public float polylineBeginWidth;
		[Serialize("polylineMidWidth"                )] public float polylineMidWidth;
		[Serialize("polylineEndWidth"                )] public float polylineEndWidth;
		[Serialize("polylineStartOffset"             )] public float polylineStartOffset;
		[Serialize("polylineEndOffset"               )] public float polylineEndOffset;
		[Serialize("polylineTessellationLength"      )] public float polylineTessellationLength;
		[Serialize("bezierRenderer"                  )] public Placeholder bezierRenderer;
		[Serialize("mainSpriteIndex"                 )] public uint mainSpriteIndex;
		[Serialize("startSpriteIndex"                )] public uint startSpriteIndex;
		[Serialize("startSpriteLength"               )] public float startSpriteLength;
		[Serialize("endSpriteIndex"                  )] public uint endSpriteIndex;
		[Serialize("endSpriteLength"                 )] public float endSpriteLength;
		[Serialize("uvStretch"                       )] public int uvStretch;
		[Serialize("uvAttachToHead"                  )] public int uvAttachToHead;
		[Serialize("uvScrollSpeed"                   )] public float uvScrollSpeed;
		[Serialize("tweenInterpreter"                )] public Placeholder tweenInterpreter;
		[Serialize("headActor"                       )] public Path headActor;
		[Serialize("headAttachOffset"                )] public float headAttachOffset;
		[Serialize("spawnables"                      )] public Placeholder spawnables;
		[Serialize("fx"                              )] public StringID fx;
		[Serialize("ai"                              )] public Placeholder ai;
		[Serialize("polylineDisableOnTransition"     )] public int polylineDisableOnTransition;
		[Serialize("int__0"                          )] public int int__0;
		[Serialize("int__1"                          )] public int int__1;
		[Serialize("StringID__2"                     )] public StringID StringID__2;
		[Serialize("Path__3"                         )] public Path Path__3;
		[Serialize("Enum_RJR_0__4"                   )] public Enum_RJR_0 Enum_RJR_0__4;
		[Serialize("float__5"                        )] public float float__5;
		[Serialize("float__6"                        )] public float float__6;
		[Serialize("float__7"                        )] public float float__7;
		[Serialize("float__8"                        )] public float float__8;
		[Serialize("float__9"                        )] public float float__9;
		[Serialize("float__10"                       )] public float float__10;
		[Serialize("float__11"                       )] public float float__11;
		[Serialize("float__12"                       )] public float float__12;
		[Serialize("BezierCurveRenderer_Template__13")] public BezierCurveRenderer_Template BezierCurveRenderer_Template__13;
		[Serialize("uint__14"                        )] public uint uint__14;
		[Serialize("uint__15"                        )] public uint uint__15;
		[Serialize("float__16"                       )] public float float__16;
		[Serialize("uint__17"                        )] public uint uint__17;
		[Serialize("float__18"                       )] public float float__18;
		[Serialize("int__19"                         )] public int int__19;
		[Serialize("int__20"                         )] public int int__20;
		[Serialize("float__21"                       )] public float float__21;
		[Serialize("TweenInterpreter_Template__22"   )] public TweenInterpreter_Template TweenInterpreter_Template__22;
		[Serialize("Path__23"                        )] public Path Path__23;
		[Serialize("float__24"                       )] public float float__24;
		[Serialize("CList<Spawnable>__25"            )] public CList<Spawnable> CList_Spawnable__25;
		[Serialize("StringID__26"                    )] public StringID StringID__26;
		[Serialize("int__27"                         )] public int int__27;
		[Serialize("int__28"                         )] public int int__28;
		[Serialize("int__29"                         )] public int int__29;
		[Serialize("StringID__30"                    )] public StringID StringID__30;
		[Serialize("Path__31"                        )] public Path Path__31;
		[Serialize("Enum_RFR_0__32"                  )] public Enum_RFR_0 Enum_RFR_0__32;
		[Serialize("float__33"                       )] public float float__33;
		[Serialize("float__34"                       )] public float float__34;
		[Serialize("float__35"                       )] public float float__35;
		[Serialize("float__36"                       )] public float float__36;
		[Serialize("float__37"                       )] public float float__37;
		[Serialize("float__38"                       )] public float float__38;
		[Serialize("float__39"                       )] public float float__39;
		[Serialize("float__40"                       )] public float float__40;
		[Serialize("BezierCurveRenderer_Template__41")] public BezierCurveRenderer_Template BezierCurveRenderer_Template__41;
		[Serialize("uint__42"                        )] public uint uint__42;
		[Serialize("uint__43"                        )] public uint uint__43;
		[Serialize("float__44"                       )] public float float__44;
		[Serialize("uint__45"                        )] public uint uint__45;
		[Serialize("float__46"                       )] public float float__46;
		[Serialize("int__47"                         )] public int int__47;
		[Serialize("int__48"                         )] public int int__48;
		[Serialize("float__49"                       )] public float float__49;
		[Serialize("TweenInterpreter_Template__50"   )] public TweenInterpreter_Template TweenInterpreter_Template__50;
		[Serialize("Path__51"                        )] public Path Path__51;
		[Serialize("float__52"                       )] public float float__52;
		[Serialize("CList<Spawnable>__53"            )] public CList<Spawnable> CList_Spawnable__53;
		[Serialize("StringID__54"                    )] public StringID StringID__54;
		[Serialize("int__55"                         )] public int int__55;
		[Serialize("int__56"                         )] public int int__56;
		[Serialize("int__57"                         )] public int int__57;
		[Serialize("float__58"                       )] public float float__58;
		[Serialize("float__59"                       )] public float float__59;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(int__28));
				SerializeField(s, nameof(int__29));
				SerializeField(s, nameof(StringID__30));
				SerializeField(s, nameof(Path__31));
				SerializeField(s, nameof(Enum_RFR_0__32));
				SerializeField(s, nameof(float__33));
				SerializeField(s, nameof(float__34));
				SerializeField(s, nameof(float__35));
				SerializeField(s, nameof(float__36));
				SerializeField(s, nameof(float__37));
				SerializeField(s, nameof(float__38));
				SerializeField(s, nameof(float__39));
				SerializeField(s, nameof(float__40));
				SerializeField(s, nameof(BezierCurveRenderer_Template__41));
				SerializeField(s, nameof(uint__42));
				SerializeField(s, nameof(uint__43));
				SerializeField(s, nameof(float__44));
				SerializeField(s, nameof(uint__45));
				SerializeField(s, nameof(float__46));
				SerializeField(s, nameof(int__47));
				SerializeField(s, nameof(int__48));
				SerializeField(s, nameof(float__49));
				SerializeField(s, nameof(TweenInterpreter_Template__50));
				SerializeField(s, nameof(Path__51));
				SerializeField(s, nameof(float__52));
				SerializeField(s, nameof(CList_Spawnable__53));
				SerializeField(s, nameof(StringID__54));
				SerializeField(s, nameof(int__55));
				SerializeField(s, nameof(int__56));
				SerializeField(s, nameof(int__57));
				SerializeField(s, nameof(float__58));
				SerializeField(s, nameof(float__59));
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(lockFirstNode));
				SerializeField(s, nameof(lockLastNodeScale));
				SerializeField(s, nameof(attachBone));
				SerializeField(s, nameof(gameMaterial));
				SerializeField(s, nameof(polylineMode));
				SerializeField(s, nameof(polylineBeginLength));
				SerializeField(s, nameof(polylineEndLength));
				SerializeField(s, nameof(polylineBeginWidth));
				SerializeField(s, nameof(polylineMidWidth));
				SerializeField(s, nameof(polylineEndWidth));
				SerializeField(s, nameof(polylineStartOffset));
				SerializeField(s, nameof(polylineEndOffset));
				SerializeField(s, nameof(polylineTessellationLength));
				SerializeField(s, nameof(bezierRenderer));
				SerializeField(s, nameof(mainSpriteIndex));
				SerializeField(s, nameof(startSpriteIndex));
				SerializeField(s, nameof(startSpriteLength));
				SerializeField(s, nameof(endSpriteIndex));
				SerializeField(s, nameof(endSpriteLength));
				SerializeField(s, nameof(uvStretch));
				SerializeField(s, nameof(uvAttachToHead));
				SerializeField(s, nameof(uvScrollSpeed));
				SerializeField(s, nameof(tweenInterpreter));
				SerializeField(s, nameof(headActor));
				SerializeField(s, nameof(headAttachOffset));
				SerializeField(s, nameof(spawnables));
				SerializeField(s, nameof(fx));
				SerializeField(s, nameof(ai));
				SerializeField(s, nameof(polylineDisableOnTransition));
			} else {
				SerializeField(s, nameof(int__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(StringID__2));
				SerializeField(s, nameof(Path__3));
				SerializeField(s, nameof(Enum_RJR_0__4));
				SerializeField(s, nameof(float__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(float__7));
				SerializeField(s, nameof(float__8));
				SerializeField(s, nameof(float__9));
				SerializeField(s, nameof(float__10));
				SerializeField(s, nameof(float__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(BezierCurveRenderer_Template__13));
				SerializeField(s, nameof(uint__14));
				SerializeField(s, nameof(uint__15));
				SerializeField(s, nameof(float__16));
				SerializeField(s, nameof(uint__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(int__19));
				SerializeField(s, nameof(int__20));
				SerializeField(s, nameof(float__21));
				SerializeField(s, nameof(TweenInterpreter_Template__22));
				SerializeField(s, nameof(Path__23));
				SerializeField(s, nameof(float__24));
				SerializeField(s, nameof(CList_Spawnable__25));
				SerializeField(s, nameof(StringID__26));
				SerializeField(s, nameof(int__27));
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

