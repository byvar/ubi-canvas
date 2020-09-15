using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class GFXMaterialSerializableParam : CSerializable {
		public float Reflector_factor;
		public float HiddenMask_Z_Extrude;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Reflector_factor = s.Serialize<float>(Reflector_factor, name: "Reflector_factor");
			HiddenMask_Z_Extrude = s.Serialize<float>(HiddenMask_Z_Extrude, name: "HiddenMask_Z_Extrude");
		}
	}
}

