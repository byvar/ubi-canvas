using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnakeBodyPartAmv_Template : RO2_SnakeBodyPart_Template {
		public RO2_SnakeBodyPartAmvRenderer_Template renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			renderer = s.SerializeObject<RO2_SnakeBodyPartAmvRenderer_Template>(renderer, name: "renderer");
		}
		public override uint? ClassCRC => 0x15E860D3;
	}
}

