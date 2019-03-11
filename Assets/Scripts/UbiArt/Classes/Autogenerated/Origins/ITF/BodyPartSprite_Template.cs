using UnityEngine;

namespace UbiArt.ITF {
	public partial class BodyPartSprite_Template : BodyPartBase_Template {
		[Serialize("spriteRenderer")] public Placeholder spriteRenderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spriteRenderer));
		}
		public override uint? ClassCRC => 0xF31C7B2D;
	}
}

