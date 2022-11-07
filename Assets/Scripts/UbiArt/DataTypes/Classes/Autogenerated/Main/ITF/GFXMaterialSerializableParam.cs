namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
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

