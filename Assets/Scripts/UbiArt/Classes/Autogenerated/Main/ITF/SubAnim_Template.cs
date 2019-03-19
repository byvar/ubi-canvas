using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class SubAnim_Template : CSerializable {
		[Serialize("friendlyName"   )] public StringID friendlyName;
		[Serialize("name"           )] public Path name;
		[Serialize("playRate"       )] public float playRate;
		[Serialize("loop"           )] public bool loop;
		[Serialize("flags"          )] public uint flags;
		[Serialize("useRootRotation")] public bool useRootRotation;
		[Serialize("reverse"        )] public bool reverse;
		[Serialize("defaultFlip"    )] public bool defaultFlip;
		[Serialize("markerStart"    )] public StringID markerStart;
		[Serialize("markerStop"     )] public StringID markerStop;
		[Serialize("procedural"     )] public bool procedural;
		[Serialize("sync"           )] public bool sync;
		[Serialize("syncEighthNote" )] public uint syncEighthNote;
		[Serialize("syncRatio"      )] public float syncRatio;
		[Serialize("allowSyncOffset")] public bool allowSyncOffset;
		[Serialize("shadowMul"      )] public float shadowMul;
		[Serialize("metronome"      )] public METRONOME_TYPE metronome;
		[Serialize("forceZOffset"   )] public bool forceZOffset;
		[Serialize("useRootFlip"    )] public bool useRootFlip;
		[Serialize("StringID__0"    )] public StringID StringID__0;
		[Serialize("Path__1"        )] public Path Path__1;
		[Serialize("float__2"       )] public float float__2;
		[Serialize("int__3"         )] public int int__3;
		[Serialize("int__4"         )] public int int__4;
		[Serialize("int__5"         )] public int int__5;
		[Serialize("int__6"         )] public int int__6;
		[Serialize("StringID__7"    )] public StringID StringID__7;
		[Serialize("StringID__8"    )] public StringID StringID__8;
		[Serialize("int__9"         )] public int int__9;
		[Serialize("int__10"        )] public int int__10;
		[Serialize("uint__11"       )] public uint uint__11;
		[Serialize("float__12"      )] public float float__12;
		[Serialize("int__13"        )] public int int__13;
		[Serialize("float__14"      )] public float float__14;
		[Serialize("Enum_RJR_0__15" )] public Enum_RJR_0 Enum_RJR_0__15;
		[Serialize("StringID__16"   )] public StringID StringID__16;
		[Serialize("Path__17"       )] public Path Path__17;
		[Serialize("float__18"      )] public float float__18;
		[Serialize("int__19"        )] public int int__19;
		[Serialize("int__20"        )] public int int__20;
		[Serialize("int__21"        )] public int int__21;
		[Serialize("int__22"        )] public int int__22;
		[Serialize("StringID__23"   )] public StringID StringID__23;
		[Serialize("StringID__24"   )] public StringID StringID__24;
		[Serialize("int__25"        )] public int int__25;
		[Serialize("int__26"        )] public int int__26;
		[Serialize("uint__27"       )] public uint uint__27;
		[Serialize("float__28"      )] public float float__28;
		[Serialize("int__29"        )] public int int__29;
		[Serialize("float__30"      )] public float float__30;
		[Serialize("Enum_RFR_0__31" )] public Enum_RFR_0 Enum_RFR_0__31;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR) {
				SerializeField(s, nameof(StringID__0));
				SerializeField(s, nameof(Path__1));
				SerializeField(s, nameof(float__2));
				SerializeField(s, nameof(int__3));
				SerializeField(s, nameof(int__4));
				SerializeField(s, nameof(int__5));
				SerializeField(s, nameof(int__6));
				SerializeField(s, nameof(StringID__7));
				SerializeField(s, nameof(StringID__8));
				SerializeField(s, nameof(int__9));
				SerializeField(s, nameof(int__10));
				SerializeField(s, nameof(uint__11));
				SerializeField(s, nameof(float__12));
				SerializeField(s, nameof(int__13));
				SerializeField(s, nameof(float__14));
				SerializeField(s, nameof(Enum_RJR_0__15));
			} else if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(StringID__16));
				SerializeField(s, nameof(Path__17));
				SerializeField(s, nameof(float__18));
				SerializeField(s, nameof(int__19));
				SerializeField(s, nameof(int__20));
				SerializeField(s, nameof(int__21));
				SerializeField(s, nameof(int__22));
				SerializeField(s, nameof(StringID__23));
				SerializeField(s, nameof(StringID__24));
				SerializeField(s, nameof(int__25));
				SerializeField(s, nameof(int__26));
				SerializeField(s, nameof(uint__27));
				SerializeField(s, nameof(float__28));
				SerializeField(s, nameof(int__29));
				SerializeField(s, nameof(float__30));
				SerializeField(s, nameof(Enum_RFR_0__31));
			} else {
				SerializeField(s, nameof(friendlyName));
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(playRate));
				SerializeField(s, nameof(loop));
				SerializeField(s, nameof(flags));
				SerializeField(s, nameof(useRootRotation));
				SerializeField(s, nameof(reverse));
				SerializeField(s, nameof(defaultFlip));
				SerializeField(s, nameof(markerStart));
				SerializeField(s, nameof(markerStop));
				SerializeField(s, nameof(procedural));
				SerializeField(s, nameof(sync));
				SerializeField(s, nameof(syncEighthNote));
				SerializeField(s, nameof(syncRatio));
				SerializeField(s, nameof(allowSyncOffset));
				SerializeField(s, nameof(shadowMul));
				SerializeField(s, nameof(metronome));
				SerializeField(s, nameof(forceZOffset));
				SerializeField(s, nameof(useRootFlip));
			}
		}
		public enum METRONOME_TYPE {
			[Serialize("METRONOME_TYPE_DEFAULT" )] DEFAULT = 0,
			[Serialize("METRONOME_TYPE_MENU"    )] MENU = 1,
			[Serialize("METRONOME_TYPE_GAMEPLAY")] GAMEPLAY = 2,
			[Serialize("METRONOME_TYPE_INVALID" )] INVALID = 4,
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
	}
}

