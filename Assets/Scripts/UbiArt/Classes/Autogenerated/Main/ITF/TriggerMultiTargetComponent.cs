using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class TriggerMultiTargetComponent : ActorComponent {
		public CList<MultiTargetEvent> onEnterEvents;
		public CList<MultiTargetUpdateEvent> onStayEvents;
		public CList<MultiTargetEvent> onExitEvents;
		public bool AlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onEnterEvents = s.SerializeObject<CList<MultiTargetEvent>>(onEnterEvents, name: "onEnterEvents");
			onStayEvents = s.SerializeObject<CList<MultiTargetUpdateEvent>>(onStayEvents, name: "onStayEvents");
			onExitEvents = s.SerializeObject<CList<MultiTargetEvent>>(onExitEvents, name: "onExitEvents");
			AlwaysActive = s.Serialize<bool>(AlwaysActive, name: "AlwaysActive");
		}
		public override uint? ClassCRC => 0x01A4CB72;
	}
}

