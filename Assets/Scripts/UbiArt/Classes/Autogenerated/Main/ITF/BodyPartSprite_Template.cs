using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class BodyPartSprite_Template : BodyPartBase_Template {
		[Serialize("spriteRenderer")] public BodyPartSpriteRenderer_Template spriteRenderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spriteRenderer));
		}
		public override uint? ClassCRC => 0xF31C7B2D;
	}
}

