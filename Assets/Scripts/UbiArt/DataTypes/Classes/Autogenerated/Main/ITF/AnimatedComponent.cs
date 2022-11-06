using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimatedComponent : AnimLightComponent {
		public bool DebugAnimTransition;
		public CArrayO<Generic<Event>> EventPostComponents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL || s.Settings.game == Settings.Game.VH) {
			} else {
				DebugAnimTransition = s.Serialize<bool>(DebugAnimTransition, name: "DebugAnimTransition");
				EventPostComponents = s.SerializeObject<CArrayO<Generic<Event>>>(EventPostComponents, name: "EventPostComponents");
			}
		}
		public override uint? ClassCRC => 0x62A12110;
	}
}

