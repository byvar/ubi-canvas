using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_ChallengeCommon_Template : TemplateObj {
		public StringID name;
		public Vec2d unitSize;
		public CArrayO<Generic<RO2_Brick_Template>> gameplayBricks;
		public uint initialSpawnCount;
		public uint duplicateSpawnCooldown;
		public CListO<StringID> firstBricks;
		public CListO<StringID> continueStartBrick;
		public CListO<StringID> lastBricks;
		public CListO<RO2_ChallengeCommon_Template.DifficultyRange> difficultyRanges;
		public CListO<RO2_EnduranceRule_Template> gameplayRules;
		public CListP<string> filter;
		public StringID menuId;
		public StringID debugMenuId;
		public Path countdownPath;
		public Nullable<EventPlayMusic> inGameMusic;
		public Nullable<EventPlayMusic> gameOverMusic;
		public float ghostDistanceMax;
		public float ghostOffsetDistanceTeleportation;
		public CListO<EventPlayMusic> difficultyChangeMusicEvents;
		public CListO<CListP<string>> filterOrder;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				name = s.SerializeObject<StringID>(name, name: "name");
				unitSize = s.SerializeObject<Vec2d>(unitSize, name: "unitSize");
				gameplayBricks = s.SerializeObject<CArrayO<Generic<RO2_Brick_Template>>>(gameplayBricks, name: "gameplayBricks");
				initialSpawnCount = s.Serialize<uint>(initialSpawnCount, name: "initialSpawnCount");
				duplicateSpawnCooldown = s.Serialize<uint>(duplicateSpawnCooldown, name: "duplicateSpawnCooldown");
				firstBricks = s.SerializeObject<CListO<StringID>>(firstBricks, name: "firstBricks");
				lastBricks = s.SerializeObject<CListO<StringID>>(lastBricks, name: "lastBricks");
				difficultyRanges = s.SerializeObject<CListO<RO2_ChallengeCommon_Template.DifficultyRange>>(difficultyRanges, name: "difficultyRanges");
				gameplayRules = s.SerializeObject<CListO<RO2_EnduranceRule_Template>>(gameplayRules, name: "gameplayRules");
				filter = s.SerializeObject<CListP<string>>(filter, name: "filter");
				filterOrder = s.SerializeObject<CListO<CListP<string>>>(filterOrder, name: "filterOrder");
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				debugMenuId = s.SerializeObject<StringID>(debugMenuId, name: "debugMenuId");
				countdownPath = s.SerializeObject<Path>(countdownPath, name: "countdownPath");
				inGameMusic = s.SerializeObject<Nullable<EventPlayMusic>>(inGameMusic, name: "inGameMusic");
				gameOverMusic = s.SerializeObject<Nullable<EventPlayMusic>>(gameOverMusic, name: "gameOverMusic");
				ghostDistanceMax = s.Serialize<float>(ghostDistanceMax, name: "ghostDistanceMax");
				ghostOffsetDistanceTeleportation = s.Serialize<float>(ghostOffsetDistanceTeleportation, name: "ghostOffsetDistanceTeleportation");
				difficultyChangeMusicEvents = s.SerializeObject<CListO<EventPlayMusic>>(difficultyChangeMusicEvents, name: "difficultyChangeMusicEvents");
			} else {
				name = s.SerializeObject<StringID>(name, name: "name");
				unitSize = s.SerializeObject<Vec2d>(unitSize, name: "unitSize");
				gameplayBricks = s.SerializeObject<CArrayO<Generic<RO2_Brick_Template>>>(gameplayBricks, name: "gameplayBricks");
				initialSpawnCount = s.Serialize<uint>(initialSpawnCount, name: "initialSpawnCount");
				duplicateSpawnCooldown = s.Serialize<uint>(duplicateSpawnCooldown, name: "duplicateSpawnCooldown");
				firstBricks = s.SerializeObject<CListO<StringID>>(firstBricks, name: "firstBricks");
				continueStartBrick = s.SerializeObject<CListO<StringID>>(continueStartBrick, name: "continueStartBrick");
				lastBricks = s.SerializeObject<CListO<StringID>>(lastBricks, name: "lastBricks");
				difficultyRanges = s.SerializeObject<CListO<RO2_ChallengeCommon_Template.DifficultyRange>>(difficultyRanges, name: "difficultyRanges");
				gameplayRules = s.SerializeObject<CListO<RO2_EnduranceRule_Template>>(gameplayRules, name: "gameplayRules");
				filter = s.SerializeObject<CListP<string>>(filter, name: "filter");
				menuId = s.SerializeObject<StringID>(menuId, name: "menuId");
				debugMenuId = s.SerializeObject<StringID>(debugMenuId, name: "debugMenuId");
				countdownPath = s.SerializeObject<Path>(countdownPath, name: "countdownPath");
				inGameMusic = s.SerializeObject<Nullable<EventPlayMusic>>(inGameMusic, name: "inGameMusic");
				gameOverMusic = s.SerializeObject<Nullable<EventPlayMusic>>(gameOverMusic, name: "gameOverMusic");
				ghostDistanceMax = s.Serialize<float>(ghostDistanceMax, name: "ghostDistanceMax");
				ghostOffsetDistanceTeleportation = s.Serialize<float>(ghostOffsetDistanceTeleportation, name: "ghostOffsetDistanceTeleportation");
				difficultyChangeMusicEvents = s.SerializeObject<CListO<EventPlayMusic>>(difficultyChangeMusicEvents, name: "difficultyChangeMusicEvents");
			}
		}
		[Games(GameFlags.RA)]
		public partial class DifficultyRange : CSerializable {
			public StringID name;
			public float min;
			public float max;
			public float camSpeed;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				name = s.SerializeObject<StringID>(name, name: "name");
				min = s.Serialize<float>(min, name: "min");
				max = s.Serialize<float>(max, name: "max");
				camSpeed = s.Serialize<float>(camSpeed, name: "camSpeed");
			}
		}
		public override uint? ClassCRC => 0x7BD289BF;
	}
}

