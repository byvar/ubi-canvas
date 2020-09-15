using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeBodyPartSimple_Template : RO2_SnakeBodyPart_Template {
		public Generic<RO2_SnakeBodyPartRenderer_Template> renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			renderer = s.SerializeObject<Generic<RO2_SnakeBodyPartRenderer_Template>>(renderer, name: "renderer");
		}
		public override uint? ClassCRC => 0x0E3424CC;
	}
}

