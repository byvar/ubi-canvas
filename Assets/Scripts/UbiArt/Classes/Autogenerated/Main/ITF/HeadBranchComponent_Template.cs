using UnityEngine;

namespace UbiArt.ITF {
	public partial class HeadBranchComponent_Template : BezierBranchComponent_Template {
		[Serialize("headActor"       )] public Path headActor;
		[Serialize("headAttachOffset")] public float headAttachOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(headActor));
			SerializeField(s, nameof(headAttachOffset));
		}
		public override uint? ClassCRC => 0xE484ADB7;
	}
}

