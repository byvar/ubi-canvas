using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class BezierCurveComponent_Template : ActorComponent_Template {
		public bool lockFirstTangent;
		public uint defaultNodeCount;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			lockFirstTangent = s.Serialize<bool>(lockFirstTangent, name: "lockFirstTangent");
			defaultNodeCount = s.Serialize<uint>(defaultNodeCount, name: "defaultNodeCount");
		}
		public override uint? ClassCRC => 0x0537A1F8;
	}
}

