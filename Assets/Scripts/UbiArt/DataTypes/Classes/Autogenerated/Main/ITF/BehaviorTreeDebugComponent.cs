namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class BehaviorTreeDebugComponent : ActorComponent {
		public bool EnbaleBreakPoints;
		public CListO<BreakPointDesc> BreakPointList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			EnbaleBreakPoints = s.Serialize<bool>(EnbaleBreakPoints, name: "EnbaleBreakPoints");
			BreakPointList = s.SerializeObject<CListO<BreakPointDesc>>(BreakPointList, name: "BreakPointList");
		}
		public override uint? ClassCRC => 0x2327B4BC;
	}
}

