using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_LivingstoneHatAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("roamBehavior"    )] public Generic<TemplateAIBehavior> roamBehavior;
		[Serialize("floatingBehavior")] public Generic<Ray_AIWaterBaseBehavior_Template> floatingBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(roamBehavior));
			SerializeField(s, nameof(floatingBehavior));
		}
		public override uint? ClassCRC => 0x86C46ABD;
	}
}

