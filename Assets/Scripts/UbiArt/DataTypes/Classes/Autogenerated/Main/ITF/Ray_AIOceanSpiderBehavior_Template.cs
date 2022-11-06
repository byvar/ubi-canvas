using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIOceanSpiderBehavior_Template : TemplateAIBehavior {
		public Placeholder Actions;
		public Placeholder Instructions;
		public Placeholder InactiveInstructions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Actions = s.SerializeObject<Placeholder>(Actions, name: "Actions");
			Instructions = s.SerializeObject<Placeholder>(Instructions, name: "Instructions");
			InactiveInstructions = s.SerializeObject<Placeholder>(InactiveInstructions, name: "InactiveInstructions");
		}
		public override uint? ClassCRC => 0x70445B7F;
	}
}

