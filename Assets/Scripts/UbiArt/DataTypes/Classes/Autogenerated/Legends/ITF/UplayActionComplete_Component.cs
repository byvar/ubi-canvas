namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class UplayActionComplete_Component : ActorComponent {
		public Enum_UplayAction UplayAction;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			UplayAction = s.Serialize<Enum_UplayAction>(UplayAction, name: "UplayAction");
		}
		public enum Enum_UplayAction {
			[Serialize("online::uplayAction1")] uplayAction1 = 0,
			[Serialize("online::uplayAction2")] uplayAction2 = 1,
			[Serialize("online::uplayAction3")] uplayAction3 = 2,
			[Serialize("online::uplayAction4")] uplayAction4 = 3,
		}
		public override uint? ClassCRC => 0x9546A69F;
	}
}

