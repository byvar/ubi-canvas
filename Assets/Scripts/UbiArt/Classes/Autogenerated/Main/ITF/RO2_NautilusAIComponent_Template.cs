using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_NautilusAIComponent_Template : ActorComponent_Template {
		[Serialize("angularSpeedMultiplier"   )] public float angularSpeedMultiplier;
		[Serialize("angularAcceleration"      )] public Angle angularAcceleration;
		[Serialize("angularDeceleration"      )] public Angle angularDeceleration;
		[Serialize("stopDelay"                )] public float stopDelay;
		[Serialize("rollbackSpeed"            )] public Angle rollbackSpeed;
		[Serialize("moveRadius"               )] public float moveRadius;
		[Serialize("minAngle"                 )] public AngleAmount minAngle;
		[Serialize("maxAngle"                 )] public AngleAmount maxAngle;
		[Serialize("lockOnMinReached"         )] public bool lockOnMinReached;
		[Serialize("lockOnMaxReached"         )] public bool lockOnMaxReached;
		[Serialize("endBrakeAngle"            )] public Angle endBrakeAngle;
		[Serialize("input"                    )] public StringID input;
		[Serialize("airControlMinAngularSpeed")] public Angle airControlMinAngularSpeed;
		[Serialize("airControlMaxAngularSpeed")] public Angle airControlMaxAngularSpeed;
		[Serialize("airControlMinAmount"      )] public float airControlMinAmount;
		[Serialize("airControlMaxAmount"      )] public float airControlMaxAmount;
		[Serialize("airControlMinDuration"    )] public float airControlMinDuration;
		[Serialize("airControlMaxDuration"    )] public float airControlMaxDuration;
		[Serialize("fx"                       )] public StringID fx;
		[Serialize("fxStartSpeed"             )] public Angle fxStartSpeed;
		[Serialize("fxStopSpeed"              )] public Angle fxStopSpeed;
		[Serialize("fxInput"                  )] public StringID fxInput;
		[Serialize("fxEndReached"             )] public StringID fxEndReached;
		[Serialize("fxEndReachedStartAngle"   )] public Angle fxEndReachedStartAngle;
		[Serialize("fxEndReachedStopAngle"    )] public Angle fxEndReachedStopAngle;
		[Serialize("moveOnTopSpeedMultiplier" )] public float moveOnTopSpeedMultiplier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(angularSpeedMultiplier));
				SerializeField(s, nameof(angularAcceleration));
				SerializeField(s, nameof(angularDeceleration));
				SerializeField(s, nameof(stopDelay));
				SerializeField(s, nameof(rollbackSpeed));
				SerializeField(s, nameof(moveRadius));
				SerializeField(s, nameof(minAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(lockOnMinReached));
				SerializeField(s, nameof(lockOnMaxReached));
				SerializeField(s, nameof(endBrakeAngle));
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(airControlMinAngularSpeed));
				SerializeField(s, nameof(airControlMaxAngularSpeed));
				SerializeField(s, nameof(airControlMinAmount));
				SerializeField(s, nameof(airControlMaxAmount));
				SerializeField(s, nameof(airControlMinDuration));
				SerializeField(s, nameof(airControlMaxDuration));
				SerializeField(s, nameof(fxStartSpeed));
				SerializeField(s, nameof(fxStopSpeed));
				SerializeField(s, nameof(fxInput));
				SerializeField(s, nameof(fxEndReached));
				SerializeField(s, nameof(fxEndReachedStartAngle));
				SerializeField(s, nameof(fxEndReachedStopAngle));
				SerializeField(s, nameof(moveOnTopSpeedMultiplier));
			} else {
				SerializeField(s, nameof(angularSpeedMultiplier));
				SerializeField(s, nameof(angularAcceleration));
				SerializeField(s, nameof(angularDeceleration));
				SerializeField(s, nameof(stopDelay));
				SerializeField(s, nameof(rollbackSpeed));
				SerializeField(s, nameof(moveRadius));
				SerializeField(s, nameof(minAngle));
				SerializeField(s, nameof(maxAngle));
				SerializeField(s, nameof(lockOnMinReached));
				SerializeField(s, nameof(lockOnMaxReached));
				SerializeField(s, nameof(endBrakeAngle));
				SerializeField(s, nameof(input));
				SerializeField(s, nameof(airControlMinAngularSpeed));
				SerializeField(s, nameof(airControlMaxAngularSpeed));
				SerializeField(s, nameof(airControlMinAmount));
				SerializeField(s, nameof(airControlMaxAmount));
				SerializeField(s, nameof(airControlMinDuration));
				SerializeField(s, nameof(airControlMaxDuration));
				SerializeField(s, nameof(fx));
				SerializeField(s, nameof(fxStartSpeed));
				SerializeField(s, nameof(fxStopSpeed));
				SerializeField(s, nameof(fxInput));
				SerializeField(s, nameof(fxEndReached));
				SerializeField(s, nameof(fxEndReachedStartAngle));
				SerializeField(s, nameof(fxEndReachedStopAngle));
				SerializeField(s, nameof(moveOnTopSpeedMultiplier));
			}
		}
		public override uint? ClassCRC => 0x31B6ED8E;
	}
}

