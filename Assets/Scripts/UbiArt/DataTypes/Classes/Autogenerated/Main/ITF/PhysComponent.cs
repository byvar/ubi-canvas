namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PhysComponent : ActorComponent {
		public float Mass = 1f;
		public float Friction = 0.5f;
		public float FrictionMultiplier = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RO || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RL || s.Settings.Game == Game.COL) {
			} else {
				Mass = s.Serialize<float>(Mass, name: "Mass");
				Friction = s.Serialize<float>(Friction, name: "Friction");
				FrictionMultiplier = s.Serialize<float>(FrictionMultiplier, name: "FrictionMultiplier");
			}
		}
		public override uint? ClassCRC => 0x4CABF630;
	}
}

