namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_TeensyRocketComponent : ActorComponent {
		public float time = 60;
		public bool displayRope = true;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				time = s.Serialize<float>(time, name: "time");
			} else {
				time = s.Serialize<float>(time, name: "time");
				displayRope = s.Serialize<bool>(displayRope, name: "displayRope");
			}
		}
		public override uint? ClassCRC => 0x7333CF6D;
	}
}

