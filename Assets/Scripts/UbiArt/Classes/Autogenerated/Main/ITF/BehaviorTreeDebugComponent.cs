using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class BehaviorTreeDebugComponent : ActorComponent {
		public bool EnbaleBreakPoints;
		public CList<BreakPointDesc> BreakPointList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			EnbaleBreakPoints = s.Serialize<bool>(EnbaleBreakPoints, name: "EnbaleBreakPoints");
			BreakPointList = s.SerializeObject<CList<BreakPointDesc>>(BreakPointList, name: "BreakPointList");
		}
		public override uint? ClassCRC => 0x2327B4BC;
	}
}

