namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_DrcLifeElementComponent_Template : ActorComponent_Template {
		public int requireActivationTrigger;
		public int oneShotAnimation;
		public uint lumsToGive;
		public float drcDetectionShapeRadius;
		public bool canReInit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			requireActivationTrigger = s.Serialize<int>(requireActivationTrigger, name: "requireActivationTrigger");
			oneShotAnimation = s.Serialize<int>(oneShotAnimation, name: "oneShotAnimation");
			lumsToGive = s.Serialize<uint>(lumsToGive, name: "lumsToGive");
			drcDetectionShapeRadius = s.Serialize<float>(drcDetectionShapeRadius, name: "drcDetectionShapeRadius");
			canReInit = s.Serialize<bool>(canReInit, name: "canReInit");
		}
		public override uint? ClassCRC => 0xA7E2FA94;
	}
}

