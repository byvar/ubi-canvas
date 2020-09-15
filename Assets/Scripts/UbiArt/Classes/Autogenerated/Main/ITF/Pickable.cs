using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class Pickable : BaseObject {
		[Serialize("globalPos"                )] public Vec3d globalPos;
		[Serialize("RELATIVEZ"                )] public float RELATIVEZ;
		[Serialize("USERFRIENDLY"             )] public string USERFRIENDLY;
		[Serialize("UPDATEDEPENDENCYLIST"     )] public CArray<ObjectPath> UPDATEDEPENDENCYLIST;
		[Serialize("STARTPAUSE"               )] public bool STARTPAUSE;
		[Serialize("isEnabled"                )] public bool isEnabled;
		[Serialize("POS2D"                    )] public Vec2d POS2D;
		[Serialize("ObjectDeviceSpeed"        )] public DeviceInfo__Device_Speed ObjectDeviceSpeed;
		[Serialize("ObjectDeviceSpeed_L2"     )] public DeviceInfo__Device_Speed ObjectDeviceSpeed_L2;
		[Serialize("INSTANCEDATAFILE"         )] public Path INSTANCEDATAFILE;
		[Serialize("persistenceId"            )] public uint persistenceId;
		[Serialize("USEVIEWFRUSTUMFLAG"       )] public bool USEVIEWFRUSTUMFLAG;
		[Serialize("SCALE"                    )] public Vec2d SCALE;
		[Serialize("OFFSCREEN_UPDATE_OVERRIDE")] public int OFFSCREEN_UPDATE_OVERRIDE;
		[Serialize("UPDATE_TYPE"              )] public UpdateType UPDATE_TYPE;
		[Serialize("AABB_RELATIVE"            )] public AABB AABB_RELATIVE;
		[Serialize("CURPOS"                   )] public Vec3d CURPOS;
		[Serialize("CURANGLE"                 )] public float CURANGLE;
		[Serialize("CURSCALE"                 )] public Vec2d CURSCALE;
		[Serialize("ISALLOWEDFORCELL"         )] public int ISALLOWEDFORCELL;
		[Serialize("ANGLE"                    )] public Angle ANGLE;
		[Serialize("xFLIPPED"                 )] public bool xFLIPPED;

		[Serialize("Enum_VH_0__22"            )] public Enum_VH_0 Enum_VH_0__22;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(ANGLE), type: typeof(float));
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
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(SCALE));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(USERFRIENDLY));
					SerializeField(s, nameof(UPDATEDEPENDENCYLIST));
				}
				if (Settings.s.isCatchThemAll) {
					SerializeField(s, nameof(isEnabled), boolAsByte: true);
					SerializeField(s, nameof(isEnabled), boolAsByte: true);
					SerializeField(s, nameof(isEnabled), boolAsByte: true);
					SerializeField(s, nameof(isEnabled), boolAsByte: true);
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
					SerializeField(s, nameof(globalPos));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(SCALE));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(USERFRIENDLY));
					SerializeField(s, nameof(UPDATEDEPENDENCYLIST));
					SerializeField(s, nameof(STARTPAUSE));
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					SerializeField(s, nameof(isEnabled));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(ANGLE));
					SerializeField(s, nameof(Enum_VH_0__22));
					SerializeField(s, nameof(INSTANCEDATAFILE));
				}
				SerializeField(s, nameof(persistenceId));
			} else {
				if (s.HasFlags(SerializeFlags.Flags16)) {
					SerializeField(s, nameof(globalPos));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(ANGLE));
					SerializeField(s, nameof(SCALE));
					SerializeField(s, nameof(xFLIPPED));
					SerializeField(s, nameof(USERFRIENDLY));
					SerializeField(s, nameof(UPDATEDEPENDENCYLIST));
					SerializeField(s, nameof(STARTPAUSE));
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
		public enum Enum_VH_0 {
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_3" )] Value_3 = 3,
			[Serialize("Value_2" )] Value_2 = 2,
			[Serialize("Value_6" )] Value_6 = 6,
			[Serialize("Value_4" )] Value_4 = 4,
			[Serialize("Value__1")] Value__1 = -1,
		}
		public enum UpdateType {
			[Serialize("Pickable::UpdateType_OnlyIfVisible")] OnlyIfVisible = 0,
			[Serialize("Pickable::UpdateType_OffscreenAllowed")] OffscreenAllowed = 1,
		}
		public override uint? ClassCRC => 0x2371CC09;
	}
}

