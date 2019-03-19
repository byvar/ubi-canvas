using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BTActionBrake_Template : BTAction_Template {
		[Serialize("brakingForce")] public float brakingForce;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(brakingForce));
		}
		public override uint? ClassCRC => 0x5EDE5EFF;
	}
}

