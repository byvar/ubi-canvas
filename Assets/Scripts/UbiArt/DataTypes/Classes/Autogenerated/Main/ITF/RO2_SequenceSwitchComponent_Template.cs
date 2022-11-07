namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SequenceSwitchComponent_Template : ActorComponent_Template {
		public int reverse;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				reverse = s.Serialize<int>(reverse, name: "reverse");
			} else {
			}
		}
		public override uint? ClassCRC => 0x2EC686A8;
	}
}

