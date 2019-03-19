using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class MultipassStateTreeRendererComponent_Template : GraphicComponent_Template {
		[Serialize("passes")] public CList<MultipassStateTreeRendererComponent_Template.PasseState> passes;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(passes));
		}
		[Games(GameFlags.RA)]
		public partial class PasseState : CSerializable {
			[Serialize("startPasse"  )] public BezierBranchRendererPass_Template startPasse;
			[Serialize("loopPasse"   )] public BezierBranchRendererPass_Template loopPasse;
			[Serialize("endPasse"    )] public BezierBranchRendererPass_Template endPasse;
			[Serialize("loopMinTime" )] public float loopMinTime;
			[Serialize("loopMaxTime" )] public float loopMaxTime;
			[Serialize("emptyMinTime")] public float emptyMinTime;
			[Serialize("emptyMaxTime")] public float emptyMaxTime;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(startPasse));
				SerializeField(s, nameof(loopPasse));
				SerializeField(s, nameof(endPasse));
				SerializeField(s, nameof(loopMinTime));
				SerializeField(s, nameof(loopMaxTime));
				SerializeField(s, nameof(emptyMinTime));
				SerializeField(s, nameof(emptyMaxTime));
			}
		}
		public override uint? ClassCRC => 0x8455897C;
	}
}

