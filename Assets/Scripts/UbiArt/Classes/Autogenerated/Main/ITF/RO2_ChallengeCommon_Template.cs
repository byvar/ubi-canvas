using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ChallengeCommon_Template : TemplateObj {
		[Serialize("name"                            )] public StringID name;
		[Serialize("unitSize"                        )] public Vector2 unitSize;
		[Serialize("gameplayBricks"                  )] public CArray<Generic<RO2_Brick_Template>> gameplayBricks;
		[Serialize("initialSpawnCount"               )] public uint initialSpawnCount;
		[Serialize("duplicateSpawnCooldown"          )] public uint duplicateSpawnCooldown;
		[Serialize("firstBricks"                     )] public CList<StringID> firstBricks;
		[Serialize("continueStartBrick"              )] public CList<StringID> continueStartBrick;
		[Serialize("lastBricks"                      )] public CList<StringID> lastBricks;
		[Serialize("difficultyRanges"                )] public CList<RO2_ChallengeCommon_Template.DifficultyRange> difficultyRanges;
		[Serialize("gameplayRules"                   )] public CList<RO2_EnduranceRule_Template> gameplayRules;
		[Serialize("filter"                          )] public CList<string> filter;
		[Serialize("menuId"                          )] public StringID menuId;
		[Serialize("debugMenuId"                     )] public StringID debugMenuId;
		[Serialize("countdownPath"                   )] public Path countdownPath;
		[Serialize("inGameMusic"                     )] public Nullable<EventPlayMusic> inGameMusic;
		[Serialize("gameOverMusic"                   )] public Nullable<EventPlayMusic> gameOverMusic;
		[Serialize("ghostDistanceMax"                )] public float ghostDistanceMax;
		[Serialize("ghostOffsetDistanceTeleportation")] public float ghostOffsetDistanceTeleportation;
		[Serialize("difficultyChangeMusicEvents"     )] public CList<EventPlayMusic> difficultyChangeMusicEvents;
		[Serialize("filterOrder"                     )] public CList<CList<string>> filterOrder;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(unitSize));
				SerializeField(s, nameof(gameplayBricks));
				SerializeField(s, nameof(initialSpawnCount));
				SerializeField(s, nameof(duplicateSpawnCooldown));
				SerializeField(s, nameof(firstBricks));
				SerializeField(s, nameof(lastBricks));
				SerializeField(s, nameof(difficultyRanges));
				SerializeField(s, nameof(gameplayRules));
				SerializeField(s, nameof(filter));
				SerializeField(s, nameof(filterOrder));
				SerializeField(s, nameof(menuId));
				SerializeField(s, nameof(debugMenuId));
				SerializeField(s, nameof(countdownPath));
				SerializeField(s, nameof(inGameMusic));
				SerializeField(s, nameof(gameOverMusic));
				SerializeField(s, nameof(ghostDistanceMax));
				SerializeField(s, nameof(ghostOffsetDistanceTeleportation));
				SerializeField(s, nameof(difficultyChangeMusicEvents));
			} else {
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(unitSize));
				SerializeField(s, nameof(gameplayBricks));
				SerializeField(s, nameof(initialSpawnCount));
				SerializeField(s, nameof(duplicateSpawnCooldown));
				SerializeField(s, nameof(firstBricks));
				SerializeField(s, nameof(continueStartBrick));
				SerializeField(s, nameof(lastBricks));
				SerializeField(s, nameof(difficultyRanges));
				SerializeField(s, nameof(gameplayRules));
				SerializeField(s, nameof(filter));
				SerializeField(s, nameof(menuId));
				SerializeField(s, nameof(debugMenuId));
				SerializeField(s, nameof(countdownPath));
				SerializeField(s, nameof(inGameMusic));
				SerializeField(s, nameof(gameOverMusic));
				SerializeField(s, nameof(ghostDistanceMax));
				SerializeField(s, nameof(ghostOffsetDistanceTeleportation));
				SerializeField(s, nameof(difficultyChangeMusicEvents));
			}
		}
		[Games(GameFlags.RA)]
		public partial class DifficultyRange : CSerializable {
			[Serialize("name"    )] public StringID name;
			[Serialize("min"     )] public float min;
			[Serialize("max"     )] public float max;
			[Serialize("camSpeed")] public float camSpeed;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(name));
				SerializeField(s, nameof(min));
				SerializeField(s, nameof(max));
				SerializeField(s, nameof(camSpeed));
			}
		}
		public override uint? ClassCRC => 0x7BD289BF;
	}
}

