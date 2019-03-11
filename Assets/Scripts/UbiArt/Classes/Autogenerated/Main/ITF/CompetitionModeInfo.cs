using UnityEngine;

namespace UbiArt.ITF {
	public partial class CompetitionModeInfo : CSerializable {
		[Serialize("mode"                 )] public online__CompetitionMode mode;
		[Serialize("titleText"            )] public SmartLocId titleText;
		[Serialize("objectiveText"        )] public SmartLocId objectiveText;
		[Serialize("validationText"       )] public SmartLocId validationText;
		[Serialize("bestScoreText"        )] public SmartLocId bestScoreText;
		[Serialize("successFirstTitle"    )] public SmartLocId successFirstTitle;
		[Serialize("successRecordTitle"   )] public SmartLocId successRecordTitle;
		[Serialize("successTitle"         )] public SmartLocId successTitle;
		[Serialize("successText"          )] public SmartLocId successText;
		[Serialize("failedTitle"          )] public SmartLocId failedTitle;
		[Serialize("failedText"           )] public SmartLocId failedText;
		[Serialize("invalidateTitle"      )] public SmartLocId invalidateTitle;
		[Serialize("invalidateText"       )] public SmartLocId invalidateText;
		[Serialize("scoreText"            )] public SmartLocId scoreText;
		[Serialize("recordText"           )] public SmartLocId recordText;
		[Serialize("successThresholdTitle")] public CList<CompetitionModeInfo.ThresholdText> successThresholdTitle;
		[Serialize("failedThresholdTitle" )] public CList<CompetitionModeInfo.ThresholdText> failedThresholdTitle;
		[Serialize("iconPath"             )] public Path iconPath;
		[Serialize("iconSpriteIndex"      )] public uint iconSpriteIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(mode));
			SerializeField(s, nameof(titleText));
			SerializeField(s, nameof(objectiveText));
			SerializeField(s, nameof(validationText));
			SerializeField(s, nameof(bestScoreText));
			SerializeField(s, nameof(successFirstTitle));
			SerializeField(s, nameof(successRecordTitle));
			SerializeField(s, nameof(successTitle));
			SerializeField(s, nameof(successText));
			SerializeField(s, nameof(failedTitle));
			SerializeField(s, nameof(failedText));
			SerializeField(s, nameof(invalidateTitle));
			SerializeField(s, nameof(invalidateText));
			SerializeField(s, nameof(scoreText));
			SerializeField(s, nameof(recordText));
			SerializeField(s, nameof(successThresholdTitle));
			SerializeField(s, nameof(failedThresholdTitle));
			SerializeField(s, nameof(iconPath));
			SerializeField(s, nameof(iconSpriteIndex));
		}
		public partial class ThresholdText : CSerializable {
			[Serialize("text"     )] public SmartLocId text;
			[Serialize("threshold")] public float threshold;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(text));
				SerializeField(s, nameof(threshold));
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

