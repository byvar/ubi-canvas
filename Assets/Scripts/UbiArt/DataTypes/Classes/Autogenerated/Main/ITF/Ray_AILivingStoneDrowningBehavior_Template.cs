namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AILivingStoneDrowningBehavior_Template : Ray_AIWaterBaseBehavior_Template {
		public Placeholder dive;
		public Placeholder drown;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dive = s.SerializeObject<Placeholder>(dive, name: "dive");
			drown = s.SerializeObject<Placeholder>(drown, name: "drown");
		}
		public override uint? ClassCRC => 0x0D67DFC6;
	}
}

