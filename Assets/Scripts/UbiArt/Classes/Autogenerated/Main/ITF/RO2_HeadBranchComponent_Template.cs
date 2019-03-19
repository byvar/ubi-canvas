using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_HeadBranchComponent_Template : RO2_BezierBranchComponent_Template {
		[Serialize("headActor"       )] public Path headActor;
		[Serialize("headAttachOffset")] public float headAttachOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(headActor));
			SerializeField(s, nameof(headAttachOffset));
		}
		public override uint? ClassCRC => 0xAA947DB6;
	}
}

