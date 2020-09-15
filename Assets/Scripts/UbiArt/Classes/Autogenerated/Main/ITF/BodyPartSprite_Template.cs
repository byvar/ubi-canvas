using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class BodyPartSprite_Template : BodyPartBase_Template {
		public BodyPartSpriteRenderer_Template spriteRenderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spriteRenderer = s.SerializeObject<BodyPartSpriteRenderer_Template>(spriteRenderer, name: "spriteRenderer");
		}
		public override uint? ClassCRC => 0xF31C7B2D;
	}
}

