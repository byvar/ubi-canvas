using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class AFXPostProcessComponent_Template : ActorComponent_Template {
		public InputDesc input;
		public InputDesc inputFactor;
		public Path customTexOldTV;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			input = s.SerializeObject<InputDesc>(input, name: "input");
			inputFactor = s.SerializeObject<InputDesc>(inputFactor, name: "inputFactor");
			customTexOldTV = s.SerializeObject<Path>(customTexOldTV, name: "customTexOldTV");
		}
		public override uint? ClassCRC => 0xDBC40194;
	}
}

