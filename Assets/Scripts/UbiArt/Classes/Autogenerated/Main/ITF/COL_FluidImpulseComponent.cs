using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_FluidImpulseComponent : CSerializable {
		public float globalFactor;
		public float globalRadiusFactor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				globalFactor = s.Serialize<float>(globalFactor, name: "globalFactor");
				globalRadiusFactor = s.Serialize<float>(globalRadiusFactor, name: "globalRadiusFactor");
			}
		}
		public override uint? ClassCRC => 0xE6D7FE58;
	}
}

