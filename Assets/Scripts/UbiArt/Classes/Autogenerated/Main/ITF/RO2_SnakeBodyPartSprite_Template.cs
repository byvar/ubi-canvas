using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SnakeBodyPartSprite_Template : RO2_SnakeBodyPart_Template {
		[Serialize("renderer")] public RO2_SnakeBodyPartSpriteRenderer_Template renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(renderer));
		}
		public override uint? ClassCRC => 0x80708CBF;
	}
}

