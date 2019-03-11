using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ChangePageComponent_Template : CSerializable {
		[Serialize("waitPlayersDuration"               )] public float waitPlayersDuration;
		[Serialize("useFadeOutIn"                      )] public bool useFadeOutIn;
		[Serialize("warpZone"                          )] public bool warpZone;
		[Serialize("warpZoneExit"                      )] public bool warpZoneExit;
		[Serialize("warpZoneExitScaleFactor"           )] public Vector2 warpZoneExitScaleFactor;
		[Serialize("warpZoneExitArrivalFadeOutDuration")] public float warpZoneExitArrivalFadeOutDuration;
		[Serialize("openingRadius"                     )] public float openingRadius;
		[Serialize("openingTime"                       )] public float openingTime;
		[Serialize("enableDelay"                       )] public float enableDelay;
		[Serialize("ExitUpSideOffset"                  )] public float ExitUpSideOffset;
		[Serialize("ExitUpLeftSide"                    )] public bool ExitUpLeftSide;
		[Serialize("ExitDownSideOffset"                )] public float ExitDownSideOffset;
		[Serialize("ExitDownLeftSide"                  )] public bool ExitDownLeftSide;
		[Serialize("ExitLeftSideOffset"                )] public float ExitLeftSideOffset;
		[Serialize("ExitRightSideOffset"               )] public float ExitRightSideOffset;
		[Serialize("OneWay"                            )] public bool OneWay;
		[Serialize("isCageMapDoor"                     )] public bool isCageMapDoor;
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

