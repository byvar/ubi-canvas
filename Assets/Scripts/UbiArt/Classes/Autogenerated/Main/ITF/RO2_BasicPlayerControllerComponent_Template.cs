using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BasicPlayerControllerComponent_Template : PlayerControllerComponent_Template {
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RA || Settings.s.game == Settings.Game.VH) {
				SerializeField(s, nameof(deadSoulFaction));
				SerializeField(s, nameof(touchReviveInteractionCircleRadius));
			}
		}
		public override uint? ClassCRC => 0xAD13B185;
	}
}

