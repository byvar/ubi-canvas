using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class GameStatsManager : CSerializable {
		public GameStatsManager.SaveSession GameStatsManager_SaveSession__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.VH) {
				GameStatsManager_SaveSession__0 = s.SerializeObject<GameStatsManager.SaveSession>(GameStatsManager_SaveSession__0, name: "GameStatsManager.SaveSession__0");
			} else {
			}
		}
		[Games(GameFlags.RL | GameFlags.VH | GameFlags.RA)]
		public partial class SaveSession : CSerializable {
			public CListP<float> tags;
			public CListP<float> timers;
			public CMap<StringID, bool> rewardsState;
			public CMap<StringID, bool> uplayRewardsState;
			public CMap<StringID, uint> uplayActionsState;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				tags = s.SerializeObject<CListP<float>>(tags, name: "tags");
				timers = s.SerializeObject<CListP<float>>(timers, name: "timers");
				if (s.Settings.engineVersion > Settings.EngineVersion.RO) {
					rewardsState = s.SerializeObject<CMap<StringID, bool>>(rewardsState, name: "rewardsState");
					if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM || s.Settings.game == Settings.Game.VH) {
						uplayRewardsState = s.SerializeObject<CMap<StringID, bool>>(uplayRewardsState, name: "uplayRewardsState");
						uplayActionsState = s.SerializeObject<CMap<StringID, uint>>(uplayActionsState, name: "uplayActionsState");
					}
				}
			}
		}
	}
}

