using UnityEngine;

namespace UbiArt.ITF {
	public partial class TriggerMultiTargetComponent : ActorComponent {
		[Serialize("onEnterEvents")] public CList<MultiTargetEvent> onEnterEvents;
		[Serialize("onStayEvents" )] public CList<MultiTargetUpdateEvent> onStayEvents;
		[Serialize("onExitEvents" )] public CList<MultiTargetEvent> onExitEvents;
		[Serialize("AlwaysActive" )] public bool AlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(onEnterEvents));
			SerializeField(s, nameof(onStayEvents));
			SerializeField(s, nameof(onExitEvents));
			SerializeField(s, nameof(AlwaysActive));
		}
	}
}

