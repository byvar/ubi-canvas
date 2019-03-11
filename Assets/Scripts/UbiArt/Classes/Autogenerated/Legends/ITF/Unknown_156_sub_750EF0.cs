using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_156_sub_750EF0 : CSerializable {
		[Serialize("useFilterStickControl")] public bool useFilterStickControl;
		[Serialize("graduationActorPath"  )] public Path graduationActorPath;
		[Serialize("graduationPoolSize"   )] public uint graduationPoolSize;
		[Serialize("nodeActorPath"        )] public Path nodeActorPath;
		[Serialize("flagIconPath"         )] public Path flagIconPath;
		[Serialize("costumeIconPath"      )] public Path costumeIconPath;
		[Serialize("rankIconPath"         )] public Path rankIconPath;
		[Serialize("nodePoolSize"         )] public uint nodePoolSize;
		[Serialize("barActorPath"         )] public Path barActorPath;
		[Serialize("barPoolSize"          )] public uint barPoolSize;
		[Serialize("pointActorPath"       )] public Path pointActorPath;
		[Serialize("pointPoolSize"        )] public uint pointPoolSize;
		[Serialize("nameActorPath"        )] public Path nameActorPath;
		[Serialize("namePoolSize"         )] public uint namePoolSize;
		[Serialize("lineOffset"           )] public float lineOffset;
		[Serialize("rowOffset"            )] public float rowOffset;
		[Serialize("columnOffset"         )] public float columnOffset;
		[Serialize("canvasTopOffset"      )] public float canvasTopOffset;
		[Serialize("numColumn"            )] public uint numColumn;
		[Serialize("numRow"               )] public uint numRow;
		[Serialize("materialHistoBarFill" )] public Placeholder materialHistoBarFill;
		[Serialize("materialHistoBarTop"  )] public Placeholder materialHistoBarTop;
		[Serialize("materialLevel"        )] public Placeholder materialLevel;
		[Serialize("materialCountry"      )] public Placeholder materialCountry;
		[Serialize("materialMedal"        )] public Placeholder materialMedal;
		[Serialize("rankingText"          )] public Placeholder rankingText;
		[Serialize("emptyRankingText"     )] public Placeholder emptyRankingText;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(useFilterStickControl));
			SerializeField(s, nameof(graduationActorPath));
			SerializeField(s, nameof(graduationPoolSize));
			SerializeField(s, nameof(nodeActorPath));
			SerializeField(s, nameof(flagIconPath));
			SerializeField(s, nameof(costumeIconPath));
			SerializeField(s, nameof(rankIconPath));
			SerializeField(s, nameof(nodePoolSize));
			SerializeField(s, nameof(barActorPath));
			SerializeField(s, nameof(barPoolSize));
			SerializeField(s, nameof(pointActorPath));
			SerializeField(s, nameof(pointPoolSize));
			SerializeField(s, nameof(nameActorPath));
			SerializeField(s, nameof(namePoolSize));
			SerializeField(s, nameof(lineOffset));
			SerializeField(s, nameof(rowOffset));
			SerializeField(s, nameof(columnOffset));
			SerializeField(s, nameof(canvasTopOffset));
			SerializeField(s, nameof(numColumn));
			SerializeField(s, nameof(numRow));
			SerializeField(s, nameof(materialHistoBarFill));
			SerializeField(s, nameof(materialHistoBarTop));
			SerializeField(s, nameof(materialLevel));
			SerializeField(s, nameof(materialCountry));
			SerializeField(s, nameof(materialMedal));
			SerializeField(s, nameof(rankingText));
			SerializeField(s, nameof(emptyRankingText));
		}
		public override uint? ClassCRC => 0xFE013942;
	}
}

