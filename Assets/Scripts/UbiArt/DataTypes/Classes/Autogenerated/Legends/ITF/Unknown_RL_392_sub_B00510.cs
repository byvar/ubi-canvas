namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_392_sub_B00510 : ActorComponent_Template {
		public int drcTapEnabled;
		public int drcSwipeEnabled;
		public int drcHoldEnabled;
		public int swiperBidirectional;
		public float swipeMinLength;
		public Angle swipeAngleTolerance;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			drcTapEnabled = s.Serialize<int>(drcTapEnabled, name: "drcTapEnabled");
			drcSwipeEnabled = s.Serialize<int>(drcSwipeEnabled, name: "drcSwipeEnabled");
			drcHoldEnabled = s.Serialize<int>(drcHoldEnabled, name: "drcHoldEnabled");
			swiperBidirectional = s.Serialize<int>(swiperBidirectional, name: "swiperBidirectional");
			swipeMinLength = s.Serialize<float>(swipeMinLength, name: "swipeMinLength");
			swipeAngleTolerance = s.SerializeObject<Angle>(swipeAngleTolerance, name: "swipeAngleTolerance");
		}
		public override uint? ClassCRC => 0xA1DE912B;
	}
}

