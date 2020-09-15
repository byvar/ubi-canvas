using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ChangePageComponent_Template : ActorComponent_Template {
		[Serialize("waitPlayersDuration"               )] public float waitPlayersDuration;
		[Serialize("useFadeOutIn"                      )] public int useFadeOutIn;
		[Serialize("warpZone"                          )] public int warpZone;
		[Serialize("warpZoneExit"                      )] public int warpZoneExit;
		[Serialize("warpZoneExitScaleFactor"           )] public Vec2d warpZoneExitScaleFactor;
		[Serialize("warpZoneExitArrivalFadeOutDuration")] public float warpZoneExitArrivalFadeOutDuration;
		[Serialize("openingRadius"                     )] public float openingRadius;
		[Serialize("openingTime"                       )] public float openingTime;
		[Serialize("enableDelay"                       )] public float enableDelay;
		[Serialize("ExitUpSideOffset"                  )] public float ExitUpSideOffset;
		[Serialize("ExitUpLeftSide"                    )] public int ExitUpLeftSide;
		[Serialize("ExitDownSideOffset"                )] public float ExitDownSideOffset;
		[Serialize("ExitDownLeftSide"                  )] public int ExitDownLeftSide;
		[Serialize("ExitLeftSideOffset"                )] public float ExitLeftSideOffset;
		[Serialize("ExitRightSideOffset"               )] public float ExitRightSideOffset;
		[Serialize("OneWay"                            )] public int OneWay;
		[Serialize("isCageMapDoor"                     )] public int isCageMapDoor;
		[Serialize("electoonHelpPeriod"                )] public float electoonHelpPeriod;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(waitPlayersDuration));
			SerializeField(s, nameof(useFadeOutIn));
			SerializeField(s, nameof(warpZone));
			SerializeField(s, nameof(warpZoneExit));
			SerializeField(s, nameof(warpZoneExitScaleFactor));
			SerializeField(s, nameof(warpZoneExitArrivalFadeOutDuration));
			SerializeField(s, nameof(openingRadius));
			SerializeField(s, nameof(openingTime));
			SerializeField(s, nameof(enableDelay));
			SerializeField(s, nameof(ExitUpSideOffset));
			SerializeField(s, nameof(ExitUpLeftSide));
			SerializeField(s, nameof(ExitDownSideOffset));
			SerializeField(s, nameof(ExitDownLeftSide));
			SerializeField(s, nameof(ExitLeftSideOffset));
			SerializeField(s, nameof(ExitRightSideOffset));
			SerializeField(s, nameof(OneWay));
			SerializeField(s, nameof(isCageMapDoor));
			SerializeField(s, nameof(electoonHelpPeriod));
		}
		public override uint? ClassCRC => 0xF723BDDA;
	}
}

