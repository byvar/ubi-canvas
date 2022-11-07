namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_352_sub_A644E0 : ActorComponent_Template {
		public StringID fadeIn;
		public StringID fadeOut;
		public StringID idle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fadeIn = s.SerializeObject<StringID>(fadeIn, name: "fadeIn");
			fadeOut = s.SerializeObject<StringID>(fadeOut, name: "fadeOut");
			idle = s.SerializeObject<StringID>(idle, name: "idle");
		}
		public override uint? ClassCRC => 0xFE9FCB19;
	}
}

