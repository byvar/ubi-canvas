namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_ShooterCameraModifierComponent : ActorComponent {
		public Unknown_RL_38748_sub_A04420 camModifier;
		public Unknown_RL_38759_sub_A04790 transitionIN;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			camModifier = s.SerializeObject<Unknown_RL_38748_sub_A04420>(camModifier, name: "camModifier");
			transitionIN = s.SerializeObject<Unknown_RL_38759_sub_A04790>(transitionIN, name: "transitionIN");
		}
		public override uint? ClassCRC => 0x476DE974;
	}
}

