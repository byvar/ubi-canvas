using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_FixedAIComponent_Template : Ray_AIComponent_Template {
		public Generic<TemplateAIBehavior> genericBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			genericBehavior = s.SerializeObject<Generic<TemplateAIBehavior>>(genericBehavior, name: "genericBehavior");
		}
		public override uint? ClassCRC => 0xD214EB8A;
	}
}

