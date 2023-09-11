namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_OceanSpiderAIComponent_Template : RO2_SimpleAIComponent_Template {
		public StringID addHitInputName;
		public Path buboPath;
		public StringID buboBoneName;
		public StringID deathAnimName;
		public int numBubbles;
		public CListO<Path> bubblePrizePaths;
		public AABB bubblePrizeBox;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			addHitInputName = s.SerializeObject<StringID>(addHitInputName, name: "addHitInputName");
			buboPath = s.SerializeObject<Path>(buboPath, name: "buboPath");
			buboBoneName = s.SerializeObject<StringID>(buboBoneName, name: "buboBoneName");
			deathAnimName = s.SerializeObject<StringID>(deathAnimName, name: "deathAnimName");
			numBubbles = s.Serialize<int>(numBubbles, name: "numBubbles");
			bubblePrizePaths = s.SerializeObject<CListO<Path>>(bubblePrizePaths, name: "bubblePrizePaths");
			bubblePrizeBox = s.SerializeObject<AABB>(bubblePrizeBox, name: "bubblePrizeBox");
		}
		public override uint? ClassCRC => 0xB734FC74;
	}
}

