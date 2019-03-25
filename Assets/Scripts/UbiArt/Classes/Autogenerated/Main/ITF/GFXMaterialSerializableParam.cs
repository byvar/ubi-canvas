using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class GFXMaterialSerializableParam : CSerializable {
		[Serialize("Reflector_factor"    )] public float Reflector_factor;
		[Serialize("HiddenMask_Z_Extrude")] public float HiddenMask_Z_Extrude;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Reflector_factor));
			SerializeField(s, nameof(HiddenMask_Z_Extrude));
		}
	}
}

