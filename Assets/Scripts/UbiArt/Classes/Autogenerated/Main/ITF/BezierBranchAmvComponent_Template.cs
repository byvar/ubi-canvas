using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.COL)]
	public partial class BezierBranchAmvComponent_Template : BezierBranchComponent_Template {
		[Serialize("amvPath"               )] public Path amvPath;
		[Serialize("amvMaterial"           )] public GFXMaterialSerializable amvMaterial;
		[Serialize("amvGameMaterial"       )] public Path amvGameMaterial;
		[Serialize("amvGameMaterialFlipped")] public Path amvGameMaterialFlipped;
		[Serialize("spawnIntervalMin"      )] public float spawnIntervalMin;
		[Serialize("spawnIntervalMax"      )] public float spawnIntervalMax;
		[Serialize("zOffset"               )] public float zOffset;
		[Serialize("scaleMultiplierMin"    )] public float scaleMultiplierMin;
		[Serialize("scaleMultiplierMax"    )] public float scaleMultiplierMax;
		[Serialize("animIndexMin"          )] public uint animIndexMin;
		[Serialize("animIndexMax"          )] public uint animIndexMax;
		[Serialize("beginLength"           )] public float beginLength;
		[Serialize("endLength"             )] public float endLength;
		[Serialize("beginWidthMin"         )] public float beginWidthMin;
		[Serialize("beginWidthMax"         )] public float beginWidthMax;
		[Serialize("midWidthMin"           )] public float midWidthMin;
		[Serialize("midWidthMax"           )] public float midWidthMax;
		[Serialize("endWidthMin"           )] public float endWidthMin;
		[Serialize("endWidthMax"           )] public float endWidthMax;
		[Serialize("startOffset"           )] public float startOffset;
		[Serialize("endOffset"             )] public float endOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(amvPath));
			SerializeField(s, nameof(amvMaterial));
			SerializeField(s, nameof(amvGameMaterial));
			SerializeField(s, nameof(amvGameMaterialFlipped));
			SerializeField(s, nameof(spawnIntervalMin));
			SerializeField(s, nameof(spawnIntervalMax));
			SerializeField(s, nameof(zOffset));
			SerializeField(s, nameof(scaleMultiplierMin));
			SerializeField(s, nameof(scaleMultiplierMax));
			SerializeField(s, nameof(animIndexMin));
			SerializeField(s, nameof(animIndexMax));
			SerializeField(s, nameof(beginLength));
			SerializeField(s, nameof(endLength));
			SerializeField(s, nameof(beginWidthMin));
			SerializeField(s, nameof(beginWidthMax));
			SerializeField(s, nameof(midWidthMin));
			SerializeField(s, nameof(midWidthMax));
			SerializeField(s, nameof(endWidthMin));
			SerializeField(s, nameof(endWidthMax));
			SerializeField(s, nameof(startOffset));
			SerializeField(s, nameof(endOffset));
		}
		public override uint? ClassCRC => 0x865AEE81;
	}
}

