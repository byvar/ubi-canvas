using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FluidImpulseComponent : CSerializable {
		[Serialize("globalFactor"      )] public float globalFactor;
		[Serialize("globalRadiusFactor")] public float globalRadiusFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(globalFactor));
				SerializeField(s, nameof(globalRadiusFactor));
			}
		}
		public override uint? ClassCRC => 0xE6D7FE58;
	}
}

