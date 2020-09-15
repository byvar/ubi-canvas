using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_AINetworkComponent_Template : ActorComponent_Template {
		public Generic<PhysShape> shape;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shape = s.SerializeObject<Generic<PhysShape>>(shape, name: "shape");
		}
		public override uint? ClassCRC => 0xAD70FA46;
	}
}

