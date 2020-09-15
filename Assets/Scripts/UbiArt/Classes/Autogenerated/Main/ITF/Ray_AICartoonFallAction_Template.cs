using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AICartoonFallAction_Template : AIAction_Template {
		public float gravityMultiplierDuringRun;
		public float gravityMultiplierDuringFall;
		public float airFrictionMultiplierDuringRun;
		public float minSpeedForFall;
		public float initialFallSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			gravityMultiplierDuringRun = s.Serialize<float>(gravityMultiplierDuringRun, name: "gravityMultiplierDuringRun");
			gravityMultiplierDuringFall = s.Serialize<float>(gravityMultiplierDuringFall, name: "gravityMultiplierDuringFall");
			airFrictionMultiplierDuringRun = s.Serialize<float>(airFrictionMultiplierDuringRun, name: "airFrictionMultiplierDuringRun");
			minSpeedForFall = s.Serialize<float>(minSpeedForFall, name: "minSpeedForFall");
			initialFallSpeed = s.Serialize<float>(initialFallSpeed, name: "initialFallSpeed");
		}
		public override uint? ClassCRC => 0x22FBA220;
	}
}

