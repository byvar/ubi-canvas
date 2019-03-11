using UnityEngine;

namespace UbiArt.ITF {
	public partial class BehaviorTreeDebugComponent : ActorComponent {
		[Serialize("EnbaleBreakPoints")] public bool EnbaleBreakPoints;
		[Serialize("BreakPointList"   )] public CList<BreakPointDesc> BreakPointList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(EnbaleBreakPoints));
			SerializeField(s, nameof(BreakPointList));
		}
		public override uint? ClassCRC => 0x2327B4BC;
	}
}

