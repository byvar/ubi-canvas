using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIRedWizardPedestalBehavior_Template : TemplateAIBehavior {
		public Placeholder idle;
		public StringID supportBone;
		public Path gameMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			idle = s.SerializeObject<Placeholder>(idle, name: "idle");
			supportBone = s.SerializeObject<StringID>(supportBone, name: "supportBone");
			gameMaterial = s.SerializeObject<Path>(gameMaterial, name: "gameMaterial");
		}
		public override uint? ClassCRC => 0x98A688C6;
	}
}

