using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIOceanSpiderBehavior_Template : TemplateAIBehavior {
		[Serialize("Actions"             )] public Placeholder Actions;
		[Serialize("Instructions"        )] public Placeholder Instructions;
		[Serialize("InactiveInstructions")] public Placeholder InactiveInstructions;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Actions));
			SerializeField(s, nameof(Instructions));
			SerializeField(s, nameof(InactiveInstructions));
		}
		public override uint? ClassCRC => 0x70445B7F;
	}
}

