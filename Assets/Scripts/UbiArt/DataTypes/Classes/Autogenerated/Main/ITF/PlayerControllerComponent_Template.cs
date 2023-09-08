namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PlayerControllerComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> phantomShape;
		public uint faction = 1;
		public uint deadSoulFaction = 1;
		public float touchReviveInteractionCircleRadius = 1.5f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
				phantomShape = s.SerializeObject<Generic<PhysShape>>(phantomShape, name: "phantomShape");
				faction = s.Serialize<uint>(faction, name: "faction");
				deadSoulFaction = s.Serialize<uint>(deadSoulFaction, name: "deadSoulFaction");
			} else if (s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
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

