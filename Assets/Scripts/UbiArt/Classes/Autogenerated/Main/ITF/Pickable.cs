using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RO | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class Pickable : CSerializable {
		[Serialize("globalPos"                )] public Vector3 globalPos;
		[Serialize("RELATIVEZ"                )] public float RELATIVEZ;
		[Serialize("USERFRIENDLY"             )] public string USERFRIENDLY;
		[Serialize("UPDATEDEPENDENCYLIST"     )] public CArray<ObjectPath> UPDATEDEPENDENCYLIST;
		[Serialize("STARTPAUSE"               )] public bool STARTPAUSE;
		[Serialize("isEnabled"                )] public bool isEnabled;
		[Serialize("POS2D"                    )] public Vector2 POS2D;
		[Serialize("ObjectDeviceSpeed"        )] public DeviceInfo__Device_Speed ObjectDeviceSpeed;
		[Serialize("ObjectDeviceSpeed_L2"     )] public DeviceInfo__Device_Speed ObjectDeviceSpeed_L2;
		[Serialize("INSTANCEDATAFILE"         )] public Path INSTANCEDATAFILE;
		[Serialize("persistenceId"            )] public uint persistenceId;
		[Serialize("USEVIEWFRUSTUMFLAG"       )] public bool USEVIEWFRUSTUMFLAG;
		[Serialize("ANGLE"                    )] public float ANGLE;
		[Serialize("SCALE"                    )] public Vector2 SCALE;
		[Serialize("OFFSCREEN_UPDATE_OVERRIDE")] public int OFFSCREEN_UPDATE_OVERRIDE;
		[Serialize("UPDATE_TYPE"              )] public Enum_RJR_0 UPDATE_TYPE;
		[Serialize("AABB_RELATIVE"            )] public AABB AABB_RELATIVE;
		[Serialize("CURPOS"                   )] public Vector3 CURPOS;
		[Serialize("CURANGLE"                 )] public float CURANGLE;
		[Serialize("CURSCALE"                 )] public Vector2 CURSCALE;
		[Serialize("ISALLOWEDFORCELL"         )] public int ISALLOWEDFORCELL;
		[Serialize("ANGLE"                    )] public Angle ANGLE;
		[Serialize("xFLIPPED"                 )] public bool xFLIPPED;
		[Serialize("OBJECTID"                 )] public Placeholder OBJECTID;
		[Serialize("Vector2__0"               )] public Vector2 Vector2__0;
		[Serialize("float__1"                 )] public float float__1;
		[Serialize("float__2"                 )] public float float__2;
		[Serialize("Vector2__3"               )] public Vector2 Vector2__3;
		[Serialize("string__4"                )] public string string__4;
		[Serialize("int__5"                   )] public int int__5;
		[Serialize("Enum_RFR_0__6"            )] public Enum_RFR_0 Enum_RFR_0__6;
		[Serialize("AABB__7"                  )] public AABB AABB__7;
		[Serialize("Vector3__8"               )] public Vector3 Vector3__8;
		[Serialize("float__9"                 )] public float float__9;
		[Serialize("Vector2__10"              )] public Vector2 Vector2__10;
		[Serialize("int__11"                  )] public int int__11;
		[Serialize("int__12"                  )] public int int__12;
		[Serialize("Vector3__13"              )] public Vector3 Vector3__13;
		[Serialize("float__14"                )] public float float__14;
		[Serialize("Vector2__15"              )] public Vector2 Vector2__15;
		[Serialize("bool__16"                 )] public bool bool__16;
		[Serialize("string__17"               )] public string string__17;
		[Serialize("CArray<ObjectPath>__18"   )] public CArray<ObjectPath> CArray_ObjectPath__18;
		[Serialize("bool__19"                 )] public bool bool__19;
		[Serialize("Vector2__20"              )] public Vector2 Vector2__20;
		[Serialize("Angle__21"                )] public Angle Angle__21;
		[Serialize("Enum_VH_0__22"            )] public Enum_VH_0 Enum_VH_0__22;
		[Serialize("Path__23"                 )] public Path Path__23;
		[Serialize("uint__24"                 )] public uint uint__24;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(ANGLE));
					SerializeField(s, nameof(SCALE));
					SerializeField(s, nameof(USERFRIENDLY));
					SerializeField(s, nameof(OFFSCREEN_UPDATE_OVERRIDE));
					SerializeField(s, nameof(UPDATE_TYPE));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(AABB_RELATIVE));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(CURPOS));
					SerializeField(s, nameof(CURANGLE));
					SerializeField(s, nameof(CURSCALE));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(ISALLOWEDFORCELL));
					SerializeField(s, nameof(isEnabled));
				}
			} else if (Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Vector2__0));
					SerializeField(s, nameof(float__1));
					SerializeField(s, nameof(float__2));
					SerializeField(s, nameof(Vector2__3));
					SerializeField(s, nameof(string__4));
					SerializeField(s, nameof(int__5));
					SerializeField(s, nameof(Enum_RFR_0__6));
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(AABB__7));
				}
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					SerializeField(s, nameof(Vector3__8));
					SerializeField(s, nameof(float__9));
					SerializeField(s, nameof(Vector2__10));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(int__11));
					SerializeField(s, nameof(int__12));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(SCALE));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(USERFRIENDLY));
					SerializeField(s, nameof(UPDATEDEPENDENCYLIST));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled), boolAsByte: true);
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(ANGLE));
					SerializeField(s, nameof(INSTANCEDATAFILE));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(SCALE));
					SerializeField(s, nameof(xFLIPPED), boolAsByte: true);
					SerializeField(s, nameof(USERFRIENDLY));
					SerializeField(s, nameof(UPDATEDEPENDENCYLIST));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled), boolAsByte: true);
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(ANGLE));
					SerializeField(s, nameof(INSTANCEDATAFILE));
					SerializeField(s, nameof(OBJECTID));
				}
			} else if (Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags16)) {
					SerializeField(s, nameof(Vector3__13));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(float__14));
					SerializeField(s, nameof(Vector2__15));
					SerializeField(s, nameof(bool__16));
					SerializeField(s, nameof(string__17));
					SerializeField(s, nameof(CArray_ObjectPath__18));
					SerializeField(s, nameof(bool__19));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Vector2__20));
					SerializeField(s, nameof(Angle__21));
					SerializeField(s, nameof(Enum_VH_0__22));
					SerializeField(s, nameof(Path__23));
				}
				SerializeField(s, nameof(uint__24));
			} else {
				if (s.HasFlags(SerializeFlags.Flags16)) {
					SerializeField(s, nameof(globalPos));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(USERFRIENDLY));
					SerializeField(s, nameof(UPDATEDEPENDENCYLIST));
					SerializeField(s, nameof(STARTPAUSE));
					SerializeField(s, nameof(UPDATEDEPENDENCYLIST));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(ObjectDeviceSpeed));
					SerializeField(s, nameof(ObjectDeviceSpeed_L2));
					SerializeField(s, nameof(INSTANCEDATAFILE));
				}
				SerializeField(s, nameof(persistenceId));
				SerializeField(s, nameof(USEVIEWFRUSTUMFLAG));
			}
		}
		public enum DeviceInfo__Device_Speed {
			[Serialize("DeviceInfo::Device_SpeedLow"               )] Low = 1,
			[Serialize("DeviceInfo::Device_SpeedLowMedium"         )] LowMedium = 3,
			[Serialize("DeviceInfo::Device_SpeedLowMediumHigh"     )] LowMediumHigh = 7,
			[Serialize("DeviceInfo::Device_SpeedMedium"            )] Medium = 2,
			[Serialize("DeviceInfo::Device_SpeedMediumHigh"        )] MediumHigh = 6,
			[Serialize("DeviceInfo::Device_SpeedMediumHighVeryHigh")] MediumHighVeryHigh = 14,
			[Serialize("DeviceInfo::Device_SpeedHigh"              )] High = 4,
			[Serialize("DeviceInfo::Device_SpeedHighVeryHigh"      )] HighVeryHigh = 12,
			[Serialize("DeviceInfo::Device_SpeedVeryHigh"          )] VeryHigh = 8,
			[Serialize("DeviceInfo::Device_SpeedAll"               )] All = 15,
		}
		public enum Enum_RJR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_RFR_0 {
			[Serialize("Value_1")] Value_1 = 1,
		}
		public enum Enum_VH_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value__1")] Value__1 = -1,
		}
		public override uint? ClassCRC => 0x2371CC09;
	}
}

