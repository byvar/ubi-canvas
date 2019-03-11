using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_StringWaveGeneratorComponent_Template : ActorComponent_Template {
		[Serialize("sync"                           )] public bool sync;
		[Serialize("syncOffset"                     )] public float syncOffset;
		[Serialize("syncRatio"                      )] public float syncRatio;
		[Serialize("isSpike"                        )] public bool isSpike;
		[Serialize("yScale"                         )] public float yScale;
		[Serialize("syncActivePercent"              )] public float syncActivePercent;
		[Serialize("actorYScaleThreshold"           )] public float actorYScaleThreshold;
		[Serialize("isFullLength"                   )] public bool isFullLength;
		[Serialize("growthTransitionDuration"       )] public float growthTransitionDuration;
		[Serialize("growthTransition_TimeStartsRed" )] public float growthTransition_TimeStartsRed;
		[Serialize("spikeMarginLength"              )] public float spikeMarginLength;
		[Serialize("isSpawner"                      )] public bool isSpawner;
		[Serialize("spawneeLimit"                   )] public uint spawneeLimit;
		[Serialize("onOffAffectsAllWaves"           )] public bool onOffAffectsAllWaves;
		[Serialize("smallScaleWhenBlackInTransition")] public float smallScaleWhenBlackInTransition;
		[Serialize("limitWaveToBorders"             )] public bool limitWaveToBorders;
		[Serialize("coloredSpawningCueWidth"        )] public float coloredSpawningCueWidth;
		[Serialize("pulseScaleWhenWaiting"          )] public float pulseScaleWhenWaiting;
		[Serialize("pulseFreqWhenWaiting"           )] public float pulseFreqWhenWaiting;
		[Serialize("offToOnFX_Spikes"               )] public StringID offToOnFX_Spikes;
		[Serialize("offToOnFX_Bouncer"              )] public StringID offToOnFX_Bouncer;
		[Serialize("waveFX_Spikes"                  )] public StringID waveFX_Spikes;
		[Serialize("waveFX_Bouncer"                 )] public StringID waveFX_Bouncer;
		[Serialize("preparingWaveFX_Spikes"         )] public StringID preparingWaveFX_Spikes;
		[Serialize("preparingWaveFX_Bouncer"        )] public StringID preparingWaveFX_Bouncer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sync));
			SerializeField(s, nameof(syncOffset));
			SerializeField(s, nameof(syncRatio));
			SerializeField(s, nameof(isSpike));
			SerializeField(s, nameof(yScale));
			SerializeField(s, nameof(syncActivePercent));
			SerializeField(s, nameof(actorYScaleThreshold));
			SerializeField(s, nameof(isFullLength));
			SerializeField(s, nameof(growthTransitionDuration));
			SerializeField(s, nameof(growthTransition_TimeStartsRed));
			SerializeField(s, nameof(spikeMarginLength));
			SerializeField(s, nameof(isSpawner));
			SerializeField(s, nameof(spawneeLimit));
			SerializeField(s, nameof(onOffAffectsAllWaves));
			SerializeField(s, nameof(smallScaleWhenBlackInTransition));
			SerializeField(s, nameof(limitWaveToBorders));
			SerializeField(s, nameof(coloredSpawningCueWidth));
			SerializeField(s, nameof(pulseScaleWhenWaiting));
			SerializeField(s, nameof(pulseFreqWhenWaiting));
			SerializeField(s, nameof(offToOnFX_Spikes));
			SerializeField(s, nameof(offToOnFX_Bouncer));
			SerializeField(s, nameof(waveFX_Spikes));
			SerializeField(s, nameof(waveFX_Bouncer));
			SerializeField(s, nameof(preparingWaveFX_Spikes));
			SerializeField(s, nameof(preparingWaveFX_Bouncer));
		}
		public override uint? ClassCRC => 0x93C8B246;
	}
}

