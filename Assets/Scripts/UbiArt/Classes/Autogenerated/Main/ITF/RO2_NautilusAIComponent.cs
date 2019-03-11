using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_NautilusAIComponent : ActorComponent {
		[Serialize("minAngle"        )] public AngleAmount minAngle;
		[Serialize("maxAngle"        )] public AngleAmount maxAngle;
		[Serialize("mode"            )] public Mode mode;
		[Serialize("lockOnMinReached")] public int lockOnMinReached;
		[Serialize("lockOnMaxReached")] public int lockOnMaxReached;
		[Serialize("lockOnMinReached")] public bool lockOnMinReached;
		[Serialize("lockOnMaxReached")] public bool lockOnMaxReached;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(minAngle));
					SerializeField(s, nameof(maxAngle));
					SerializeField(s, nameof(mode));
					SerializeField(s, nameof(lockOnMinReached));
					SerializeField(s, nameof(lockOnMinReached));
					SerializeField(s, nameof(lockOnMaxReached));
				}
				SerializeField(s, nameof(lockOnMaxReached));
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(minAngle));
					SerializeField(s, nameof(maxAngle));
					SerializeField(s, nameof(mode));
					SerializeField(s, nameof(lockOnMinReached));
					SerializeField(s, nameof(lockOnMaxReached));
				}
			}
		}
		public enum Mode {
			[Serialize("Mode_Fixed")] Fixed = 0,
			[Serialize("Mode_Roll" )] Roll = 1,
		}
		public override uint? ClassCRC => 0x1E82D160;
	}
}

