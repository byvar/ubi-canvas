using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_FixedAIComponent_Template : Ray_AIComponent_Template {
		[Serialize("genericBehavior")] public Placeholder genericBehavior;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(genericBehavior));
		}
		public override uint? ClassCRC => 0xD214EB8A;
	}
}

