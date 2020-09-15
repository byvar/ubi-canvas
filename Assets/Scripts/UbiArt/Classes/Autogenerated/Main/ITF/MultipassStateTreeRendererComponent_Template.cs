using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class MultipassStateTreeRendererComponent_Template : GraphicComponent_Template {
		public CList<MultipassStateTreeRendererComponent_Template.PasseState> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			passes = s.SerializeObject<CList<MultipassStateTreeRendererComponent_Template.PasseState>>(passes, name: "passes");
		}
		[Games(GameFlags.RA)]
		public partial class PasseState : CSerializable {
			public BezierBranchRendererPass_Template startPasse;
			public BezierBranchRendererPass_Template loopPasse;
			public BezierBranchRendererPass_Template endPasse;
			public float loopMinTime;
			public float loopMaxTime;
			public float emptyMinTime;
			public float emptyMaxTime;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				startPasse = s.SerializeObject<BezierBranchRendererPass_Template>(startPasse, name: "startPasse");
				loopPasse = s.SerializeObject<BezierBranchRendererPass_Template>(loopPasse, name: "loopPasse");
				endPasse = s.SerializeObject<BezierBranchRendererPass_Template>(endPasse, name: "endPasse");
				loopMinTime = s.Serialize<float>(loopMinTime, name: "loopMinTime");
				loopMaxTime = s.Serialize<float>(loopMaxTime, name: "loopMaxTime");
				emptyMinTime = s.Serialize<float>(emptyMinTime, name: "emptyMinTime");
				emptyMaxTime = s.Serialize<float>(emptyMaxTime, name: "emptyMaxTime");
			}
		}
		public override uint? ClassCRC => 0x8455897C;
	}
}

