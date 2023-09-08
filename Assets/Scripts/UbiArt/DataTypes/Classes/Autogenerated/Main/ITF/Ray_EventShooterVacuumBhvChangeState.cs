namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventShooterVacuumBhvChangeState : Event {
		public uint state;
		public Vec2d spitForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RFR) {
				state = s.Serialize<uint>(state, name: "state");
				spitForce = s.SerializeObject<Vec2d>(spitForce, name: "spitForce");
			} else {
				state = s.Serialize<uint>(state, name: "state");
			}
		}
		public override uint? ClassCRC => 0x804FEEEE;
	}
}

