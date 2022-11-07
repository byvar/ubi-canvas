namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_NautilusAIComponent_Template : ActorComponent_Template {
		public float angularSpeedMultiplier;
		public Angle angularAcceleration;
		public Angle angularDeceleration;
		public float stopDelay;
		public Angle rollbackSpeed;
		public float moveRadius;
		public AngleAmount minAngle;
		public AngleAmount maxAngle;
		public bool lockOnMinReached;
		public bool lockOnMaxReached;
		public Angle endBrakeAngle;
		public StringID input;
		public Angle airControlMinAngularSpeed;
		public Angle airControlMaxAngularSpeed;
		public float airControlMinAmount;
		public float airControlMaxAmount;
		public float airControlMinDuration;
		public float airControlMaxDuration;
		public StringID fx;
		public Angle fxStartSpeed;
		public Angle fxStopSpeed;
		public StringID fxInput;
		public StringID fxEndReached;
		public Angle fxEndReachedStartAngle;
		public Angle fxEndReachedStopAngle;
		public float moveOnTopSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				angularSpeedMultiplier = s.Serialize<float>(angularSpeedMultiplier, name: "angularSpeedMultiplier");
				angularAcceleration = s.SerializeObject<Angle>(angularAcceleration, name: "angularAcceleration");
				angularDeceleration = s.SerializeObject<Angle>(angularDeceleration, name: "angularDeceleration");
				stopDelay = s.Serialize<float>(stopDelay, name: "stopDelay");
				rollbackSpeed = s.SerializeObject<Angle>(rollbackSpeed, name: "rollbackSpeed");
				moveRadius = s.Serialize<float>(moveRadius, name: "moveRadius");
				minAngle = s.SerializeObject<AngleAmount>(minAngle, name: "minAngle");
				maxAngle = s.SerializeObject<AngleAmount>(maxAngle, name: "maxAngle");
				lockOnMinReached = s.Serialize<bool>(lockOnMinReached, name: "lockOnMinReached", options: CSerializerObject.Options.BoolAsByte);
				lockOnMaxReached = s.Serialize<bool>(lockOnMaxReached, name: "lockOnMaxReached", options: CSerializerObject.Options.BoolAsByte);
				endBrakeAngle = s.SerializeObject<Angle>(endBrakeAngle, name: "endBrakeAngle");
				input = s.SerializeObject<StringID>(input, name: "input");
				airControlMinAngularSpeed = s.SerializeObject<Angle>(airControlMinAngularSpeed, name: "airControlMinAngularSpeed");
				airControlMaxAngularSpeed = s.SerializeObject<Angle>(airControlMaxAngularSpeed, name: "airControlMaxAngularSpeed");
				airControlMinAmount = s.Serialize<float>(airControlMinAmount, name: "airControlMinAmount");
				airControlMaxAmount = s.Serialize<float>(airControlMaxAmount, name: "airControlMaxAmount");
				airControlMinDuration = s.Serialize<float>(airControlMinDuration, name: "airControlMinDuration");
				airControlMaxDuration = s.Serialize<float>(airControlMaxDuration, name: "airControlMaxDuration");
				fx = s.SerializeObject<StringID>(fx, name: "fx");
				fxStartSpeed = s.SerializeObject<Angle>(fxStartSpeed, name: "fxStartSpeed");
				fxStopSpeed = s.SerializeObject<Angle>(fxStopSpeed, name: "fxStopSpeed");
				fxInput = s.SerializeObject<StringID>(fxInput, name: "fxInput");
				fxEndReached = s.SerializeObject<StringID>(fxEndReached, name: "fxEndReached");
				fxEndReachedStartAngle = s.SerializeObject<Angle>(fxEndReachedStartAngle, name: "fxEndReachedStartAngle");
				fxEndReachedStopAngle = s.SerializeObject<Angle>(fxEndReachedStopAngle, name: "fxEndReachedStopAngle");
				moveOnTopSpeedMultiplier = s.Serialize<float>(moveOnTopSpeedMultiplier, name: "moveOnTopSpeedMultiplier");
			} else {
				angularSpeedMultiplier = s.Serialize<float>(angularSpeedMultiplier, name: "angularSpeedMultiplier");
				angularAcceleration = s.SerializeObject<Angle>(angularAcceleration, name: "angularAcceleration");
				angularDeceleration = s.SerializeObject<Angle>(angularDeceleration, name: "angularDeceleration");
				stopDelay = s.Serialize<float>(stopDelay, name: "stopDelay");
				rollbackSpeed = s.SerializeObject<Angle>(rollbackSpeed, name: "rollbackSpeed");
				moveRadius = s.Serialize<float>(moveRadius, name: "moveRadius");
				minAngle = s.SerializeObject<AngleAmount>(minAngle, name: "minAngle");
				maxAngle = s.SerializeObject<AngleAmount>(maxAngle, name: "maxAngle");
				lockOnMinReached = s.Serialize<bool>(lockOnMinReached, name: "lockOnMinReached");
				lockOnMaxReached = s.Serialize<bool>(lockOnMaxReached, name: "lockOnMaxReached");
				endBrakeAngle = s.SerializeObject<Angle>(endBrakeAngle, name: "endBrakeAngle");
				input = s.SerializeObject<StringID>(input, name: "input");
				airControlMinAngularSpeed = s.SerializeObject<Angle>(airControlMinAngularSpeed, name: "airControlMinAngularSpeed");
				airControlMaxAngularSpeed = s.SerializeObject<Angle>(airControlMaxAngularSpeed, name: "airControlMaxAngularSpeed");
				airControlMinAmount = s.Serialize<float>(airControlMinAmount, name: "airControlMinAmount");
				airControlMaxAmount = s.Serialize<float>(airControlMaxAmount, name: "airControlMaxAmount");
				airControlMinDuration = s.Serialize<float>(airControlMinDuration, name: "airControlMinDuration");
				airControlMaxDuration = s.Serialize<float>(airControlMaxDuration, name: "airControlMaxDuration");
				fx = s.SerializeObject<StringID>(fx, name: "fx");
				fxStartSpeed = s.SerializeObject<Angle>(fxStartSpeed, name: "fxStartSpeed");
				fxStopSpeed = s.SerializeObject<Angle>(fxStopSpeed, name: "fxStopSpeed");
				fxInput = s.SerializeObject<StringID>(fxInput, name: "fxInput");
				fxEndReached = s.SerializeObject<StringID>(fxEndReached, name: "fxEndReached");
				fxEndReachedStartAngle = s.SerializeObject<Angle>(fxEndReachedStartAngle, name: "fxEndReachedStartAngle");
				fxEndReachedStopAngle = s.SerializeObject<Angle>(fxEndReachedStopAngle, name: "fxEndReachedStopAngle");
				moveOnTopSpeedMultiplier = s.Serialize<float>(moveOnTopSpeedMultiplier, name: "moveOnTopSpeedMultiplier");
			}
		}
		public override uint? ClassCRC => 0x31B6ED8E;
	}
}

