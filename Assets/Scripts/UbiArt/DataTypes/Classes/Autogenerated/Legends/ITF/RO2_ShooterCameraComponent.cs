namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterCameraComponent : BaseCameraComponent {
		public Vec3d Pos;
		public bool useInitModifier;
		public Unknown_RL_38748_sub_A04420 initModifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				Pos = s.SerializeObject<Vec3d>(Pos, name: "Pos");
			}
			useInitModifier = s.Serialize<bool>(useInitModifier, name: "useInitModifier");
			if (useInitModifier) {
				initModifier = s.SerializeObject<Unknown_RL_38748_sub_A04420>(initModifier, name: "initModifier");
			}
		}
		public override uint? ClassCRC => 0x9AC515FF;
	}
}

