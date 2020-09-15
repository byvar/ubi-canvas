using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnduranceMode_Template : RO2_ChallengeCommon_Template {
		public CList<StringID> flippableTags;
		public uint decoBrickCooldown;
		public uint decoBrickMaxActiveCount;
		public CList<RO2_DecoBrick_Template> decoBricks;
		public CList<RO2_DecoBrick_Template> specialDecoBricks;
		public CList<RO2_EnduranceMode_Template.DecoRange> decoRanges;
		public uint treasureRopeCount;
		public float treasureRopeInterval;
		public uint treasureRopeHitLevel;
		public Path treasureRopePath;
		public Path treasureReachedFxPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			flippableTags = s.SerializeObject<CList<StringID>>(flippableTags, name: "flippableTags");
			decoBrickCooldown = s.Serialize<uint>(decoBrickCooldown, name: "decoBrickCooldown");
			decoBrickMaxActiveCount = s.Serialize<uint>(decoBrickMaxActiveCount, name: "decoBrickMaxActiveCount");
			decoBricks = s.SerializeObject<CList<RO2_DecoBrick_Template>>(decoBricks, name: "decoBricks");
			specialDecoBricks = s.SerializeObject<CList<RO2_DecoBrick_Template>>(specialDecoBricks, name: "specialDecoBricks");
			decoRanges = s.SerializeObject<CList<RO2_EnduranceMode_Template.DecoRange>>(decoRanges, name: "decoRanges");
			treasureRopeCount = s.Serialize<uint>(treasureRopeCount, name: "treasureRopeCount");
			treasureRopeInterval = s.Serialize<float>(treasureRopeInterval, name: "treasureRopeInterval");
			treasureRopeHitLevel = s.Serialize<uint>(treasureRopeHitLevel, name: "treasureRopeHitLevel");
			treasureRopePath = s.SerializeObject<Path>(treasureRopePath, name: "treasureRopePath");
			treasureReachedFxPath = s.SerializeObject<Path>(treasureReachedFxPath, name: "treasureReachedFxPath");
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
		public override uint? ClassCRC => 0x92DC8145;
	}
}

