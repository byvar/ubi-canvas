using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class FXControl : CSerializable {
		[Serialize("name"                 )] public StringID name;
		[Serialize("fxStopOnEndAnim"      )] public bool fxStopOnEndAnim;
		[Serialize("fxKillOnEndAnim"      )] public bool fxKillOnEndAnim;
		[Serialize("fxPlayOnce"           )] public bool fxPlayOnce;
		[Serialize("pickColorFromFreeze"  )] public bool pickColorFromFreeze;
		[Serialize("fxInstanceOnce"       )] public bool fxInstanceOnce;
		[Serialize("fxEmitFromBase"       )] public bool fxEmitFromBase;
		[Serialize("fxUseActorSpeed"      )] public bool fxUseActorSpeed;
		[Serialize("fxUseActorOrientation")] public bool fxUseActorOrientation;
		[Serialize("fxUseActorAlpha"      )] public bool fxUseActorAlpha;
		[Serialize("fxBoneName"           )] public StringID fxBoneName;
		[Serialize("fxUseBoneOrientation" )] public BOOL fxUseBoneOrientation;
		[Serialize("sounds"               )] public CList<StringID> sounds;
		[Serialize("particles"            )] public CList<StringID> particles;
		[Serialize("fluids"               )] public CList<StringID> fluids;
		[Serialize("music"                )] public StringID music;
		[Serialize("busMix"               )] public StringID busMix;
		[Serialize("owner"                )] public StringID owner;
		[Serialize("busMixActivate"       )] public bool busMixActivate;
		[Serialize("fxDontStopSound"      )] public bool fxDontStopSound;
		[Serialize("fxAttach"             )] public bool fxAttach;
		[Serialize("attractor"            )] public ObjectPath attractor;
		[Serialize("zOffset"              )] public float zOffset;
		[Serialize("StringID__0"          )] public StringID StringID__0;
		[Serialize("int__1"               )] public int int__1;
		[Serialize("int__2"               )] public int int__2;
		[Serialize("int__3"               )] public int int__3;
		[Serialize("int__4"               )] public int int__4;
		[Serialize("int__5"               )] public int int__5;
		[Serialize("StringID__6"          )] public StringID StringID__6;
		[Serialize("int__7"               )] public int int__7;
		[Serialize("StringID__8"          )] public StringID StringID__8;
		[Serialize("StringID__9"          )] public StringID StringID__9;
		[Serialize("int__10"              )] public int int__10;
		[Serialize("CList<StringID>__11"  )] public CList<StringID> CList_StringID__11;
		[Serialize("CList<StringID>__12"  )] public CList<StringID> CList_StringID__12;
		[Serialize("StringID__13"         )] public StringID StringID__13;
		[Serialize("StringID__14"         )] public StringID StringID__14;
		[Serialize("bool__15"             )] public bool bool__15;
		[Serialize("bool__16"             )] public bool bool__16;
		[Serialize("bool__17"             )] public bool bool__17;
		[Serialize("bool__18"             )] public bool bool__18;
		[Serialize("bool__19"             )] public bool bool__19;
		[Serialize("bool__20"             )] public bool bool__20;
		[Serialize("bool__21"             )] public bool bool__21;
		[Serialize("bool__22"             )] public bool bool__22;
		[Serialize("StringID__23"         )] public StringID StringID__23;
		[Serialize("Enum_VH_0__24"        )] public Enum_VH_0 Enum_VH_0__24;
		[Serialize("CArray<StringID>__25" )] public CArray<StringID> CArray_StringID__25;
		[Serialize("CArray<StringID>__26" )] public CArray<StringID> CArray_StringID__26;
		[Serialize("CArray<StringID>__27" )] public CArray<StringID> CArray_StringID__27;
		[Serialize("StringID__28"         )] public StringID StringID__28;
		[Serialize("StringID__29"         )] public StringID StringID__29;
		[Serialize("StringID__30"         )] public StringID StringID__30;
		[Serialize("bool__31"             )] public bool bool__31;
		[Serialize("bool__32"             )] public bool bool__32;
		[Serialize("bool__33"             )] public bool bool__33;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(int__1));
				SerializeField(s, nameof(int__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(StringID__6));
				SerializeField(s, nameof(int__7));
				SerializeField(s, nameof(StringID__8));
				SerializeField(s, nameof(StringID__9));
				SerializeField(s, nameof(int__10));
				SerializeField(s, nameof(CList_StringID__11));
				SerializeField(s, nameof(CList_StringID__12));
				SerializeField(s, nameof(StringID__13));
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(StringID__14));
				SerializeField(s, nameof(bool__15));
				SerializeField(s, nameof(bool__16));
				SerializeField(s, nameof(bool__17));
				SerializeField(s, nameof(bool__18));
				SerializeField(s, nameof(bool__19));
				SerializeField(s, nameof(bool__20));
				SerializeField(s, nameof(bool__21));
				SerializeField(s, nameof(bool__22));
				SerializeField(s, nameof(StringID__23));
				SerializeField(s, nameof(Enum_VH_0__24));
				SerializeField(s, nameof(CArray_StringID__25));
				SerializeField(s, nameof(CArray_StringID__26));
				SerializeField(s, nameof(CArray_StringID__27));
				SerializeField(s, nameof(StringID__28));
				SerializeField(s, nameof(StringID__29));
				SerializeField(s, nameof(StringID__30));
				SerializeField(s, nameof(bool__31));
				SerializeField(s, nameof(bool__32));
				SerializeField(s, nameof(bool__33));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(fxStopOnEndAnim));
				SerializeField(s, nameof(fxKillOnEndAnim));
				SerializeField(s, nameof(fxPlayOnce));
				SerializeField(s, nameof(pickColorFromFreeze));
				SerializeField(s, nameof(fxInstanceOnce));
				SerializeField(s, nameof(fxEmitFromBase));
				SerializeField(s, nameof(fxUseActorSpeed));
				SerializeField(s, nameof(fxUseActorOrientation));
				SerializeField(s, nameof(fxUseActorAlpha));
				SerializeField(s, nameof(fxBoneName));
				SerializeField(s, nameof(fxUseBoneOrientation));
				SerializeField(s, nameof(sounds));
				SerializeField(s, nameof(particles));
				SerializeField(s, nameof(fluids));
				SerializeField(s, nameof(music));
				SerializeField(s, nameof(busMix));
				SerializeField(s, nameof(owner));
				SerializeField(s, nameof(busMixActivate));
				SerializeField(s, nameof(fxDontStopSound));
				SerializeField(s, nameof(fxAttach));
				SerializeField(s, nameof(attractor));
				SerializeField(s, nameof(zOffset));
			}
		}
		public enum BOOL {
			[Serialize("BOOL_false")] _false = 0,
			[Serialize("BOOL_true" )] _true = 1,
			[Serialize("BOOL_cond" )] cond = 2,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
	}
}

