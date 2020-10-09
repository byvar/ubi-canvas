using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventBossMorayNodeReached : EventTrigger {
		public float speed;
		public float acceleration;
		public int disableSpeedMultiplier;
		public int startDash;
		public int stopDash;
		public int LeadCam;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				speed = s.Serialize<float>(speed, name: "speed");
				acceleration = s.Serialize<float>(acceleration, name: "acceleration");
				disableSpeedMultiplier = s.Serialize<int>(disableSpeedMultiplier, name: "disableSpeedMultiplier");
				startDash = s.Serialize<int>(startDash, name: "startDash");
				stopDash = s.Serialize<int>(stopDash, name: "stopDash");
				LeadCam = s.Serialize<int>(LeadCam, name: "LeadCam");
			} else {
				speed = s.Serialize<float>(speed, name: "speed");
				acceleration = s.Serialize<float>(acceleration, name: "acceleration");
				disableSpeedMultiplier = s.Serialize<int>(disableSpeedMultiplier, name: "disableSpeedMultiplier");
				startDash = s.Serialize<int>(startDash, name: "startDash");
				stopDash = s.Serialize<int>(stopDash, name: "stopDash");
			}
		}
		public override uint? ClassCRC => 0x1D48A8B5;
	}
}

