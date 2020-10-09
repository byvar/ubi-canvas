using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class RenderParamComponent_Template : ActorComponent_Template {
		public InputDesc input;
		public InputDesc inputFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<InputDesc>(input, name: "input");
			inputFactor = s.SerializeObject<InputDesc>(inputFactor, name: "inputFactor");
		}
		public override uint? ClassCRC => 0xF2E7EF7F;
	}
}

