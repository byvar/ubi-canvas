using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIWaterBaseBehavior_Template : TemplateAIBehavior {
		public float gravityMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravityMultiplier = s.Serialize<float>(gravityMultiplier, name: "gravityMultiplier");
		}
		public override uint? ClassCRC => 0xB6B5A38A;
	}
}

