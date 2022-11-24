namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class PhysComponent : ActorComponent {
		public float Mass = 1f;
		public float Friction = 0.5f;
		public float FrictionMultiplier = 1f;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RJR || s.Settings.game == Settings.Game.RO || s.Settings.game == Settings.Game.RFR || s.Settings.game == Settings.Game.RL || s.Settings.game == Settings.Game.COL) {
			} else {
				Mass = s.Serialize<float>(Mass, name: "Mass");
				Friction = s.Serialize<float>(Friction, name: "Friction");
				FrictionMultiplier = s.Serialize<float>(FrictionMultiplier, name: "FrictionMultiplier");
			}
		}
		public override uint? ClassCRC => 0x4CABF630;
	}
}

