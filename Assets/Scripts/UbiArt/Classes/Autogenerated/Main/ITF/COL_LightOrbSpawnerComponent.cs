using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_LightOrbSpawnerComponent : CSerializable {
		[Serialize("orbCount"     )] public uint orbCount;
		[Serialize("healthOrbsMin")] public float healthOrbsMin;
		[Serialize("healthOrbsMax")] public float healthOrbsMax;
		[Serialize("manaOrbsMin"  )] public float manaOrbsMin;
		[Serialize("manaOrbsMax"  )] public float manaOrbsMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(orbCount));
				SerializeField(s, nameof(healthOrbsMin));
				SerializeField(s, nameof(healthOrbsMax));
				SerializeField(s, nameof(manaOrbsMin));
				SerializeField(s, nameof(manaOrbsMax));
			}
		}
		public override uint? ClassCRC => 0x5D240124;
	}
}

