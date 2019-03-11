using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayerIDInfo : CSerializable {
		[Serialize("id"                    )] public string id;
		[Serialize("family"                )] public string family;
		[Serialize("lineIdName"            )] public uint lineIdName;
		[Serialize("lineIdDescription"     )] public uint lineIdDescription;
		[Serialize("costumeIconAnimationId")] public uint costumeIconAnimationId;
		[Serialize("gameScreens"           )] public CList<PlayerIDInfo.GameScreenInfo> gameScreens;
		[Serialize("defaultGameScreenInfo" )] public PlayerIDInfo.GameScreenInfo defaultGameScreenInfo;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(gameScreens));
				SerializeField(s, nameof(defaultGameScreenInfo));
			} else {
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(family));
				SerializeField(s, nameof(lineIdName));
				SerializeField(s, nameof(lineIdDescription));
				SerializeField(s, nameof(costumeIconAnimationId));
				SerializeField(s, nameof(gameScreens));
				SerializeField(s, nameof(defaultGameScreenInfo));
			}
		}
		public partial class ActorInfo : CSerializable {
			[Serialize("file"               )] public Path file;
			[Serialize("isAlwaysActive"     )] public bool isAlwaysActive;
			[Serialize("isPlayable"         )] public bool isPlayable;
			[Serialize("gameModes"          )] public CList<uint> gameModes;
			[Serialize("isDynamicallyLoaded")] public bool isDynamicallyLoaded;
			[Serialize("mainGameMode"       )] public uint mainGameMode;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(file));
				SerializeField(s, nameof(isAlwaysActive));
				SerializeField(s, nameof(isPlayable));
				SerializeField(s, nameof(gameModes));
				SerializeField(s, nameof(isDynamicallyLoaded));
				SerializeField(s, nameof(mainGameMode));
			}
		}
		public partial class GameScreenInfo : CSerializable {
			[Serialize("gameScreen")] public StringID gameScreen;
			[Serialize("actors"    )] public CList<PlayerIDInfo.ActorInfo> actors;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(gameScreen));
				SerializeField(s, nameof(actors));
			}
		}
		public override uint? ClassCRC => 0x1F8C15FF;
	}
}

