using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class GenericAIComponent_Template : AIComponent_Template {
		[Serialize("genericBehavior")] public Generic<TemplateAIBehavior> genericBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(genericBehavior));
		}
		public override uint? ClassCRC => 0xCC485AD9;
	}
}

