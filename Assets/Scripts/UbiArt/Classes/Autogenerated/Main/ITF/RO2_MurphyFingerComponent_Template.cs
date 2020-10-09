using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_MurphyFingerComponent_Template : ActorComponent_Template {
		public float speedMax;
		public float acceleration;
		public float friction;
		public float controlAcceleration;
		public Angle controlAngle;
		public uint clampInputMoveMax;
		public float screenSoftColThresholdUp;
		public float screenSoftColThresholdDown;
		public float screenSoftColThresholdLeft;
		public float screenSoftColThresholdRight;
		public float screenSoftColForce;
		public float scratchAnimDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				speedMax = s.Serialize<float>(speedMax, name: "speedMax");
				acceleration = s.Serialize<float>(acceleration, name: "acceleration");
				friction = s.Serialize<float>(friction, name: "friction");
				controlAcceleration = s.Serialize<float>(controlAcceleration, name: "controlAcceleration");
				controlAngle = s.SerializeObject<Angle>(controlAngle, name: "controlAngle");
				clampInputMoveMax = s.Serialize<uint>(clampInputMoveMax, name: "clampInputMoveMax");
				screenSoftColThresholdUp = s.Serialize<float>(screenSoftColThresholdUp, name: "screenSoftColThresholdUp");
				screenSoftColThresholdDown = s.Serialize<float>(screenSoftColThresholdDown, name: "screenSoftColThresholdDown");
				screenSoftColThresholdLeft = s.Serialize<float>(screenSoftColThresholdLeft, name: "screenSoftColThresholdLeft");
				screenSoftColThresholdRight = s.Serialize<float>(screenSoftColThresholdRight, name: "screenSoftColThresholdRight");
				screenSoftColForce = s.Serialize<float>(screenSoftColForce, name: "screenSoftColForce");
				scratchAnimDuration = s.Serialize<float>(scratchAnimDuration, name: "scratchAnimDuration");
			} else {
				speedMax = s.Serialize<float>(speedMax, name: "speedMax");
				acceleration = s.Serialize<float>(acceleration, name: "acceleration");
				friction = s.Serialize<float>(friction, name: "friction");
				controlAcceleration = s.Serialize<float>(controlAcceleration, name: "controlAcceleration");
				controlAngle = s.SerializeObject<Angle>(controlAngle, name: "controlAngle");
				clampInputMoveMax = s.Serialize<uint>(clampInputMoveMax, name: "clampInputMoveMax");
				screenSoftColThresholdUp = s.Serialize<float>(screenSoftColThresholdUp, name: "screenSoftColThresholdUp");
				screenSoftColThresholdDown = s.Serialize<float>(screenSoftColThresholdDown, name: "screenSoftColThresholdDown");
				screenSoftColThresholdLeft = s.Serialize<float>(screenSoftColThresholdLeft, name: "screenSoftColThresholdLeft");
				screenSoftColThresholdRight = s.Serialize<float>(screenSoftColThresholdRight, name: "screenSoftColThresholdRight");
				screenSoftColForce = s.Serialize<float>(screenSoftColForce, name: "screenSoftColForce");
			}
		}
		public override uint? ClassCRC => 0x7ACCEF2A;
	}
}

