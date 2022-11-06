using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class Pickable : BaseObject {
		public Vec3d globalPos;
		public float RELATIVEZ;
		public string USERFRIENDLY;
		public CArrayO<ObjectPath> UPDATEDEPENDENCYLIST;
		public bool STARTPAUSE;
		public bool isEnabled;
		public Vec2d POS2D;
		public DeviceInfo__Device_Speed ObjectDeviceSpeed;
		public DeviceInfo__Device_Speed ObjectDeviceSpeed_L2;
		public Path INSTANCEDATAFILE;
		public uint persistenceId;
		public bool USEVIEWFRUSTUMFLAG;
		public Vec2d SCALE;
		public int OFFSCREEN_UPDATE_OVERRIDE;
		public UpdateType UPDATE_TYPE;
		public AABB AABB_RELATIVE;
		public Vec3d CURPOS;
		public float CURANGLE;
		public Vec2d CURSCALE;
		public int ISALLOWEDFORCELL;
		public Angle ANGLE;
		public bool xFLIPPED;

		public Enum_VH_0 Enum_VH_0__22;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Default)) {
					POS2D = s.SerializeObject<Vec2d>(POS2D, name: "POS2D");
					RELATIVEZ = s.Serialize<float>(RELATIVEZ, name: "RELATIVEZ");
					ANGLE = (Angle)s.Serialize<float>((float)ANGLE, name: "ANGLE");
					SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
					USERFRIENDLY = s.Serialize<string>(USERFRIENDLY, name: "USERFRIENDLY");
					OFFSCREEN_UPDATE_OVERRIDE = s.Serialize<int>(OFFSCREEN_UPDATE_OVERRIDE, name: "OFFSCREEN_UPDATE_OVERRIDE");
					UPDATE_TYPE = s.Serialize<UpdateType>(UPDATE_TYPE, name: "UPDATE_TYPE");
				}
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					AABB_RELATIVE = s.SerializeObject<AABB>(AABB_RELATIVE, name: "AABB_RELATIVE");
				}
				if (s.HasFlags(SerializeFlags.Flags_x30)) {
					CURPOS = s.SerializeObject<Vec3d>(CURPOS, name: "CURPOS");
					CURANGLE = s.Serialize<float>(CURANGLE, name: "CURANGLE");
					CURSCALE = s.SerializeObject<Vec2d>(CURSCALE, name: "CURSCALE");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					ISALLOWEDFORCELL = s.Serialize<int>(ISALLOWEDFORCELL, name: "ISALLOWEDFORCELL");
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled");
				}
			} else if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					RELATIVEZ = s.Serialize<float>(RELATIVEZ, name: "RELATIVEZ");
					SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
					xFLIPPED = s.Serialize<bool>(xFLIPPED, name: "xFLIPPED");
					USERFRIENDLY = s.Serialize<string>(USERFRIENDLY, name: "USERFRIENDLY");
					UPDATEDEPENDENCYLIST = s.SerializeObject<CArrayO<ObjectPath>>(UPDATEDEPENDENCYLIST, name: "UPDATEDEPENDENCYLIST");
				}
				if (s.Settings.isCatchThemAll) {
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled", options: CSerializerObject.Options.BoolAsByte);
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled", options: CSerializerObject.Options.BoolAsByte);
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled", options: CSerializerObject.Options.BoolAsByte);
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					POS2D = s.SerializeObject<Vec2d>(POS2D, name: "POS2D");
					ANGLE = s.SerializeObject<Angle>(ANGLE, name: "ANGLE");
					INSTANCEDATAFILE = s.SerializeObject<Path>(INSTANCEDATAFILE, name: "INSTANCEDATAFILE");
				}
			} else if (s.Settings.game == Settings.Game.COL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					RELATIVEZ = s.Serialize<float>(RELATIVEZ, name: "RELATIVEZ");
					SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
					xFLIPPED = s.Serialize<bool>(xFLIPPED, name: "xFLIPPED", options: CSerializerObject.Options.BoolAsByte);
					USERFRIENDLY = s.Serialize<string>(USERFRIENDLY, name: "USERFRIENDLY");
					UPDATEDEPENDENCYLIST = s.SerializeObject<CArrayO<ObjectPath>>(UPDATEDEPENDENCYLIST, name: "UPDATEDEPENDENCYLIST");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled", options: CSerializerObject.Options.BoolAsByte);
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					POS2D = s.SerializeObject<Vec2d>(POS2D, name: "POS2D");
					ANGLE = s.SerializeObject<Angle>(ANGLE, name: "ANGLE");
					INSTANCEDATAFILE = s.SerializeObject<Path>(INSTANCEDATAFILE, name: "INSTANCEDATAFILE");
					OBJECTID = s.SerializeObject<ObjectId>(OBJECTID, name: "OBJECTID");
				}
			} else if (s.Settings.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags16)) {
					globalPos = s.SerializeObject<Vec3d>(globalPos, name: "globalPos");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					RELATIVEZ = s.Serialize<float>(RELATIVEZ, name: "RELATIVEZ");
					SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
					xFLIPPED = s.Serialize<bool>(xFLIPPED, name: "xFLIPPED");
					USERFRIENDLY = s.Serialize<string>(USERFRIENDLY, name: "USERFRIENDLY");
					UPDATEDEPENDENCYLIST = s.SerializeObject<CArrayO<ObjectPath>>(UPDATEDEPENDENCYLIST, name: "UPDATEDEPENDENCYLIST");
					STARTPAUSE = s.Serialize<bool>(STARTPAUSE, name: "STARTPAUSE");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					POS2D = s.SerializeObject<Vec2d>(POS2D, name: "POS2D");
					ANGLE = s.SerializeObject<Angle>(ANGLE, name: "ANGLE");
					Enum_VH_0__22 = s.Serialize<Enum_VH_0>(Enum_VH_0__22, name: "Enum_VH_0__22");
					INSTANCEDATAFILE = s.SerializeObject<Path>(INSTANCEDATAFILE, name: "INSTANCEDATAFILE");
				}
				persistenceId = s.Serialize<uint>(persistenceId, name: "persistenceId");
			} else {
				if (s.HasFlags(SerializeFlags.Flags16)) {
					globalPos = s.SerializeObject<Vec3d>(globalPos, name: "globalPos");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					RELATIVEZ = s.Serialize<float>(RELATIVEZ, name: "RELATIVEZ");
					ANGLE = s.SerializeObject<Angle>(ANGLE, name: "ANGLE");
					SCALE = s.SerializeObject<Vec2d>(SCALE, name: "SCALE");
					xFLIPPED = s.Serialize<bool>(xFLIPPED, name: "xFLIPPED");
					USERFRIENDLY = s.Serialize<string>(USERFRIENDLY, name: "USERFRIENDLY");
					UPDATEDEPENDENCYLIST = s.SerializeObject<CArrayO<ObjectPath>>(UPDATEDEPENDENCYLIST, name: "UPDATEDEPENDENCYLIST");
					STARTPAUSE = s.Serialize<bool>(STARTPAUSE, name: "STARTPAUSE");
				}
				if (s.HasFlags(SerializeFlags.Persistent)) {
					isEnabled = s.Serialize<bool>(isEnabled, name: "isEnabled");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					POS2D = s.SerializeObject<Vec2d>(POS2D, name: "POS2D");
					ObjectDeviceSpeed = s.Serialize<DeviceInfo__Device_Speed>(ObjectDeviceSpeed, name: "ObjectDeviceSpeed");
					ObjectDeviceSpeed_L2 = s.Serialize<DeviceInfo__Device_Speed>(ObjectDeviceSpeed_L2, name: "ObjectDeviceSpeed_L2");
					INSTANCEDATAFILE = s.SerializeObject<Path>(INSTANCEDATAFILE, name: "INSTANCEDATAFILE");
				}
				persistenceId = s.Serialize<uint>(persistenceId, name: "persistenceId");
				USEVIEWFRUSTUMFLAG = s.Serialize<bool>(USEVIEWFRUSTUMFLAG, name: "USEVIEWFRUSTUMFLAG");
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

