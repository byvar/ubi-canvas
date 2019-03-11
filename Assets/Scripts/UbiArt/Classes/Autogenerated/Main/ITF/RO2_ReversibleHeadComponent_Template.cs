using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_ReversibleHeadComponent_Template : ActorComponent_Template {
		[Serialize("bad"                       )] public bool bad;
		[Serialize("hiddenAnimation"           )] public StringID hiddenAnimation;
		[Serialize("revealedAnimation"         )] public StringID revealedAnimation;
		[Serialize("activatedAnimation"        )] public StringID activatedAnimation;
		[Serialize("hiddenToRevealedAnimation" )] public StringID hiddenToRevealedAnimation;
		[Serialize("hiddenToActivatedAnimation")] public StringID hiddenToActivatedAnimation;
		[Serialize("revealedToHiddenAnimation" )] public StringID revealedToHiddenAnimation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bad));
			SerializeField(s, nameof(hiddenAnimation));
			SerializeField(s, nameof(revealedAnimation));
			SerializeField(s, nameof(activatedAnimation));
			SerializeField(s, nameof(hiddenToRevealedAnimation));
			SerializeField(s, nameof(hiddenToActivatedAnimation));
			SerializeField(s, nameof(revealedToHiddenAnimation));
		}
		public override uint? ClassCRC => 0x12EBD2AB;
	}
}

