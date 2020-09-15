using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RewardTravelAiComponent_Template : ActorComponent_Template {
		public float takenTrajectoryFactorX;
		public float takenTrajectoryFactorY;
		public float percentTimeStartFading;
		public float alphaWhenReachedScore;
		public float waitDurationPerRankWhenAutoPicked;
		public float redCompanionLumDelay;
		public float circularRotationSpeed;
		public float extraDuration;
		public AABB particleLumAABB;
		public float scaleWhenReachedScore;
		public float percentTimeStartScaling;
		public float lumScale;
		public float lumSpawnRadius;
		public StringID gemAnim;
		public StringID foodAnim;
		public StringID ticketAnim;
		public StringID goldenTicketAnim;
		public StringID elixirGoldAnim;
		public StringID elixirSilverAnim;
		public StringID elixirNewAnim;
		public StringID elixirSpeedAnim;
		public StringID beatboxDiskAnim;
		public StringID seasonalTicketAnim;
		public StringID seasonalCurrencyAnim;
		public StringID magnifyingGlassAnim;
		public StringID challengeTicketAnim;
		public StringID challengeTokenAnim;
		public float flightTime;
		public float minScreenSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			takenTrajectoryFactorX = s.Serialize<float>(takenTrajectoryFactorX, name: "takenTrajectoryFactorX");
			takenTrajectoryFactorY = s.Serialize<float>(takenTrajectoryFactorY, name: "takenTrajectoryFactorY");
			percentTimeStartFading = s.Serialize<float>(percentTimeStartFading, name: "percentTimeStartFading");
			alphaWhenReachedScore = s.Serialize<float>(alphaWhenReachedScore, name: "alphaWhenReachedScore");
			waitDurationPerRankWhenAutoPicked = s.Serialize<float>(waitDurationPerRankWhenAutoPicked, name: "waitDurationPerRankWhenAutoPicked");
			redCompanionLumDelay = s.Serialize<float>(redCompanionLumDelay, name: "redCompanionLumDelay");
			circularRotationSpeed = s.Serialize<float>(circularRotationSpeed, name: "circularRotationSpeed");
			extraDuration = s.Serialize<float>(extraDuration, name: "extraDuration");
			particleLumAABB = s.SerializeObject<AABB>(particleLumAABB, name: "particleLumAABB");
			scaleWhenReachedScore = s.Serialize<float>(scaleWhenReachedScore, name: "scaleWhenReachedScore");
			percentTimeStartScaling = s.Serialize<float>(percentTimeStartScaling, name: "percentTimeStartScaling");
			lumScale = s.Serialize<float>(lumScale, name: "lumScale");
			lumSpawnRadius = s.Serialize<float>(lumSpawnRadius, name: "lumSpawnRadius");
			gemAnim = s.SerializeObject<StringID>(gemAnim, name: "gemAnim");
			foodAnim = s.SerializeObject<StringID>(foodAnim, name: "foodAnim");
			ticketAnim = s.SerializeObject<StringID>(ticketAnim, name: "ticketAnim");
			goldenTicketAnim = s.SerializeObject<StringID>(goldenTicketAnim, name: "goldenTicketAnim");
			elixirGoldAnim = s.SerializeObject<StringID>(elixirGoldAnim, name: "elixirGoldAnim");
			elixirSilverAnim = s.SerializeObject<StringID>(elixirSilverAnim, name: "elixirSilverAnim");
			elixirNewAnim = s.SerializeObject<StringID>(elixirNewAnim, name: "elixirNewAnim");
			elixirSpeedAnim = s.SerializeObject<StringID>(elixirSpeedAnim, name: "elixirSpeedAnim");
			beatboxDiskAnim = s.SerializeObject<StringID>(beatboxDiskAnim, name: "beatboxDiskAnim");
			seasonalTicketAnim = s.SerializeObject<StringID>(seasonalTicketAnim, name: "seasonalTicketAnim");
			seasonalCurrencyAnim = s.SerializeObject<StringID>(seasonalCurrencyAnim, name: "seasonalCurrencyAnim");
			magnifyingGlassAnim = s.SerializeObject<StringID>(magnifyingGlassAnim, name: "magnifyingGlassAnim");
			challengeTicketAnim = s.SerializeObject<StringID>(challengeTicketAnim, name: "challengeTicketAnim");
			challengeTokenAnim = s.SerializeObject<StringID>(challengeTokenAnim, name: "challengeTokenAnim");
			flightTime = s.Serialize<float>(flightTime, name: "flightTime");
			minScreenSize = s.Serialize<float>(minScreenSize, name: "minScreenSize");
		}
		public override uint? ClassCRC => 0x9CE0A730;
	}
}

