namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BubbleDreamerComponent_Template : ActorComponent_Template {
		public CListO<Quote> Quotes;
		public float QuoteMaxDuration;
		public float TimeBeforeSleep;
		public float DistToPopBubble;
		public uint FontMood;
		public uint FontMoodSpecial;
		public float RetroMapCoeff;
		public Color MapColor;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Quotes = s.SerializeObject<CListO<Quote>>(Quotes, name: "Quotes");
			QuoteMaxDuration = s.Serialize<float>(QuoteMaxDuration, name: "QuoteMaxDuration");
			TimeBeforeSleep = s.Serialize<float>(TimeBeforeSleep, name: "TimeBeforeSleep");
			DistToPopBubble = s.Serialize<float>(DistToPopBubble, name: "DistToPopBubble");
			FontMood = s.Serialize<uint>(FontMood, name: "FontMood");
			FontMoodSpecial = s.Serialize<uint>(FontMoodSpecial, name: "FontMoodSpecial");
			RetroMapCoeff = s.Serialize<float>(RetroMapCoeff, name: "RetroMapCoeff");
			MapColor = s.SerializeObject<Color>(MapColor, name: "MapColor");
		}
		public override uint? ClassCRC => 0x706DE95E;
	}
}

