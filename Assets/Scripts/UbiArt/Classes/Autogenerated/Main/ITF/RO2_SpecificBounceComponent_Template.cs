using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_SpecificBounceComponent_Template : ActorComponent_Template {
		public float ejectSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ejectSpeedMultiplier = s.Serialize<float>(ejectSpeedMultiplier, name: "ejectSpeedMultiplier");
		}
		public override uint? ClassCRC => 0x4A60EA60;
	}
}

