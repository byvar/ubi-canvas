using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_AIFishBehavior_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("struggle"               )] public Placeholder struggle;
		[Serialize("release"                )] public Placeholder release;
		[Serialize("spikeHit"               )] public Placeholder spikeHit;
		[Serialize("releaseSpeed"           )] public float releaseSpeed;
		[Serialize("releaseAccel"           )] public float releaseAccel;
		[Serialize("rotateOnRelease"        )] public int rotateOnRelease;
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
		public override uint? ClassCRC => 0x9258751C;
	}
}

