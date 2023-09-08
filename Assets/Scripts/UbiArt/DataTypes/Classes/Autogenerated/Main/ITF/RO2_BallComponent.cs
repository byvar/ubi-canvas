namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_BallComponent : ActorComponent {
		public bool disableWindForce = true;
		public bool startWithHalo;
		public float bounceMultiplier = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					disableWindForce = s.Serialize<bool>(disableWindForce, name: "disableWindForce", options: CSerializerObject.Options.BoolAsByte);
					startWithHalo = s.Serialize<bool>(startWithHalo, name: "startWithHalo", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					disableWindForce = s.Serialize<bool>(disableWindForce, name: "disableWindForce");
					startWithHalo = s.Serialize<bool>(startWithHalo, name: "startWithHalo");
					bounceMultiplier = s.Serialize<float>(bounceMultiplier, name: "bounceMultiplier");
				}
			}
		}
		public override uint? ClassCRC => 0x8499FE21;
	}
}

