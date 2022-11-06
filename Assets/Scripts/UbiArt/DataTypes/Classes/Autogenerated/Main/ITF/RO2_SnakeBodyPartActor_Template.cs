using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_SnakeBodyPartActor_Template : RO2_SnakeBodyPart_Template {
		public RO2_SnakeBodyPartActorRenderer_Template renderer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			renderer = s.SerializeObject<RO2_SnakeBodyPartActorRenderer_Template>(renderer, name: "renderer");
		}
		public override uint? ClassCRC => 0x983AF4D4;
	}
}

