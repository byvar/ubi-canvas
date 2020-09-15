using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class CompetitionModeInfo : CSerializable {
		public online__CompetitionMode mode;
		public SmartLocId titleText;
		public SmartLocId objectiveText;
		public SmartLocId validationText;
		public SmartLocId bestScoreText;
		public SmartLocId successFirstTitle;
		public SmartLocId successRecordTitle;
		public SmartLocId successTitle;
		public SmartLocId successText;
		public SmartLocId failedTitle;
		public SmartLocId failedText;
		public SmartLocId invalidateTitle;
		public SmartLocId invalidateText;
		public SmartLocId scoreText;
		public SmartLocId recordText;
		public CList<CompetitionModeInfo.ThresholdText> successThresholdTitle;
		public CList<CompetitionModeInfo.ThresholdText> failedThresholdTitle;
		public Path iconPath;
		public uint iconSpriteIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			mode = s.Serialize<online__CompetitionMode>(mode, name: "mode");
			titleText = s.SerializeObject<SmartLocId>(titleText, name: "titleText");
			objectiveText = s.SerializeObject<SmartLocId>(objectiveText, name: "objectiveText");
			validationText = s.SerializeObject<SmartLocId>(validationText, name: "validationText");
			bestScoreText = s.SerializeObject<SmartLocId>(bestScoreText, name: "bestScoreText");
			successFirstTitle = s.SerializeObject<SmartLocId>(successFirstTitle, name: "successFirstTitle");
			successRecordTitle = s.SerializeObject<SmartLocId>(successRecordTitle, name: "successRecordTitle");
			successTitle = s.SerializeObject<SmartLocId>(successTitle, name: "successTitle");
			successText = s.SerializeObject<SmartLocId>(successText, name: "successText");
			failedTitle = s.SerializeObject<SmartLocId>(failedTitle, name: "failedTitle");
			failedText = s.SerializeObject<SmartLocId>(failedText, name: "failedText");
			invalidateTitle = s.SerializeObject<SmartLocId>(invalidateTitle, name: "invalidateTitle");
			invalidateText = s.SerializeObject<SmartLocId>(invalidateText, name: "invalidateText");
			scoreText = s.SerializeObject<SmartLocId>(scoreText, name: "scoreText");
			recordText = s.SerializeObject<SmartLocId>(recordText, name: "recordText");
			successThresholdTitle = s.SerializeObject<CList<CompetitionModeInfo.ThresholdText>>(successThresholdTitle, name: "successThresholdTitle");
			failedThresholdTitle = s.SerializeObject<CList<CompetitionModeInfo.ThresholdText>>(failedThresholdTitle, name: "failedThresholdTitle");
			iconPath = s.SerializeObject<Path>(iconPath, name: "iconPath");
			iconSpriteIndex = s.Serialize<uint>(iconSpriteIndex, name: "iconSpriteIndex");
		}
		[Games(GameFlags.RA)]
		public partial class ThresholdText : CSerializable {
			public SmartLocId text;
			public float threshold;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				text = s.SerializeObject<SmartLocId>(text, name: "text");
				threshold = s.Serialize<float>(threshold, name: "threshold");
			}
		}
		public enum online__CompetitionMode {
			[Serialize("online::CompetitionMode_None"           )] None = -1,
			[Serialize("online::CompetitionMode_Distance"       )] Distance = 0,
			[Serialize("online::CompetitionMode_TimeForLums"    )] TimeForLums = 1,
			[Serialize("online::CompetitionMode_TimeForDistance")] TimeForDistance = 2,
			[Serialize("online::CompetitionMode_DistanceForTime")] DistanceForTime = 3,
			[Serialize("online::CompetitionMode_Lums"           )] Lums = 4,
			[Serialize("online::CompetitionMode_LumsForTime"    )] LumsForTime = 5,
			[Serialize("online::CompetitionMode_TeensiesForTime")] TeensiesForTime = 6,
		}
	}
}

