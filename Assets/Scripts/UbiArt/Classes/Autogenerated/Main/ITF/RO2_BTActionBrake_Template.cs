using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionBrake_Template : BTAction_Template {
		public float brakingForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			brakingForce = s.Serialize<float>(brakingForce, name: "brakingForce");
		}
		public override uint? ClassCRC => 0x5EDE5EFF;
	}
}

