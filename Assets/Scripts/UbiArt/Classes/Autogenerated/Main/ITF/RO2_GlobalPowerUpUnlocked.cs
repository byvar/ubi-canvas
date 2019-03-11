using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_GlobalPowerUpUnlocked : CSerializable {
		[Serialize("dive"             )] public bool dive;
		[Serialize("walkOnWallsGlobal")] public bool walkOnWallsGlobal;
		[Serialize("reduction"        )] public bool reduction;
		[Serialize("helicopter"       )] public bool helicopter;
		[Serialize("fight"            )] public bool fight;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dive));
			SerializeField(s, nameof(walkOnWallsGlobal));
			SerializeField(s, nameof(reduction));
			SerializeField(s, nameof(helicopter));
			SerializeField(s, nameof(fight));
		}
	}
}

