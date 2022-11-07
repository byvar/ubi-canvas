namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BTActionSpotTarget_Template : BTAction_Template {
		public Generic<PhysShape> enemyDetectionRange;
		public StringID animSpot;
		public StringID animFight;
		public StringID animUTurn;
		public float timingStaySpotting;
		public bool disableUTurn;
		public bool debug;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			enemyDetectionRange = s.SerializeObject<Generic<PhysShape>>(enemyDetectionRange, name: "enemyDetectionRange");
			animSpot = s.SerializeObject<StringID>(animSpot, name: "animSpot");
			animFight = s.SerializeObject<StringID>(animFight, name: "animFight");
			animUTurn = s.SerializeObject<StringID>(animUTurn, name: "animUTurn");
			timingStaySpotting = s.Serialize<float>(timingStaySpotting, name: "timingStaySpotting");
			disableUTurn = s.Serialize<bool>(disableUTurn, name: "disableUTurn");
			debug = s.Serialize<bool>(debug, name: "debug");
		}
		public override uint? ClassCRC => 0x0BF8D095;
	}
}

