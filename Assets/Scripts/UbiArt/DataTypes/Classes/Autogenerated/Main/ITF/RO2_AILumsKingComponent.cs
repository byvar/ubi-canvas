namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AILumsKingComponent : ActorComponent {
		public bool useReveal = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
			} else {
				useReveal = s.Serialize<bool>(useReveal, name: "useReveal");
			}
		}
		public override uint? ClassCRC => 0xC1778608;
	}
}

