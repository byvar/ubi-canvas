using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_AIFishBehavior_Template : RO2_AIGroundBaseBehavior_Template {
		[Serialize("struggle"               )] public Generic<AIAction_Template> struggle;
		[Serialize("release"                )] public Generic<AIAction_Template> release;
		[Serialize("spikeHit"               )] public Generic<RO2_AIReceiveCameraEjectHitAction_Template> spikeHit;
		[Serialize("releaseSpeed"           )] public float releaseSpeed;
		[Serialize("releaseAccel"           )] public float releaseAccel;
		[Serialize("rotateOnRelease"        )] public bool rotateOnRelease;
		[Serialize("rotationSpeed"          )] public Angle rotationSpeed;
		[Serialize("struggleOffsetAmplitude")] public float struggleOffsetAmplitude;
		[Serialize("struggleOffsetFrequency")] public float struggleOffsetFrequency;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(struggle));
			SerializeField(s, nameof(release));
			SerializeField(s, nameof(spikeHit));
			SerializeField(s, nameof(releaseSpeed));
			SerializeField(s, nameof(releaseAccel));
			SerializeField(s, nameof(rotateOnRelease));
			SerializeField(s, nameof(rotationSpeed));
			SerializeField(s, nameof(struggleOffsetAmplitude));
			SerializeField(s, nameof(struggleOffsetFrequency));
		}
		public override uint? ClassCRC => 0x93980974;
	}
}

