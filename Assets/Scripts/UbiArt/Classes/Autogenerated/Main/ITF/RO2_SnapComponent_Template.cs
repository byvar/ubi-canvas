using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_SnapComponent_Template : ActorComponent_Template {
		public float zOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			zOffset = s.Serialize<float>(zOffset, name: "zOffset");
		}
		public override uint? ClassCRC => 0x70376653;
	}
}

