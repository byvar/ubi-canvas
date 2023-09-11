namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_BossOceanAIComponent_Template : ActorComponent_Template {
		public float speedOnBuboHit;
		public float accelerationOnBuboHit;
		public float shrinkDuration;
		public float shrinkSize;
		public float shakeFrequency;
		public float shakeAmplitude;
		public float retractDelay;
		public float retractSpeed;
		public float retractTargetSmooth;
		public float retractSmooth;
		public float retractOffset;
		public float retractFinishedLimit;
		public Path splashFX;
		public CListO<EventPlayMusic> musics;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				speedOnBuboHit = s.Serialize<float>(speedOnBuboHit, name: "speedOnBuboHit");
				accelerationOnBuboHit = s.Serialize<float>(accelerationOnBuboHit, name: "accelerationOnBuboHit");
				shrinkDuration = s.Serialize<float>(shrinkDuration, name: "shrinkDuration");
				shrinkSize = s.Serialize<float>(shrinkSize, name: "shrinkSize");
				shakeFrequency = s.Serialize<float>(shakeFrequency, name: "shakeFrequency");
				shakeAmplitude = s.Serialize<float>(shakeAmplitude, name: "shakeAmplitude");
				retractDelay = s.Serialize<float>(retractDelay, name: "retractDelay");
				retractSpeed = s.Serialize<float>(retractSpeed, name: "retractSpeed");
				retractTargetSmooth = s.Serialize<float>(retractTargetSmooth, name: "retractTargetSmooth");
				retractSmooth = s.Serialize<float>(retractSmooth, name: "retractSmooth");
				retractOffset = s.Serialize<float>(retractOffset, name: "retractOffset");
				retractFinishedLimit = s.Serialize<float>(retractFinishedLimit, name: "retractFinishedLimit");
				splashFX = s.SerializeObject<Path>(splashFX, name: "splashFX");
				musics = s.SerializeObject<CListO<EventPlayMusic>>(musics, name: "musics");
			} else {
				speedOnBuboHit = s.Serialize<float>(speedOnBuboHit, name: "speedOnBuboHit");
				accelerationOnBuboHit = s.Serialize<float>(accelerationOnBuboHit, name: "accelerationOnBuboHit");
				shrinkDuration = s.Serialize<float>(shrinkDuration, name: "shrinkDuration");
				shrinkSize = s.Serialize<float>(shrinkSize, name: "shrinkSize");
				shakeFrequency = s.Serialize<float>(shakeFrequency, name: "shakeFrequency");
				shakeAmplitude = s.Serialize<float>(shakeAmplitude, name: "shakeAmplitude");
				retractDelay = s.Serialize<float>(retractDelay, name: "retractDelay");
				retractSpeed = s.Serialize<float>(retractSpeed, name: "retractSpeed");
				retractTargetSmooth = s.Serialize<float>(retractTargetSmooth, name: "retractTargetSmooth");
				retractSmooth = s.Serialize<float>(retractSmooth, name: "retractSmooth");
				retractOffset = s.Serialize<float>(retractOffset, name: "retractOffset");
				retractFinishedLimit = s.Serialize<float>(retractFinishedLimit, name: "retractFinishedLimit");
				splashFX = s.SerializeObject<Path>(splashFX, name: "splashFX");
			}
		}
		public override uint? ClassCRC => 0xFCC6843A;
	}
}

