using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlayerControllerComponent_Template : ActorComponent_Template {
		[Serialize("phantomShape"                      )] public Generic<PhysShape> phantomShape;
		[Serialize("faction"                           )] public uint faction;
		[Serialize("deadSoulFaction"                   )] public uint deadSoulFaction;
		[Serialize("touchReviveInteractionCircleRadius")] public float touchReviveInteractionCircleRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(phantomShape));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(deadSoulFaction));
			} else if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(phantomShape));
				SerializeField(s, nameof(faction));
				SerializeField(s, nameof(deadSoulFaction));
				SerializeField(s, nameof(touchReviveInteractionCircleRadius));
			} else {
				SerializeField(s, nameof(phantomShape));
				SerializeField(s, nameof(faction));
			}
		}
		public override uint? ClassCRC => 0x06654841;
	}
}

