using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_LivingstoneHatAIComponent_Template : Ray_AIComponent_Template {
		public Generic<TemplateAIBehavior> roamBehavior;
		public Generic<Ray_AIWaterBaseBehavior_Template> floatingBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			roamBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(roamBehavior, name: "roamBehavior");
			floatingBehavior = s.SerializeObject<Generic<Ray_AIWaterBaseBehavior_Template>>(floatingBehavior, name: "floatingBehavior");
		}
		public override uint? ClassCRC => 0x86C46ABD;
	}
}

