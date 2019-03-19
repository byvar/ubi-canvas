using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_NautilusAIComponent : CSerializable {
		[Serialize("minAngle"        )] public AngleAmount minAngle;
		[Serialize("maxAngle"        )] public AngleAmount maxAngle;
		[Serialize("mode"            )] public Mode mode;
		[Serialize("lockOnMinReached")] public int lockOnMinReached;
		[Serialize("lockOnMaxReached")] public int lockOnMaxReached;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(minAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(mode));
				SerializeField(s, nameof(lockOnMinReached));
				SerializeField(s, nameof(lockOnMaxReached));
			}
		}
		public enum Mode {
			[Serialize("Mode_Fixed")] Fixed = 0,
			[Serialize("Mode_Roll" )] Roll = 1,
		}
		public override uint? ClassCRC => 0xCC7A9B93;
	}
}

