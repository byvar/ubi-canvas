using UnityEngine;

namespace UbiArt.ITF {
	public partial class BubblePrizeContent_Template : CSerializable {
		[Serialize("popEvent"                )] public Generic<Event> popEvent;
		[Serialize("popEventPainted"         )] public Generic<Event> popEventPainted;
		[Serialize("popSpawn"                )] public Path popSpawn;
		[Serialize("rewardNumberChangeEnable")] public bool rewardNumberChangeEnable;
		[Serialize("contentPopType"          )] public ContentPopType contentPopType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(popEvent));
			SerializeField(s, nameof(popEventPainted));
			SerializeField(s, nameof(popSpawn));
			SerializeField(s, nameof(rewardNumberChangeEnable));
			SerializeField(s, nameof(contentPopType));
		}
		public enum ContentPopType {
			[Serialize("ContentPopType_None"             )] None = 0,
			[Serialize("ContentPopType_ClassicPlayer"    )] ClassicPlayer = 1,
			[Serialize("ContentPopType_TouchScreenPlayer")] TouchScreenPlayer = 2,
			[Serialize("ContentPopType_All"              )] All = 3,
		}
	}
}

