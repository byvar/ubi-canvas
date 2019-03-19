using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BezierCurveComponent_Template : ActorComponent_Template {
		[Serialize("lockFirstTangent")] public bool lockFirstTangent;
		[Serialize("defaultNodeCount")] public uint defaultNodeCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(lockFirstTangent));
			SerializeField(s, nameof(defaultNodeCount));
		}
		public override uint? ClassCRC => 0x0537A1F8;
	}
}

