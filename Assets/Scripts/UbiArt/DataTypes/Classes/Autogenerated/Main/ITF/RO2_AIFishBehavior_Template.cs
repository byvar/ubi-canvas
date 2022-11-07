namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_AIFishBehavior_Template : RO2_AIGroundBaseBehavior_Template {
		public Generic<AIAction_Template> struggle;
		public Generic<AIAction_Template> release;
		public Generic<RO2_AIReceiveCameraEjectHitAction_Template> spikeHit;
		public float releaseSpeed;
		public float releaseAccel;
		public bool rotateOnRelease;
		public Angle rotationSpeed;
		public float struggleOffsetAmplitude;
		public float struggleOffsetFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			struggle = s.SerializeObject<Generic<AIAction_Template>>(struggle, name: "struggle");
			release = s.SerializeObject<Generic<AIAction_Template>>(release, name: "release");
			spikeHit = s.SerializeObject<Generic<RO2_AIReceiveCameraEjectHitAction_Template>>(spikeHit, name: "spikeHit");
			releaseSpeed = s.Serialize<float>(releaseSpeed, name: "releaseSpeed");
			releaseAccel = s.Serialize<float>(releaseAccel, name: "releaseAccel");
			rotateOnRelease = s.Serialize<bool>(rotateOnRelease, name: "rotateOnRelease");
			rotationSpeed = s.SerializeObject<Angle>(rotationSpeed, name: "rotationSpeed");
			struggleOffsetAmplitude = s.Serialize<float>(struggleOffsetAmplitude, name: "struggleOffsetAmplitude");
			struggleOffsetFrequency = s.Serialize<float>(struggleOffsetFrequency, name: "struggleOffsetFrequency");
		}
		public override uint? ClassCRC => 0x93980974;
	}
}

