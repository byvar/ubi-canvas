using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.VH)]
	public partial class RO2_EventNodeReached : EventTrigger {
		public bool cameraOn;
		public bool cameraOff;
		public float cameraZOffset;
		public Vec2d cameraOffset;
		public float cameraZOffsetDuration;
		public float cameraOffsetDuration;
		public Margin cameraEjectMargin;
		public Margin cameraDeathMargin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			cameraOn = s.Serialize<bool>(cameraOn, name: "cameraOn");
			cameraOff = s.Serialize<bool>(cameraOff, name: "cameraOff");
			cameraZOffset = s.Serialize<float>(cameraZOffset, name: "cameraZOffset");
			cameraOffset = s.SerializeObject<Vec2d>(cameraOffset, name: "cameraOffset");
			cameraZOffsetDuration = s.Serialize<float>(cameraZOffsetDuration, name: "cameraZOffsetDuration");
			cameraOffsetDuration = s.Serialize<float>(cameraOffsetDuration, name: "cameraOffsetDuration");
			cameraEjectMargin = s.SerializeObject<Margin>(cameraEjectMargin, name: "cameraEjectMargin");
			cameraDeathMargin = s.SerializeObject<Margin>(cameraDeathMargin, name: "cameraDeathMargin");
		}
		public override uint? ClassCRC => 0x2257A4E3;
	}
}

