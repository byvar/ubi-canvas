using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RLC_ExitComponent_Template : ActorComponent_Template {
		public float shakeFlagsDistance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			shakeFlagsDistance = s.Serialize<float>(shakeFlagsDistance, name: "shakeFlagsDistance");
		}
		public override uint? ClassCRC => 0x0101F5DF;
	}
}

