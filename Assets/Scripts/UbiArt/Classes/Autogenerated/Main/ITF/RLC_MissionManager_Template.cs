using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_MissionManager_Template : TemplateObj {
		[Serialize("missions"                         )] public CMap<StringID, RLC_Mission> missions;
		[Serialize("rewards"                          )] public CMap<StringID, RLC_MissionReward> rewards;
		[Serialize("DailyObjectiveMissingPiecesPrices")] public CMap<uint, uint> DailyObjectiveMissingPiecesPrices;
		[Serialize("PriceForShuffleDailyObjective"    )] public uint PriceForShuffleDailyObjective;
		[Serialize("TutoTapPath"                      )] public Path TutoTapPath;
		[Serialize("TutoPressDownPath"                )] public Path TutoPressDownPath;
		[Serialize("AutoOpenNewDailyObjectives"       )] public bool AutoOpenNewDailyObjectives;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(missions));
			SerializeField(s, nameof(rewards));
			SerializeField(s, nameof(DailyObjectiveMissingPiecesPrices));
			SerializeField(s, nameof(PriceForShuffleDailyObjective));
			SerializeField(s, nameof(TutoTapPath));
			SerializeField(s, nameof(TutoPressDownPath));
			SerializeField(s, nameof(AutoOpenNewDailyObjectives));
		}
		public override uint? ClassCRC => 0x7AB8E76D;
	}
}

