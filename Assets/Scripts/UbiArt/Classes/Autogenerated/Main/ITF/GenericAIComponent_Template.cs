using UnityEngine;

namespace UbiArt.ITF {
	public partial class GenericAIComponent_Template : AIComponent_Template {
		[Serialize("genericBehavior")] public Generic<TemplateAIBehavior> genericBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(genericBehavior));
		}
		public override uint? ClassCRC => 0xCC485AD9;
	}
}

