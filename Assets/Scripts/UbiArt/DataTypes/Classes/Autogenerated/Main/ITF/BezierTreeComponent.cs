namespace UbiArt.ITF {
	[Games(GameFlags.COL | GameFlags.RA)]
	public partial class BezierTreeComponent : ActorComponent {
		public BezierBranch branch;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				branch = s.SerializeObject<BezierBranch>(branch, name: "branch");
			}
		}
		public override uint? ClassCRC => 0x3236CF4C;
	}
}

