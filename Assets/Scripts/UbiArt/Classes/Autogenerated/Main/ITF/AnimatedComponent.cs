using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimatedComponent : AnimLightComponent {
		public bool DebugAnimTransition;
		public CArrayO<Generic<Event>> EventPostComponents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
			} else {
				DebugAnimTransition = s.Serialize<bool>(DebugAnimTransition, name: "DebugAnimTransition");
				EventPostComponents = s.SerializeObject<CArrayO<Generic<Event>>>(EventPostComponents, name: "EventPostComponents");
			}
		}
		public override uint? ClassCRC => 0x62A12110;
	}
}

