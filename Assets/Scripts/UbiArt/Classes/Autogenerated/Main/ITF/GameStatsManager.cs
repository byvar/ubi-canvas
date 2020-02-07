using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class GameStatsManager : CSerializable {
		[Serialize("GameStatsManager.SaveSession__0")] public GameStatsManager.SaveSession GameStatsManager_SaveSession__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(GameStatsManager_SaveSession__0));
			} else {
			}
		}
		[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
		public partial class SaveSession : CSerializable {
			[Serialize("tags"             )] public CList<float> tags;
			[Serialize("timers"           )] public CList<float> timers;
			[Serialize("rewardsState"     )] public CMap<StringID, bool> rewardsState;
			[Serialize("uplayRewardsState")] public CMap<StringID, bool> uplayRewardsState;
			[Serialize("uplayActionsState")] public CMap<StringID, uint> uplayActionsState;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(tags));
				SerializeField(s, nameof(timers));
				SerializeField(s, nameof(rewardsState));
				if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.VH) {
					SerializeField(s, nameof(uplayRewardsState));
					SerializeField(s, nameof(uplayActionsState));
				}
			}
		}
	}
}

