using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_NautilusAIComponent : ActorComponent {
		public AngleAmount minAngle;
		public AngleAmount maxAngle;
		public Mode mode;
		public bool lockOnMinReached;
		public bool lockOnMaxReached;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					minAngle = s.SerializeObject<AngleAmount>(minAngle, name: "minAngle");
					maxAngle = s.SerializeObject<AngleAmount>(maxAngle, name: "maxAngle");
					mode = s.Serialize<Mode>(mode, name: "mode");
					lockOnMinReached = s.Serialize<bool>(lockOnMinReached, name: "lockOnMinReached", options: CSerializerObject.Options.BoolAsByte);
					lockOnMaxReached = s.Serialize<bool>(lockOnMaxReached, name: "lockOnMaxReached", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					minAngle = s.SerializeObject<AngleAmount>(minAngle, name: "minAngle");
					maxAngle = s.SerializeObject<AngleAmount>(maxAngle, name: "maxAngle");
					mode = s.Serialize<Mode>(mode, name: "mode");
					lockOnMinReached = s.Serialize<bool>(lockOnMinReached, name: "lockOnMinReached");
					lockOnMaxReached = s.Serialize<bool>(lockOnMaxReached, name: "lockOnMaxReached");
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

