using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_RotatingPlatformComponent : ActorComponent {
		[Serialize("rotating"            )] public bool rotating;
		[Serialize("destinationAngle"    )] public Angle destinationAngle;
		[Serialize("blendTime"           )] public float blendTime;
		[Serialize("angularSpeed"        )] public float angularSpeed;
		[Serialize("useClockwiseRotation")] public bool useClockwiseRotation;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(rotating));
			}
			SerializeField(s, nameof(destinationAngle));
			SerializeField(s, nameof(blendTime));
			SerializeField(s, nameof(angularSpeed));
			SerializeField(s, nameof(useClockwiseRotation));
		}
		public override uint? ClassCRC => 0xCF1C34AF;
	}
}

