using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class TriggerMultiTargetComponent : ActorComponent {
		public CListO<MultiTargetEvent> onEnterEvents;
		public CListO<MultiTargetUpdateEvent> onStayEvents;
		public CListO<MultiTargetEvent> onExitEvents;
		public bool AlwaysActive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			onEnterEvents = s.SerializeObject<CListO<MultiTargetEvent>>(onEnterEvents, name: "onEnterEvents");
			onStayEvents = s.SerializeObject<CListO<MultiTargetUpdateEvent>>(onStayEvents, name: "onStayEvents");
			onExitEvents = s.SerializeObject<CListO<MultiTargetEvent>>(onExitEvents, name: "onExitEvents");
			AlwaysActive = s.Serialize<bool>(AlwaysActive, name: "AlwaysActive");
		}
		public override uint? ClassCRC => 0x01A4CB72;
	}
}

