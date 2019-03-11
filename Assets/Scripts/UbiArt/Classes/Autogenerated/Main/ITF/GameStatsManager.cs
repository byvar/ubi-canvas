using UnityEngine;

namespace UbiArt.ITF {
	public partial class GameStatsManager : CSerializable {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
		}
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
				SerializeField(s, nameof(uplayRewardsState));
				SerializeField(s, nameof(uplayActionsState));
			}
		}
	}
}

