using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AILumsKingComponent_Template : ActorComponent_Template {
		[Serialize("lumKingMusicTimer"              )] public float lumKingMusicTimer;
		[Serialize("lumKingValue"                   )] public uint lumKingValue;
		[Serialize("playerDetectorMultiplierInWater")] public float playerDetectorMultiplierInWater;
		[Serialize("DRCTouchDistance"               )] public float DRCTouchDistance;
		[Serialize("YellowStand"                    )] public StringID YellowStand;
		[Serialize("YellowPicked"                   )] public StringID YellowPicked;
		[Serialize("PurpleStand"                    )] public StringID PurpleStand;
		[Serialize("PurplePicked"                   )] public StringID PurplePicked;
		[Serialize("grabAttractiveForceValue"       )] public float grabAttractiveForceValue;
		[Serialize("grabDampingFactor"              )] public float grabDampingFactor;
		[Serialize("timeBeforeTaken"                )] public float timeBeforeTaken;
		[Serialize("lumKingMusicVolume"             )] public Volume lumKingMusicVolume;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(lumKingMusicTimer));
				SerializeField(s, nameof(lumKingMusicVolume));
				SerializeField(s, nameof(lumKingValue));
				SerializeField(s, nameof(playerDetectorMultiplierInWater));
				SerializeField(s, nameof(DRCTouchDistance));
				SerializeField(s, nameof(YellowStand));
				SerializeField(s, nameof(YellowPicked));
				SerializeField(s, nameof(PurpleStand));
				SerializeField(s, nameof(PurplePicked));
			} else {
				SerializeField(s, nameof(lumKingMusicTimer));
				SerializeField(s, nameof(lumKingValue));
				SerializeField(s, nameof(playerDetectorMultiplierInWater));
				SerializeField(s, nameof(DRCTouchDistance));
				SerializeField(s, nameof(YellowStand));
				SerializeField(s, nameof(YellowPicked));
				SerializeField(s, nameof(PurpleStand));
				SerializeField(s, nameof(PurplePicked));
				SerializeField(s, nameof(grabAttractiveForceValue));
				SerializeField(s, nameof(grabDampingFactor));
				SerializeField(s, nameof(timeBeforeTaken));
			}
		}
		public override uint? ClassCRC => 0x9F9C6B44;
	}
}

