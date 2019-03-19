using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_BossOceanAIComponent_Template : ActorComponent_Template {
		[Serialize("speedOnBuboHit"       )] public float speedOnBuboHit;
		[Serialize("accelerationOnBuboHit")] public float accelerationOnBuboHit;
		[Serialize("shrinkDuration"       )] public float shrinkDuration;
		[Serialize("shrinkSize"           )] public float shrinkSize;
		[Serialize("shakeFrequency"       )] public float shakeFrequency;
		[Serialize("shakeAmplitude"       )] public float shakeAmplitude;
		[Serialize("retractDelay"         )] public float retractDelay;
		[Serialize("retractSpeed"         )] public float retractSpeed;
		[Serialize("retractTargetSmooth"  )] public float retractTargetSmooth;
		[Serialize("retractSmooth"        )] public float retractSmooth;
		[Serialize("retractOffset"        )] public float retractOffset;
		[Serialize("retractFinishedLimit" )] public float retractFinishedLimit;
		[Serialize("splashFX"             )] public Path splashFX;
		[Serialize("musics"               )] public Placeholder musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(speedOnBuboHit));
				SerializeField(s, nameof(accelerationOnBuboHit));
				SerializeField(s, nameof(shrinkDuration));
				SerializeField(s, nameof(shrinkSize));
				SerializeField(s, nameof(shakeFrequency));
				SerializeField(s, nameof(shakeAmplitude));
				SerializeField(s, nameof(retractDelay));
				SerializeField(s, nameof(retractSpeed));
				SerializeField(s, nameof(retractTargetSmooth));
				SerializeField(s, nameof(retractSmooth));
				SerializeField(s, nameof(retractOffset));
				SerializeField(s, nameof(retractFinishedLimit));
				SerializeField(s, nameof(splashFX));
				SerializeField(s, nameof(musics));
			} else {
				SerializeField(s, nameof(speedOnBuboHit));
				SerializeField(s, nameof(accelerationOnBuboHit));
				SerializeField(s, nameof(shrinkDuration));
				SerializeField(s, nameof(shrinkSize));
				SerializeField(s, nameof(shakeFrequency));
				SerializeField(s, nameof(shakeAmplitude));
				SerializeField(s, nameof(retractDelay));
				SerializeField(s, nameof(retractSpeed));
				SerializeField(s, nameof(retractTargetSmooth));
				SerializeField(s, nameof(retractSmooth));
				SerializeField(s, nameof(retractOffset));
				SerializeField(s, nameof(retractFinishedLimit));
				SerializeField(s, nameof(splashFX));
			}
		}
		public override uint? ClassCRC => 0xFCC6843A;
	}
}

