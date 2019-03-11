using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AICartoonFallAction_Template : AIAction_Template {
		[Serialize("gravityMultiplierDuringRun"    )] public float gravityMultiplierDuringRun;
		[Serialize("gravityMultiplierDuringFall"   )] public float gravityMultiplierDuringFall;
		[Serialize("airFrictionMultiplierDuringRun")] public float airFrictionMultiplierDuringRun;
		[Serialize("minSpeedForFall"               )] public float minSpeedForFall;
		[Serialize("initialFallSpeed"              )] public float initialFallSpeed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(gravityMultiplierDuringRun));
			SerializeField(s, nameof(gravityMultiplierDuringFall));
			SerializeField(s, nameof(airFrictionMultiplierDuringRun));
			SerializeField(s, nameof(minSpeedForFall));
			SerializeField(s, nameof(initialFallSpeed));
		}
		public override uint? ClassCRC => 0x22FBA220;
	}
}

