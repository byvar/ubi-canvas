using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterInfoHUD_Template : CSerializable {
		[Serialize("lightOrbsGaugeTexture"               )] public Path lightOrbsGaugeTexture;
		[Serialize("lightOrbsGauge"                      )] public Placeholder lightOrbsGauge;
		[Serialize("lightOrbGaugePotionFx"               )] public StringID lightOrbGaugePotionFx;
		[Serialize("lightOrbGaugePickLightOrbFx"         )] public StringID lightOrbGaugePickLightOrbFx;
		[Serialize("showAuroraCharacterInfoInExploration")] public bool showAuroraCharacterInfoInExploration;
		[Serialize("scaleEffectMultiplier"               )] public float scaleEffectMultiplier;
		[Serialize("scaleEffectTime"                     )] public float scaleEffectTime;
		[Serialize("goodHealthTextStyle"                 )] public uint goodHealthTextStyle;
		[Serialize("lowHealthTextStyle"                  )] public uint lowHealthTextStyle;
		[Serialize("lowHealthPulseScaleMultiplier"       )] public float lowHealthPulseScaleMultiplier;
		[Serialize("lowHealthPulseTime"                  )] public float lowHealthPulseTime;
		[Serialize("auroraInfoScaleUpMultiplier"         )] public float auroraInfoScaleUpMultiplier;
		[Serialize("auroraInfoScaleDownMultiplier"       )] public float auroraInfoScaleDownMultiplier;
		[Serialize("igniculusInfoScaleUpMultiplier"      )] public float igniculusInfoScaleUpMultiplier;
		[Serialize("igniculusInfoScaleDownMultiplier"    )] public float igniculusInfoScaleDownMultiplier;
		[Serialize("characterInfoBackgroundFade"         )] public float characterInfoBackgroundFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				SerializeField(s, nameof(lightOrbsGaugeTexture));
			}
			SerializeField(s, nameof(lightOrbsGauge));
			SerializeField(s, nameof(lightOrbGaugePotionFx));
			SerializeField(s, nameof(lightOrbGaugePickLightOrbFx));
			SerializeField(s, nameof(showAuroraCharacterInfoInExploration), boolAsByte: true);
			SerializeField(s, nameof(scaleEffectMultiplier));
			SerializeField(s, nameof(scaleEffectTime));
			SerializeField(s, nameof(goodHealthTextStyle));
			SerializeField(s, nameof(lowHealthTextStyle));
			SerializeField(s, nameof(lowHealthPulseScaleMultiplier));
			SerializeField(s, nameof(lowHealthPulseTime));
			SerializeField(s, nameof(auroraInfoScaleUpMultiplier));
			SerializeField(s, nameof(auroraInfoScaleDownMultiplier));
			SerializeField(s, nameof(igniculusInfoScaleUpMultiplier));
			SerializeField(s, nameof(igniculusInfoScaleDownMultiplier));
			SerializeField(s, nameof(characterInfoBackgroundFade));
		}
		public override uint? ClassCRC => 0x4824B4BF;
	}
}

