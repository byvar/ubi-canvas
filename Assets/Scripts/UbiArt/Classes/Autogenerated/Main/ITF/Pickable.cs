using UnityEngine;

namespace UbiArt.ITF {
	public partial class Pickable : CSerializable {
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
		[Serialize("ANGLE"                    )] public Angle ANGLE;
		[Serialize("SCALE"                    )] public Vector2 SCALE;
		[Serialize("OFFSCREEN_UPDATE_OVERRIDE")] public bool OFFSCREEN_UPDATE_OVERRIDE;
		[Serialize("UPDATE_TYPE"              )] public UpdateType_O UPDATE_TYPE;
		[Serialize("AABB_RELATIVE"            )] public Placeholder AABB_RELATIVE;
		[Serialize("CURPOS"                   )] public Vector3 CURPOS;
		[Serialize("CURANGLE"                 )] public float CURANGLE;
		[Serialize("CURSCALE"                 )] public Vector2 CURSCALE;
		[Serialize("ISALLOWEDFORCELL"         )] public bool ISALLOWEDFORCELL;
		[Serialize("xFLIPPED"                 )] public bool xFLIPPED;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(RELATIVEZ));
					SerializeField(s, nameof(ANGLE), typeof(float));
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
				if (s.HasFlags(SerializeFlags.Persistent)) {
					// SerializeField(s, nameof(isEnabled)); <- as byte?
					SerializeField(s, nameof(isEnabled));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(POS2D));
					SerializeField(s, nameof(ANGLE));
					SerializeField(s, nameof(INSTANCEDATAFILE));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(RELATIVEZ));
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
		public enum UpdateType_O {
			[Serialize("UpdateType_OnlyIfVisible"   )] nlyIfVisible = 0,
			[Serialize("UpdateType_OffscreenAllowed")] ffscreenAllowed = 1,
		}
		public override uint? ClassCRC => 0x2371CC09;
	}
}

