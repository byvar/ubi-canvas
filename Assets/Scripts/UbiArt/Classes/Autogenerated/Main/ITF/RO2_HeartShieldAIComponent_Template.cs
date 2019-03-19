using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_HeartShieldAIComponent_Template : RO2_SimpleAIComponent_Template {
		[Serialize("appearBehavior")] public Generic<TemplateAIBehavior> appearBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(appearBehavior));
		}
		public override uint? ClassCRC => 0xAE0697CD;
	}
}

