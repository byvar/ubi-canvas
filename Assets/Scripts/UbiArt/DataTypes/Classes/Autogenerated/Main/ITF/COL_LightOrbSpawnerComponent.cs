using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbSpawnerComponent : CSerializable {
		public uint orbCount;
		public float healthOrbsMin;
		public float healthOrbsMax;
		public float manaOrbsMin;
		public float manaOrbsMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				orbCount = s.Serialize<uint>(orbCount, name: "orbCount");
				healthOrbsMin = s.Serialize<float>(healthOrbsMin, name: "healthOrbsMin");
				healthOrbsMax = s.Serialize<float>(healthOrbsMax, name: "healthOrbsMax");
				manaOrbsMin = s.Serialize<float>(manaOrbsMin, name: "manaOrbsMin");
				manaOrbsMax = s.Serialize<float>(manaOrbsMax, name: "manaOrbsMax");
			}
		}
		public override uint? ClassCRC => 0x7159601A;
	}
}

