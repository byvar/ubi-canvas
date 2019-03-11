using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_FixedAIComponent_Template : RO2_AIComponent_Template {
		[Serialize("genericBehavior")] public Generic<TemplateAIBehavior> genericBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(genericBehavior));
		}
		public override uint? ClassCRC => 0x4751FF08;
	}
}

