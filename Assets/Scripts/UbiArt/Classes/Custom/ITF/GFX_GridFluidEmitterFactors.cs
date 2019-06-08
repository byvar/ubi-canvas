using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class GFX_GridFluidEmitterFactors : CSerializable {
		[Serialize("ExternalForce"    )] public float ExternalForce;
		[Serialize("ExternalFluid"    )] public float ExternalFluid;
		[Serialize("ExternalPrimitive")] public float ExternalPrimitive;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(ExternalForce));
				SerializeField(s, nameof(ExternalFluid));
				SerializeField(s, nameof(ExternalPrimitive));
			}
		}
	}
}

