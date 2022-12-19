namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterCameraModifierComponent : ActorComponent {
		public ShooterCameraModifier camModifier;
		public ShooterCameraModifier_Transition transitionIN;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			camModifier = s.SerializeObject<ShooterCameraModifier>(camModifier, name: "camModifier");
			transitionIN = s.SerializeObject<ShooterCameraModifier_Transition>(transitionIN, name: "transitionIN");
		}
		public override uint? ClassCRC => 0x476DE974;
	}
}

