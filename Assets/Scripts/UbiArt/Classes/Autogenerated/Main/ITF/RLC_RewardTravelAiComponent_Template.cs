using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_RewardTravelAiComponent_Template : ActorComponent_Template {
		[Serialize("takenTrajectoryFactorX"           )] public float takenTrajectoryFactorX;
		[Serialize("takenTrajectoryFactorY"           )] public float takenTrajectoryFactorY;
		[Serialize("percentTimeStartFading"           )] public float percentTimeStartFading;
		[Serialize("alphaWhenReachedScore"            )] public float alphaWhenReachedScore;
		[Serialize("waitDurationPerRankWhenAutoPicked")] public float waitDurationPerRankWhenAutoPicked;
		[Serialize("redCompanionLumDelay"             )] public float redCompanionLumDelay;
		[Serialize("circularRotationSpeed"            )] public float circularRotationSpeed;
		[Serialize("extraDuration"                    )] public float extraDuration;
		[Serialize("particleLumAABB"                  )] public AABB particleLumAABB;
		[Serialize("scaleWhenReachedScore"            )] public float scaleWhenReachedScore;
		[Serialize("percentTimeStartScaling"          )] public float percentTimeStartScaling;
		[Serialize("lumScale"                         )] public float lumScale;
		[Serialize("lumSpawnRadius"                   )] public float lumSpawnRadius;
		[Serialize("gemAnim"                          )] public StringID gemAnim;
		[Serialize("foodAnim"                         )] public StringID foodAnim;
		[Serialize("ticketAnim"                       )] public StringID ticketAnim;
		[Serialize("goldenTicketAnim"                 )] public StringID goldenTicketAnim;
		[Serialize("elixirGoldAnim"                   )] public StringID elixirGoldAnim;
		[Serialize("elixirSilverAnim"                 )] public StringID elixirSilverAnim;
		[Serialize("elixirNewAnim"                    )] public StringID elixirNewAnim;
		[Serialize("elixirSpeedAnim"                  )] public StringID elixirSpeedAnim;
		[Serialize("beatboxDiskAnim"                  )] public StringID beatboxDiskAnim;
		[Serialize("seasonalTicketAnim"               )] public StringID seasonalTicketAnim;
		[Serialize("seasonalCurrencyAnim"             )] public StringID seasonalCurrencyAnim;
		[Serialize("magnifyingGlassAnim"              )] public StringID magnifyingGlassAnim;
		[Serialize("challengeTicketAnim"              )] public StringID challengeTicketAnim;
		[Serialize("challengeTokenAnim"               )] public StringID challengeTokenAnim;
		[Serialize("flightTime"                       )] public float flightTime;
		[Serialize("minScreenSize"                    )] public float minScreenSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(takenTrajectoryFactorX));
			SerializeField(s, nameof(takenTrajectoryFactorY));
			SerializeField(s, nameof(percentTimeStartFading));
			SerializeField(s, nameof(alphaWhenReachedScore));
			SerializeField(s, nameof(waitDurationPerRankWhenAutoPicked));
			SerializeField(s, nameof(redCompanionLumDelay));
			SerializeField(s, nameof(circularRotationSpeed));
			SerializeField(s, nameof(extraDuration));
			SerializeField(s, nameof(particleLumAABB));
			SerializeField(s, nameof(scaleWhenReachedScore));
			SerializeField(s, nameof(percentTimeStartScaling));
			SerializeField(s, nameof(lumScale));
			SerializeField(s, nameof(lumSpawnRadius));
			SerializeField(s, nameof(gemAnim));
			SerializeField(s, nameof(foodAnim));
			SerializeField(s, nameof(ticketAnim));
			SerializeField(s, nameof(goldenTicketAnim));
			SerializeField(s, nameof(elixirGoldAnim));
			SerializeField(s, nameof(elixirSilverAnim));
			SerializeField(s, nameof(elixirNewAnim));
			SerializeField(s, nameof(elixirSpeedAnim));
			SerializeField(s, nameof(beatboxDiskAnim));
			SerializeField(s, nameof(seasonalTicketAnim));
			SerializeField(s, nameof(seasonalCurrencyAnim));
			SerializeField(s, nameof(magnifyingGlassAnim));
			SerializeField(s, nameof(challengeTicketAnim));
			SerializeField(s, nameof(challengeTokenAnim));
			SerializeField(s, nameof(flightTime));
			SerializeField(s, nameof(minScreenSize));
		}
		public override uint? ClassCRC => 0x9CE0A730;
	}
}

