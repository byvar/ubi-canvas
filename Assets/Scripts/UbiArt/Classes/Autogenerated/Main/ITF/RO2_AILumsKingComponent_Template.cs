using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AILumsKingComponent_Template : ActorComponent_Template {
		public float lumKingMusicTimer;
		public Volume lumKingMusicVolume;
		public uint lumKingValue;
		public float playerDetectorMultiplierInWater;
		public float DRCTouchDistance;
		public StringID YellowStand;
		public StringID YellowPicked;
		public StringID PurpleStand;
		public StringID PurplePicked;
		public float grabAttractiveForceValue;
		public float grabDampingFactor;
		public float timeBeforeTaken;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				lumKingMusicTimer = s.Serialize<float>(lumKingMusicTimer, name: "lumKingMusicTimer");
				lumKingMusicVolume = s.SerializeObject<Volume>(lumKingMusicVolume, name: "lumKingMusicVolume");
				lumKingValue = s.Serialize<uint>(lumKingValue, name: "lumKingValue");
				playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
				DRCTouchDistance = s.Serialize<float>(DRCTouchDistance, name: "DRCTouchDistance");
				YellowStand = s.SerializeObject<StringID>(YellowStand, name: "YellowStand");
				YellowPicked = s.SerializeObject<StringID>(YellowPicked, name: "YellowPicked");
				PurpleStand = s.SerializeObject<StringID>(PurpleStand, name: "PurpleStand");
				PurplePicked = s.SerializeObject<StringID>(PurplePicked, name: "PurplePicked");
			} else {
				lumKingMusicTimer = s.Serialize<float>(lumKingMusicTimer, name: "lumKingMusicTimer");
				lumKingMusicVolume = s.SerializeObject<Volume>(lumKingMusicVolume, name: "lumKingMusicVolume");
				lumKingValue = s.Serialize<uint>(lumKingValue, name: "lumKingValue");
				playerDetectorMultiplierInWater = s.Serialize<float>(playerDetectorMultiplierInWater, name: "playerDetectorMultiplierInWater");
				DRCTouchDistance = s.Serialize<float>(DRCTouchDistance, name: "DRCTouchDistance");
				YellowStand = s.SerializeObject<StringID>(YellowStand, name: "YellowStand");
				YellowPicked = s.SerializeObject<StringID>(YellowPicked, name: "YellowPicked");
				PurpleStand = s.SerializeObject<StringID>(PurpleStand, name: "PurpleStand");
				PurplePicked = s.SerializeObject<StringID>(PurplePicked, name: "PurplePicked");
				grabAttractiveForceValue = s.Serialize<float>(grabAttractiveForceValue, name: "grabAttractiveForceValue");
				grabDampingFactor = s.Serialize<float>(grabDampingFactor, name: "grabDampingFactor");
				timeBeforeTaken = s.Serialize<float>(timeBeforeTaken, name: "timeBeforeTaken");
			}
		}
		public override uint? ClassCRC => 0x9F9C6B44;
	}
}

