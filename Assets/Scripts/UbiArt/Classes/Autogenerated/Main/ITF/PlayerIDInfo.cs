using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayerIDInfo : CSerializable {
		[Serialize("id"                                    )] public string id;
		[Serialize("family"                                )] public string family;
		[Serialize("lineIdName"                            )] public uint lineIdName;
		[Serialize("lineIdDescription"                     )] public uint lineIdDescription;
		[Serialize("costumeIconAnimationId"                )] public uint costumeIconAnimationId;
		[Serialize("gameScreens"                           )] public CList<PlayerIDInfo.GameScreenInfo> gameScreens;
		[Serialize("defaultGameScreenInfo"                 )] public PlayerIDInfo.GameScreenInfo defaultGameScreenInfo;
		[Serialize("PlayerIDInfo.ActorInfo__0"             )] public PlayerIDInfo.ActorInfo PlayerIDInfo_ActorInfo__0;
		[Serialize("string__1"                             )] public string string__1;
		[Serialize("string__2"                             )] public string string__2;
		[Serialize("CArray<PlayerIDInfo.GameScreenInfo>__3")] public CArray<PlayerIDInfo.GameScreenInfo> CArray_PlayerIDInfo_GameScreenInfo__3;
		[Serialize("PlayerIDInfo.GameScreenInfo__4"        )] public PlayerIDInfo.GameScreenInfo PlayerIDInfo_GameScreenInfo__4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(gameScreens));
				SerializeField(s, nameof(defaultGameScreenInfo));
			} else if (Settings.s.game == Settings.Game.COL) {
			} else if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(PlayerIDInfo_ActorInfo__0));
				SerializeField(s, nameof(string__1));
				SerializeField(s, nameof(string__2));
				SerializeField(s, nameof(CArray_PlayerIDInfo_GameScreenInfo__3));
				SerializeField(s, nameof(PlayerIDInfo_GameScreenInfo__4));
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
		[Games(GameFlags.RA | GameFlags.VH)]
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
		[Games(GameFlags.RA | GameFlags.VH)]
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

