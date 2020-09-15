using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidEmitterFactors : CSerializable {
		public float ExternalForce;
		public float ExternalFluid;
		public float ExternalPrimitive;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				ExternalForce = s.Serialize<float>(ExternalForce, name: "ExternalForce");
				ExternalFluid = s.Serialize<float>(ExternalFluid, name: "ExternalFluid");
				ExternalPrimitive = s.Serialize<float>(ExternalPrimitive, name: "ExternalPrimitive");
			}
		}
	}
}

