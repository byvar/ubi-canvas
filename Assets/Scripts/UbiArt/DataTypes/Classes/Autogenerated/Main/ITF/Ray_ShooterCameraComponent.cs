namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCameraComponent : BaseCameraComponent {
		public Vec3d Pos;
		public bool useInitModifier;
		public Ray_ShooterCameraModifierComponent.ShooterCameraModifier initModifier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				Pos = s.SerializeObject<Vec3d>(Pos, name: "Pos");
			}
			useInitModifier = s.Serialize<bool>(useInitModifier, name: "useInitModifier");
			if (useInitModifier) {
				initModifier = s.SerializeObject<Ray_ShooterCameraModifierComponent.ShooterCameraModifier>(initModifier, name: "initModifier");
			}
		}
		public override uint? ClassCRC => 0x69A494EA;
	}
}

