using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIRedWizardPedestalBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("idle"        )] public Placeholder idle;
		[Serialize("supportBone" )] public StringID supportBone;
		[Serialize("gameMaterial")] public Path gameMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(idle));
			SerializeField(s, nameof(supportBone));
			SerializeField(s, nameof(gameMaterial));
		}
		public override uint? ClassCRC => 0x98A688C6;
	}
}

