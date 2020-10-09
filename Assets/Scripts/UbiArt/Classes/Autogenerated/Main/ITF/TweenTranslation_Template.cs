using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RL | GameFlags.VH | GameFlags.RA)]
	public partial class TweenTranslation_Template : TweenInstruction_Template {
		public float startDuration;
		public float endDuration;
		public float startSpeed;
		public float endSpeed;
		public bool rotateTrajectory;
		public bool rotateActor;
		public AngleAmount angle;
		public AngleAmount angleOffset;
		public Vec2d scaleMultiplier;
		public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				startDuration = s.Serialize<float>(startDuration, name: "startDuration");
				endDuration = s.Serialize<float>(endDuration, name: "endDuration");
				startSpeed = s.Serialize<float>(startSpeed, name: "startSpeed");
				endSpeed = s.Serialize<float>(endSpeed, name: "endSpeed");
				rotateTrajectory = s.Serialize<bool>(rotateTrajectory, name: "rotateTrajectory");
				rotateActor = s.Serialize<bool>(rotateActor, name: "rotateActor");
				angle = s.SerializeObject<AngleAmount>(angle, name: "angle");
				angleOffset = s.SerializeObject<AngleAmount>(angleOffset, name: "angleOffset");
				scaleMultiplier = s.SerializeObject<Vec2d>(scaleMultiplier, name: "scaleMultiplier");
			} else if (Settings.s.game == Settings.Game.RL) {
				startDuration = s.Serialize<float>(startDuration, name: "startDuration");
				endDuration = s.Serialize<float>(endDuration, name: "endDuration");
				startSpeed = s.Serialize<float>(startSpeed, name: "startSpeed");
				endSpeed = s.Serialize<float>(endSpeed, name: "endSpeed");
				rotateTrajectory = s.Serialize<bool>(rotateTrajectory, name: "rotateTrajectory", options: CSerializerObject.Options.BoolAsByte);
				rotateActor = s.Serialize<bool>(rotateActor, name: "rotateActor", options: CSerializerObject.Options.BoolAsByte);
				angle = s.SerializeObject<AngleAmount>(angle, name: "angle");
				angleOffset = s.SerializeObject<AngleAmount>(angleOffset, name: "angleOffset");
				scaleMultiplier = s.SerializeObject<Vec2d>(scaleMultiplier, name: "scaleMultiplier");
				speed = s.Serialize<float>(speed, name: "speed");
			} else {
				startDuration = s.Serialize<float>(startDuration, name: "startDuration");
				endDuration = s.Serialize<float>(endDuration, name: "endDuration");
				startSpeed = s.Serialize<float>(startSpeed, name: "startSpeed");
				endSpeed = s.Serialize<float>(endSpeed, name: "endSpeed");
				rotateTrajectory = s.Serialize<bool>(rotateTrajectory, name: "rotateTrajectory");
				rotateActor = s.Serialize<bool>(rotateActor, name: "rotateActor");
				angle = s.SerializeObject<AngleAmount>(angle, name: "angle");
				angleOffset = s.SerializeObject<AngleAmount>(angleOffset, name: "angleOffset");
				scaleMultiplier = s.SerializeObject<Vec2d>(scaleMultiplier, name: "scaleMultiplier");
				speed = s.Serialize<float>(speed, name: "speed");
			}
		}
		public override uint? ClassCRC => 0x889B12E1;
	}
}

