namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_CupCounterComponent_Template : ActorComponent_Template {
		public LocalisationId locID;
		public Path bronzeCup;
		public Path silverCup;
		public Path goldCup;
		public string bronzetextColor;
		public string silvertextColor;
		public string goldTextColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			locID = s.SerializeObject<LocalisationId>(locID, name: "locID");
			bronzeCup = s.SerializeObject<Path>(bronzeCup, name: "bronzeCup");
			silverCup = s.SerializeObject<Path>(silverCup, name: "silverCup");
			goldCup = s.SerializeObject<Path>(goldCup, name: "goldCup");
			bronzetextColor = s.Serialize<string>(bronzetextColor, name: "bronzetextColor");
			silvertextColor = s.Serialize<string>(silvertextColor, name: "silvertextColor");
			goldTextColor = s.Serialize<string>(goldTextColor, name: "goldTextColor");
		}
		public override uint? ClassCRC => 0xDAAB883A;
	}
}

