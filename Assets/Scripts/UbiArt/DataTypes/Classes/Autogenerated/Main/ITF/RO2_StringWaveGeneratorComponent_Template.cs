namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_StringWaveGeneratorComponent_Template : ActorComponent_Template {
		public bool sync;
		public float syncOffset;
		public float syncRatio;
		public bool isSpike;
		public float yScale;
		public float syncActivePercent;
		public float actorYScaleThreshold;
		public bool isFullLength;
		public float growthTransitionDuration;
		public float growthTransition_TimeStartsRed;
		public float spikeMarginLength;
		public bool isSpawner;
		public uint spawneeLimit;
		public bool onOffAffectsAllWaves;
		public float smallScaleWhenBlackInTransition;
		public bool limitWaveToBorders;
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
			sync = s.Serialize<bool>(sync, name: "sync");
			syncOffset = s.Serialize<float>(syncOffset, name: "syncOffset");
			syncRatio = s.Serialize<float>(syncRatio, name: "syncRatio");
			isSpike = s.Serialize<bool>(isSpike, name: "isSpike");
			yScale = s.Serialize<float>(yScale, name: "yScale");
			syncActivePercent = s.Serialize<float>(syncActivePercent, name: "syncActivePercent");
			actorYScaleThreshold = s.Serialize<float>(actorYScaleThreshold, name: "actorYScaleThreshold");
			isFullLength = s.Serialize<bool>(isFullLength, name: "isFullLength");
			growthTransitionDuration = s.Serialize<float>(growthTransitionDuration, name: "growthTransitionDuration");
			growthTransition_TimeStartsRed = s.Serialize<float>(growthTransition_TimeStartsRed, name: "growthTransition_TimeStartsRed");
			spikeMarginLength = s.Serialize<float>(spikeMarginLength, name: "spikeMarginLength");
			isSpawner = s.Serialize<bool>(isSpawner, name: "isSpawner");
			spawneeLimit = s.Serialize<uint>(spawneeLimit, name: "spawneeLimit");
			onOffAffectsAllWaves = s.Serialize<bool>(onOffAffectsAllWaves, name: "onOffAffectsAllWaves");
			smallScaleWhenBlackInTransition = s.Serialize<float>(smallScaleWhenBlackInTransition, name: "smallScaleWhenBlackInTransition");
			limitWaveToBorders = s.Serialize<bool>(limitWaveToBorders, name: "limitWaveToBorders");
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
		public override uint? ClassCRC => 0x93C8B246;
	}
}

