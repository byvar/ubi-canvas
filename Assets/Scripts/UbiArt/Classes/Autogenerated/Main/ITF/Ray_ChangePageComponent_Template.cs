using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangePageComponent_Template : ActorComponent_Template {
		public float waitPlayersDuration;
		public int useFadeOutIn;
		public int warpZone;
		public int warpZoneExit;
		public Vec2d warpZoneExitScaleFactor;
		public float warpZoneExitArrivalFadeOutDuration;
		public float openingRadius;
		public float openingTime;
		public float enableDelay;
		public float ExitUpSideOffset;
		public int ExitUpLeftSide;
		public float ExitDownSideOffset;
		public int ExitDownLeftSide;
		public float ExitLeftSideOffset;
		public float ExitRightSideOffset;
		public int OneWay;
		public int isCageMapDoor;
		public float electoonHelpPeriod;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitPlayersDuration = s.Serialize<float>(waitPlayersDuration, name: "waitPlayersDuration");
			useFadeOutIn = s.Serialize<int>(useFadeOutIn, name: "useFadeOutIn");
			warpZone = s.Serialize<int>(warpZone, name: "warpZone");
			warpZoneExit = s.Serialize<int>(warpZoneExit, name: "warpZoneExit");
			warpZoneExitScaleFactor = s.SerializeObject<Vec2d>(warpZoneExitScaleFactor, name: "warpZoneExitScaleFactor");
			warpZoneExitArrivalFadeOutDuration = s.Serialize<float>(warpZoneExitArrivalFadeOutDuration, name: "warpZoneExitArrivalFadeOutDuration");
			openingRadius = s.Serialize<float>(openingRadius, name: "openingRadius");
			openingTime = s.Serialize<float>(openingTime, name: "openingTime");
			enableDelay = s.Serialize<float>(enableDelay, name: "enableDelay");
			ExitUpSideOffset = s.Serialize<float>(ExitUpSideOffset, name: "ExitUpSideOffset");
			ExitUpLeftSide = s.Serialize<int>(ExitUpLeftSide, name: "ExitUpLeftSide");
			ExitDownSideOffset = s.Serialize<float>(ExitDownSideOffset, name: "ExitDownSideOffset");
			ExitDownLeftSide = s.Serialize<int>(ExitDownLeftSide, name: "ExitDownLeftSide");
			ExitLeftSideOffset = s.Serialize<float>(ExitLeftSideOffset, name: "ExitLeftSideOffset");
			ExitRightSideOffset = s.Serialize<float>(ExitRightSideOffset, name: "ExitRightSideOffset");
			OneWay = s.Serialize<int>(OneWay, name: "OneWay");
			isCageMapDoor = s.Serialize<int>(isCageMapDoor, name: "isCageMapDoor");
			electoonHelpPeriod = s.Serialize<float>(electoonHelpPeriod, name: "electoonHelpPeriod");
		}
		public override uint? ClassCRC => 0xF723BDDA;
	}
}

