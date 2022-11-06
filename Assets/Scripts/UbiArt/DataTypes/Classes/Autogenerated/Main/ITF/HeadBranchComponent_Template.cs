using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class HeadBranchComponent_Template : BezierBranchComponent_Template {
		public Path headActor;
		public float headAttachOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			headActor = s.SerializeObject<Path>(headActor, name: "headActor");
			headAttachOffset = s.Serialize<float>(headAttachOffset, name: "headAttachOffset");
		}
		public override uint? ClassCRC => 0xE484ADB7;
	}
}

