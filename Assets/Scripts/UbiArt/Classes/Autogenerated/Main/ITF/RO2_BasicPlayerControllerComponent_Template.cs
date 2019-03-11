using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_BasicPlayerControllerComponent_Template : PlayerControllerComponent_Template {
		[Serialize("deadSoulFaction"                   )] public uint deadSoulFaction;
		[Serialize("touchReviveInteractionCircleRadius")] public float touchReviveInteractionCircleRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
			} else {
				SerializeField(s, nameof(deadSoulFaction));
				SerializeField(s, nameof(touchReviveInteractionCircleRadius));
			}
		}
		public override uint? ClassCRC => 0xAD13B185;
	}
}

