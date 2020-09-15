using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_StringWaveGeneratorComponent_Template : CSerializable {
		public int sync;
		public float syncOffset;
		public float syncRatio;
		public int isSpike;
		public float yScale;
		public float syncActivePercent;
		public float actorYScaleThreshold;
		public int isFullLength;
		public float growthTransitionDuration;
		public float growthTransition_TimeStartsRed;
		public float spikeMarginLength;
		public int isSpawner;
		public uint spawneeLimit;
		public int onOffAffectsAllWaves;
		public float smallScaleWhenBlackInTransition;
		public int limitWaveToBorders;
		public float coloredSpawningCueWidth;
		public float pulseScaleWhenWaiting;
		public float pulseFreqWhenWaiting;
		public StringID offToOnFX_Spikes;
		public StringID offToOnFX_Bouncer;
		public StringID waveFX_Spikes;
		public StringID waveFX_Bouncer;
		public StringID preparingWaveFX_Spikes;
		public StringID preparingWaveFX_Bouncer;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sync = s.Serialize<int>(sync, name: "sync");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			isSpike = s.Serialize<int>(isSpike, name: "isSpike");
			yScale = s.Serialize<float>(yScale, name: "yScale");
			syncActivePercent = s.Serialize<float>(syncActivePercent, name: "syncActivePercent");
			actorYScaleThreshold = s.Serialize<float>(actorYScaleThreshold, name: "actorYScaleThreshold");
			isFullLength = s.Serialize<int>(isFullLength, name: "isFullLength");
			growthTransitionDuration = s.Serialize<float>(growthTransitionDuration, name: "growthTransitionDuration");
			growthTransition_TimeStartsRed = s.Serialize<float>(growthTransition_TimeStartsRed, name: "growthTransition_TimeStartsRed");
			spikeMarginLength = s.Serialize<float>(spikeMarginLength, name: "spikeMarginLength");
			isSpawner = s.Serialize<int>(isSpawner, name: "isSpawner");
			spawneeLimit = s.Serialize<uint>(spawneeLimit, name: "spawneeLimit");
			onOffAffectsAllWaves = s.Serialize<int>(onOffAffectsAllWaves, name: "onOffAffectsAllWaves");
			smallScaleWhenBlackInTransition = s.Serialize<float>(smallScaleWhenBlackInTransition, name: "smallScaleWhenBlackInTransition");
			limitWaveToBorders = s.Serialize<int>(limitWaveToBorders, name: "limitWaveToBorders");
			coloredSpawningCueWidth = s.Serialize<float>(coloredSpawningCueWidth, name: "coloredSpawningCueWidth");
			pulseScaleWhenWaiting = s.Serialize<float>(pulseScaleWhenWaiting, name: "pulseScaleWhenWaiting");
			pulseFreqWhenWaiting = s.Serialize<float>(pulseFreqWhenWaiting, name: "pulseFreqWhenWaiting");
			offToOnFX_Spikes = s.SerializeObject<StringID>(offToOnFX_Spikes, name: "offToOnFX_Spikes");
			offToOnFX_Bouncer = s.SerializeObject<StringID>(offToOnFX_Bouncer, name: "offToOnFX_Bouncer");
			waveFX_Spikes = s.SerializeObject<StringID>(waveFX_Spikes, name: "waveFX_Spikes");
			waveFX_Bouncer = s.SerializeObject<StringID>(waveFX_Bouncer, name: "waveFX_Bouncer");
			preparingWaveFX_Spikes = s.SerializeObject<StringID>(preparingWaveFX_Spikes, name: "preparingWaveFX_Spikes");
			preparingWaveFX_Bouncer = s.SerializeObject<StringID>(preparingWaveFX_Bouncer, name: "preparingWaveFX_Bouncer");
		}
		public override uint? ClassCRC => 0x988495D1;
	}
}

