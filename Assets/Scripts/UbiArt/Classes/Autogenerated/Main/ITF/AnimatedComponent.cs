using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AnimatedComponent : AnimLightComponent {
		[Serialize("DebugAnimTransition")] public bool DebugAnimTransition;
		[Serialize("EventPostComponents")] public CArray<Generic<Event>> EventPostComponents;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL || Settings.s.game == Settings.Game.VH) {
			} else {
				SerializeField(s, nameof(DebugAnimTransition));
				SerializeField(s, nameof(EventPostComponents));
			}
		}
		public override uint? ClassCRC => 0x62A12110;
	}
}

