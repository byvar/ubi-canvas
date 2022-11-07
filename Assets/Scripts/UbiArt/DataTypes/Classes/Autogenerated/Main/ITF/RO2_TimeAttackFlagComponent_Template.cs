namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_TimeAttackFlagComponent_Template : ActorComponent_Template {
		public float waitTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			waitTime = s.Serialize<float>(waitTime, name: "waitTime");
		}
		public override uint? ClassCRC => 0xF4E61B56;
	}
}

