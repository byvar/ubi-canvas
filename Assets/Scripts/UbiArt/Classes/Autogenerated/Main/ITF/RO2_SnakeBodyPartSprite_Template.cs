using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeBodyPartSprite_Template : RO2_SnakeBodyPart_Template {
		public RO2_SnakeBodyPartSpriteRenderer_Template renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			renderer = s.SerializeObject<RO2_SnakeBodyPartSpriteRenderer_Template>(renderer, name: "renderer");
		}
		public override uint? ClassCRC => 0x80708CBF;
	}
}

