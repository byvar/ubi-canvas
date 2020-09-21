using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AnimatedWithSubstitionTemplatesComponent : AnimatedComponent {
		public CListO<AnimatedWithSubstitionTemplatesComponent.AnimSubstsTemplate> AnimSbustitionTemplates;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			AnimSbustitionTemplates = s.SerializeObject<CListO<AnimatedWithSubstitionTemplatesComponent.AnimSubstsTemplate>>(AnimSbustitionTemplates, name: "AnimSbustitionTemplates");
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class AnimSubst : CSerializable {
			public StringID original;
			public StringID final;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				original = s.SerializeObject<StringID>(original, name: "original");
				final = s.SerializeObject<StringID>(final, name: "final");
			}
		}
		[Games(GameFlags.RA | GameFlags.VH)]
		public partial class AnimSubstsTemplate : CSerializable {
			public CListO<AnimatedWithSubstitionTemplatesComponent.AnimSubst> substitutedAnimsList;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				substitutedAnimsList = s.SerializeObject<CListO<AnimatedWithSubstitionTemplatesComponent.AnimSubst>>(substitutedAnimsList, name: "substitutedAnimsList");
			}
		}
		public override uint? ClassCRC => 0x9D1DBAC6;
	}
}

