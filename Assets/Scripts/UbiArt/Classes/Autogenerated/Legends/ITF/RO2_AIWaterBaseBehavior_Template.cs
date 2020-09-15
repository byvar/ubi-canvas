using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_AIWaterBaseBehavior_Template : TemplateAIBehavior {
		public float gravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
		}
		public override uint? ClassCRC => 0x4A1E5871;
	}
}

