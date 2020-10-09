using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PlayerControllerComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> phantomShape;
		public uint faction;
		public uint deadSoulFaction;
		public float touchReviveInteractionCircleRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				phantomShape = s.SerializeObject<Generic<PhysShape>>(phantomShape, name: "phantomShape");
				faction = s.Serialize<uint>(faction, name: "faction");
				deadSoulFaction = s.Serialize<uint>(deadSoulFaction, name: "deadSoulFaction");
			} else if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				phantomShape = s.SerializeObject<Generic<PhysShape>>(phantomShape, name: "phantomShape");
				faction = s.Serialize<uint>(faction, name: "faction");
				deadSoulFaction = s.Serialize<uint>(deadSoulFaction, name: "deadSoulFaction");
				touchReviveInteractionCircleRadius = s.Serialize<float>(touchReviveInteractionCircleRadius, name: "touchReviveInteractionCircleRadius");
			} else {
				phantomShape = s.SerializeObject<Generic<PhysShape>>(phantomShape, name: "phantomShape");
				faction = s.Serialize<uint>(faction, name: "faction");
			}
		}
		public override uint? ClassCRC => 0x06654841;
	}
}

