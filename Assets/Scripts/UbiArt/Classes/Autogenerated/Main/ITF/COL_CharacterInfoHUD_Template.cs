using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CharacterInfoHUD_Template : CSerializable {
		public Path lightOrbsGaugeTexture;
		public Placeholder lightOrbsGauge;
		public StringID lightOrbGaugePotionFx;
		public StringID lightOrbGaugePickLightOrbFx;
		public bool showAuroraCharacterInfoInExploration;
		public float scaleEffectMultiplier;
		public float scaleEffectTime;
		public uint goodHealthTextStyle;
		public uint lowHealthTextStyle;
		public float lowHealthPulseScaleMultiplier;
		public float lowHealthPulseTime;
		public float auroraInfoScaleUpMultiplier;
		public float auroraInfoScaleDownMultiplier;
		public float igniculusInfoScaleUpMultiplier;
		public float igniculusInfoScaleDownMultiplier;
		public float characterInfoBackgroundFade;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags8)) {
				lightOrbsGaugeTexture = s.SerializeObject<Path>(lightOrbsGaugeTexture, name: "lightOrbsGaugeTexture");
			}
			lightOrbsGauge = s.SerializeObject<Placeholder>(lightOrbsGauge, name: "lightOrbsGauge");
			lightOrbGaugePotionFx = s.SerializeObject<StringID>(lightOrbGaugePotionFx, name: "lightOrbGaugePotionFx");
			lightOrbGaugePickLightOrbFx = s.SerializeObject<StringID>(lightOrbGaugePickLightOrbFx, name: "lightOrbGaugePickLightOrbFx");
			showAuroraCharacterInfoInExploration = s.Serialize<bool>(showAuroraCharacterInfoInExploration, name: "showAuroraCharacterInfoInExploration", options: CSerializerObject.Options.BoolAsByte);
			scaleEffectMultiplier = s.Serialize<float>(scaleEffectMultiplier, name: "scaleEffectMultiplier");
			scaleEffectTime = s.Serialize<float>(scaleEffectTime, name: "scaleEffectTime");
			goodHealthTextStyle = s.Serialize<uint>(goodHealthTextStyle, name: "goodHealthTextStyle");
			lowHealthTextStyle = s.Serialize<uint>(lowHealthTextStyle, name: "lowHealthTextStyle");
			lowHealthPulseScaleMultiplier = s.Serialize<float>(lowHealthPulseScaleMultiplier, name: "lowHealthPulseScaleMultiplier");
			lowHealthPulseTime = s.Serialize<float>(lowHealthPulseTime, name: "lowHealthPulseTime");
			auroraInfoScaleUpMultiplier = s.Serialize<float>(auroraInfoScaleUpMultiplier, name: "auroraInfoScaleUpMultiplier");
			auroraInfoScaleDownMultiplier = s.Serialize<float>(auroraInfoScaleDownMultiplier, name: "auroraInfoScaleDownMultiplier");
			igniculusInfoScaleUpMultiplier = s.Serialize<float>(igniculusInfoScaleUpMultiplier, name: "igniculusInfoScaleUpMultiplier");
			igniculusInfoScaleDownMultiplier = s.Serialize<float>(igniculusInfoScaleDownMultiplier, name: "igniculusInfoScaleDownMultiplier");
			characterInfoBackgroundFade = s.Serialize<float>(characterInfoBackgroundFade, name: "characterInfoBackgroundFade");
		}
		public override uint? ClassCRC => 0x4824B4BF;
	}
}

