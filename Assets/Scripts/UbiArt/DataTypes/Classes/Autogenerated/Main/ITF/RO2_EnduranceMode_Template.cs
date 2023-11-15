namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_EnduranceMode_Template : RO2_ChallengeCommon_Template {
		public CListO<StringID> flippableTags;
		public uint decoBrickCooldown = 2;
		public uint decoBrickMaxActiveCount = 5;
		public CListO<Generic<RO2_DecoBrick_Template>> decoBricks;
		public CListO<Generic<RO2_DecoBrick_Template>> specialDecoBricks;
		public CListO<RO2_EnduranceMode_Template.DecoRange> decoRanges;
		public uint treasureRopeCount = 3;
		public float treasureRopeInterval = 1f;
		public uint treasureRopeHitLevel = 1;
		public Path treasureRopePath;
		public Path treasureReachedFxPath;
		public BrickDirection decoBricksDirection;
		public bool limitBrickHeight;
		public int minBrickHeight;
		public int maxBrickHeight;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flippableTags = s.SerializeObject<CListO<StringID>>(flippableTags, name: "flippableTags");
			decoBrickCooldown = s.Serialize<uint>(decoBrickCooldown, name: "decoBrickCooldown");
			decoBrickMaxActiveCount = s.Serialize<uint>(decoBrickMaxActiveCount, name: "decoBrickMaxActiveCount");
			decoBricks = s.SerializeObject<CListO<Generic<RO2_DecoBrick_Template>>>(decoBricks, name: "decoBricks");
			specialDecoBricks = s.SerializeObject<CListO<Generic<RO2_DecoBrick_Template>>>(specialDecoBricks, name: "specialDecoBricks");
			decoRanges = s.SerializeObject<CListO<RO2_EnduranceMode_Template.DecoRange>>(decoRanges, name: "decoRanges");
			if (s.Settings.Game == Game.RM) {
				decoBricksDirection = s.Serialize<BrickDirection>(decoBricksDirection, name: "decoBricksDirection");
			}
			treasureRopeCount = s.Serialize<uint>(treasureRopeCount, name: "treasureRopeCount");
			treasureRopeInterval = s.Serialize<float>(treasureRopeInterval, name: "treasureRopeInterval");
			treasureRopeHitLevel = s.Serialize<uint>(treasureRopeHitLevel, name: "treasureRopeHitLevel");
			treasureRopePath = s.SerializeObject<Path>(treasureRopePath, name: "treasureRopePath");
			treasureReachedFxPath = s.SerializeObject<Path>(treasureReachedFxPath, name: "treasureReachedFxPath");
			if (s.Settings.Game == Game.RM) {
				limitBrickHeight = s.Serialize<bool>(limitBrickHeight, name: "limitBrickHeight");
				minBrickHeight = s.Serialize<int>(minBrickHeight, name: "minBrickHeight");
				maxBrickHeight = s.Serialize<int>(maxBrickHeight, name: "maxBrickHeight");
			}
		}
		[Games(GameFlags.RA)]
		public partial class DecoRange : CSerializable {
			public float minDist;
			public float maxDist;
			public StringID fog;
			public StringID clearColor;
			public StringID frise;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				minDist = s.Serialize<float>(minDist, name: "minDist");
				maxDist = s.Serialize<float>(maxDist, name: "maxDist");
				fog = s.SerializeObject<StringID>(fog, name: "fog");
				clearColor = s.SerializeObject<StringID>(clearColor, name: "clearColor");
				frise = s.SerializeObject<StringID>(frise, name: "frise");
			}
		}

		public enum BrickDirection {
			[Serialize("BrickDirection_HorizontalAndVertical")] HorizontalAndVertical,
			[Serialize("BrickDirection_Horizontal"           )] Horizontal,
			[Serialize("BrickDirection_Vertical"             )] Vertical,
		}

		public override uint? ClassCRC => 0x92DC8145;
	}
}

