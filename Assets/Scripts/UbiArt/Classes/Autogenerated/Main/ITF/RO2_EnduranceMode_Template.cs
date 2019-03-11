using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EnduranceMode_Template : RO2_ChallengeCommon_Template {
		[Serialize("flippableTags"          )] public CList<StringID> flippableTags;
		[Serialize("decoBrickCooldown"      )] public uint decoBrickCooldown;
		[Serialize("decoBrickMaxActiveCount")] public uint decoBrickMaxActiveCount;
		[Serialize("decoBricks"             )] public CList<RO2_DecoBrick_Template> decoBricks;
		[Serialize("specialDecoBricks"      )] public CList<RO2_DecoBrick_Template> specialDecoBricks;
		[Serialize("decoRanges"             )] public CList<RO2_EnduranceMode_Template.DecoRange> decoRanges;
		[Serialize("treasureRopeCount"      )] public uint treasureRopeCount;
		[Serialize("treasureRopeInterval"   )] public float treasureRopeInterval;
		[Serialize("treasureRopeHitLevel"   )] public uint treasureRopeHitLevel;
		[Serialize("treasureRopePath"       )] public Path treasureRopePath;
		[Serialize("treasureReachedFxPath"  )] public Path treasureReachedFxPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flippableTags));
			SerializeField(s, nameof(decoBrickCooldown));
			SerializeField(s, nameof(decoBrickMaxActiveCount));
			SerializeField(s, nameof(decoBricks));
			SerializeField(s, nameof(specialDecoBricks));
			SerializeField(s, nameof(decoRanges));
			SerializeField(s, nameof(treasureRopeCount));
			SerializeField(s, nameof(treasureRopeInterval));
			SerializeField(s, nameof(treasureRopeHitLevel));
			SerializeField(s, nameof(treasureRopePath));
			SerializeField(s, nameof(treasureReachedFxPath));
		}
		public partial class DecoRange : CSerializable {
			[Serialize("minDist"   )] public float minDist;
			[Serialize("maxDist"   )] public float maxDist;
			[Serialize("fog"       )] public StringID fog;
			[Serialize("clearColor")] public StringID clearColor;
			[Serialize("frise"     )] public StringID frise;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(minDist));
				SerializeField(s, nameof(maxDist));
				SerializeField(s, nameof(fog));
				SerializeField(s, nameof(clearColor));
				SerializeField(s, nameof(frise));
			}
		}
		public override uint? ClassCRC => 0x92DC8145;
	}
}

