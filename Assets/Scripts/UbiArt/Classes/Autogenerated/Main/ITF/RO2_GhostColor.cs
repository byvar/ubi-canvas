using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_GhostColor : CSerializable {
		[Serialize("colorConfigName"        )] public StringID colorConfigName;
		[Serialize("ghostFactorColorDefault")] public Color ghostFactorColorDefault;
		[Serialize("ghostFactorColorMin"    )] public Color ghostFactorColorMin;
		[Serialize("ghostFactorColorMax"    )] public Color ghostFactorColorMax;
		[Serialize("ghostFogColorDefault"   )] public Color ghostFogColorDefault;
		[Serialize("ghostFogColorMin"       )] public Color ghostFogColorMin;
		[Serialize("ghostFogColorMax"       )] public Color ghostFogColorMax;
		[Serialize("ghostDistColorMin"      )] public float ghostDistColorMin;
		[Serialize("ghostDistColorMax"      )] public float ghostDistColorMax;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(colorConfigName));
			SerializeField(s, nameof(ghostFactorColorDefault));
			SerializeField(s, nameof(ghostFactorColorMin));
			SerializeField(s, nameof(ghostFactorColorMax));
			SerializeField(s, nameof(ghostFogColorDefault));
			SerializeField(s, nameof(ghostFogColorMin));
			SerializeField(s, nameof(ghostFogColorMax));
			SerializeField(s, nameof(ghostDistColorMin));
			SerializeField(s, nameof(ghostDistColorMax));
		}
	}
}

