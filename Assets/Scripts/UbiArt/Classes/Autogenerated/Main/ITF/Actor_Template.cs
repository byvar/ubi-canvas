using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Actor_Template : TemplatePickable {
		[Serialize("PROCEDURAL"                                  )] public bool PROCEDURAL;
		[Serialize("STARTPAUSED"                                 )] public bool STARTPAUSED;
		[Serialize("FORCEISENVIRONMENT"                          )] public bool FORCEISENVIRONMENT;
		[Serialize("FORCEALWAYSACTIVE"                           )] public bool FORCEALWAYSACTIVE;
		[Serialize("UPDATEFREQUENCE"                             )] public uint UPDATEFREQUENCE;
		[Serialize("COMPONENTS"                                  )] public CArray<Generic<ActorComponent_Template>> COMPONENTS;
		[Serialize("ANGLE"                                       )] public Angle ANGLE;
		[Serialize("SCALE"                                       )] public Vector2 SCALE;
		[Serialize("ObjectFamily"                                )] public uint ObjectFamily;
		[Serialize("scaleForced"                                 )] public Vector2 scaleForced;
		[Serialize("scaleMin"                                    )] public Vector2 scaleMin;
		[Serialize("scaleMax"                                    )] public Vector2 scaleMax;
		[Serialize("xFLIPPED"                                    )] public int xFLIPPED;
		[Serialize("zForced"                                     )] public float zForced;
		[Serialize("useZForced"                                  )] public int useZForced;
		[Serialize("archetype"                                   )] public StringID archetype;
		[Serialize("type"                                        )] public StringID type;
		[Serialize("updatetype"                                  )] public Pickable__UpdateType_O updatetype;
		[Serialize("Vector2__0"                                  )] public Vector2 Vector2__0;
		[Serialize("Vector2__1"                                  )] public Vector2 Vector2__1;
		[Serialize("Vector2__2"                                  )] public Vector2 Vector2__2;
		[Serialize("int__3"                                      )] public int int__3;
		[Serialize("int__4"                                      )] public int int__4;
		[Serialize("int__5"                                      )] public int int__5;
		[Serialize("float__6"                                    )] public float float__6;
		[Serialize("int__7"                                      )] public int int__7;
		[Serialize("StringID__8"                                 )] public StringID StringID__8;
		[Serialize("StringID__9"                                 )] public StringID StringID__9;
		[Serialize("Enum_RJR_0__10"                              )] public Enum_RJR_0 Enum_RJR_0__10;
		[Serialize("CList<Generic<TemplateActorComponent>>__11"  )] public CList<Generic<TemplateActorComponent>> CList_Generic_TemplateActorComponent__11;
		[Serialize("Vector2__12"                                 )] public Vector2 Vector2__12;
		[Serialize("Vector2__13"                                 )] public Vector2 Vector2__13;
		[Serialize("Vector2__14"                                 )] public Vector2 Vector2__14;
		[Serialize("int__15"                                     )] public int int__15;
		[Serialize("int__16"                                     )] public int int__16;
		[Serialize("int__17"                                     )] public int int__17;
		[Serialize("float__18"                                   )] public float float__18;
		[Serialize("int__19"                                     )] public int int__19;
		[Serialize("StringID__20"                                )] public StringID StringID__20;
		[Serialize("StringID__21"                                )] public StringID StringID__21;
		[Serialize("Enum_RFR_0__22"                              )] public Enum_RFR_0 Enum_RFR_0__22;
		[Serialize("CList<Generic<TemplateActorComponent>>__23"  )] public CList<Generic<TemplateActorComponent>> CList_Generic_TemplateActorComponent__23;
		[Serialize("bool__24"                                    )] public bool bool__24;
		[Serialize("bool__25"                                    )] public bool bool__25;
		[Serialize("bool__26"                                    )] public bool bool__26;
		[Serialize("bool__27"                                    )] public bool bool__27;
		[Serialize("CArray<Generic<ActorComponent_Template>>__28")] public CArray<Generic<ActorComponent_Template>> CArray_Generic_ActorComponent_Template__28;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(Vector2__0));
				SerializeField(s, nameof(Vector2__1));
				SerializeField(s, nameof(Vector2__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(float__6));
				SerializeField(s, nameof(int__7));
				SerializeField(s, nameof(StringID__8));
				SerializeField(s, nameof(StringID__9));
				SerializeField(s, nameof(Enum_RJR_0__10));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(CList_Generic_TemplateActorComponent__11));
				}
			} else if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(Vector2__12));
				SerializeField(s, nameof(Vector2__13));
				SerializeField(s, nameof(Vector2__14));
				SerializeField(s, nameof(int__15));
				SerializeField(s, nameof(int__16));
				SerializeField(s, nameof(int__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(int__19));
				SerializeField(s, nameof(StringID__20));
				SerializeField(s, nameof(StringID__21));
				SerializeField(s, nameof(Enum_RFR_0__22));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(CList_Generic_TemplateActorComponent__23));
				}
			} else if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(ANGLE));
				SerializeField(s, nameof(SCALE));
				SerializeField(s, nameof(ObjectFamily));
				SerializeField(s, nameof(scaleForced));
				SerializeField(s, nameof(scaleMin));
				SerializeField(s, nameof(scaleMax));
				SerializeField(s, nameof(xFLIPPED));
				SerializeField(s, nameof(PROCEDURAL));
				SerializeField(s, nameof(STARTPAUSED));
				SerializeField(s, nameof(zForced));
				SerializeField(s, nameof(useZForced));
				SerializeField(s, nameof(archetype));
				SerializeField(s, nameof(type));
				SerializeField(s, nameof(updatetype));
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(COMPONENTS));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(PROCEDURAL), boolAsByte: true);
				SerializeField(s, nameof(STARTPAUSED), boolAsByte: true);
				SerializeField(s, nameof(FORCEISENVIRONMENT), boolAsByte: true);
				SerializeField(s, nameof(COMPONENTS));
			} else if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(PROCEDURAL), boolAsByte: true);
				SerializeField(s, nameof(STARTPAUSED), boolAsByte: true);
				SerializeField(s, nameof(FORCEISENVIRONMENT), boolAsByte: true);
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(bool__24));
				SerializeField(s, nameof(bool__25));
				SerializeField(s, nameof(bool__26));
				SerializeField(s, nameof(bool__27));
				SerializeField(s, nameof(CArray_Generic_ActorComponent_Template__28));
			} else {
				SerializeField(s, nameof(PROCEDURAL));
				SerializeField(s, nameof(STARTPAUSED));
				SerializeField(s, nameof(FORCEISENVIRONMENT));
				SerializeField(s, nameof(FORCEALWAYSACTIVE));
				SerializeField(s, nameof(UPDATEFREQUENCE));
				SerializeField(s, nameof(COMPONENTS));
			}
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Pickable__UpdateType_O {
			[Serialize("Pickable::UpdateType_OnlyIfVisible"   )] nlyIfVisible = 0,
			[Serialize("Pickable::UpdateType_OffscreenAllowed")] ffscreenAllowed = 1,
		}
		public override uint? ClassCRC => 0x1B857BCE;
	}
}

