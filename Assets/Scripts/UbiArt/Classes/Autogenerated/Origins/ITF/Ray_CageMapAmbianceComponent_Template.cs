using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_CageMapAmbianceComponent_Template : CSerializable {
		[Serialize("darkColor"                       )] public Color darkColor;
		[Serialize("neutralColor"                    )] public Color neutralColor;
		[Serialize("lightColor"                      )] public Color lightColor;
		[Serialize("darkToNeutralTime"               )] public float darkToNeutralTime;
		[Serialize("neutralToLightTime"              )] public float neutralToLightTime;
		[Serialize("startRank"                       )] public bool startRank;
		[Serialize("renderRank"                      )] public bool renderRank;
		[Serialize("darkAlphaFadeTime"               )] public float darkAlphaFadeTime;
		[Serialize("darkAlphaRadialProgressionSpeed" )] public float darkAlphaRadialProgressionSpeed;
		[Serialize("lightAlphaFadeTime"              )] public float lightAlphaFadeTime;
		[Serialize("lightAlphaRadialProgressionSpeed")] public float lightAlphaRadialProgressionSpeed;
		[Serialize("forcedAABB"                      )] public Placeholder forcedAABB;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(darkColor));
			SerializeField(s, nameof(neutralColor));
			SerializeField(s, nameof(lightColor));
			SerializeField(s, nameof(darkToNeutralTime));
			SerializeField(s, nameof(neutralToLightTime));
			SerializeField(s, nameof(startRank));
			SerializeField(s, nameof(renderRank));
			SerializeField(s, nameof(darkAlphaFadeTime));
			SerializeField(s, nameof(darkAlphaRadialProgressionSpeed));
			SerializeField(s, nameof(lightAlphaFadeTime));
			SerializeField(s, nameof(lightAlphaRadialProgressionSpeed));
			SerializeField(s, nameof(forcedAABB));
		}
		public override uint? ClassCRC => 0x6E9D8E58;
	}
}

