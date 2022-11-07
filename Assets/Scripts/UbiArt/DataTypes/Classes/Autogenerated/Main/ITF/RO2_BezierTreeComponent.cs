namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_BezierTreeComponent : ActorComponent {
		public RO2_BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				branch = s.SerializeObject<RO2_BezierBranch>(branch, name: "branch");
			}
		}
		public override uint? ClassCRC => 0x760B164E;
	}
}

