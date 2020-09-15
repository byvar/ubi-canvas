using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class CameraNearFarFadeComponent : ActorComponent {
		public float Near;
		public float Fade;
		public float Far;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Near = s.Serialize<float>(Near, name: "Near");
			Fade = s.Serialize<float>(Fade, name: "Fade");
			Far = s.Serialize<float>(Far, name: "Far");
		}
		public override uint? ClassCRC => 0x6F948B10;
	}
}

