namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_ReversibleHeadComponent_Template : ActorComponent_Template {
		public bool bad;
		public StringID hiddenAnimation;
		public StringID revealedAnimation;
		public StringID activatedAnimation;
		public StringID hiddenToRevealedAnimation;
		public StringID hiddenToActivatedAnimation;
		public StringID revealedToHiddenAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			bad = s.Serialize<bool>(bad, name: "bad");
			hiddenAnimation = s.SerializeObject<StringID>(hiddenAnimation, name: "hiddenAnimation");
			revealedAnimation = s.SerializeObject<StringID>(revealedAnimation, name: "revealedAnimation");
			activatedAnimation = s.SerializeObject<StringID>(activatedAnimation, name: "activatedAnimation");
			hiddenToRevealedAnimation = s.SerializeObject<StringID>(hiddenToRevealedAnimation, name: "hiddenToRevealedAnimation");
			hiddenToActivatedAnimation = s.SerializeObject<StringID>(hiddenToActivatedAnimation, name: "hiddenToActivatedAnimation");
			revealedToHiddenAnimation = s.SerializeObject<StringID>(revealedToHiddenAnimation, name: "revealedToHiddenAnimation");
		}
		public override uint? ClassCRC => 0x12EBD2AB;
	}
}

