using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_MurphyFingerComponent_Template : ActorComponent_Template {
		[Serialize("speedMax"                   )] public float speedMax;
		[Serialize("acceleration"               )] public float acceleration;
		[Serialize("friction"                   )] public float friction;
		[Serialize("controlAcceleration"        )] public float controlAcceleration;
		[Serialize("controlAngle"               )] public Angle controlAngle;
		[Serialize("clampInputMoveMax"          )] public uint clampInputMoveMax;
		[Serialize("screenSoftColThresholdUp"   )] public float screenSoftColThresholdUp;
		[Serialize("screenSoftColThresholdDown" )] public float screenSoftColThresholdDown;
		[Serialize("screenSoftColThresholdLeft" )] public float screenSoftColThresholdLeft;
		[Serialize("screenSoftColThresholdRight")] public float screenSoftColThresholdRight;
		[Serialize("screenSoftColForce"         )] public float screenSoftColForce;
		[Serialize("scratchAnimDuration"        )] public float scratchAnimDuration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(speedMax));
				SerializeField(s, nameof(acceleration));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(controlAcceleration));
				SerializeField(s, nameof(controlAngle));
				SerializeField(s, nameof(clampInputMoveMax));
				SerializeField(s, nameof(screenSoftColThresholdUp));
				SerializeField(s, nameof(screenSoftColThresholdDown));
				SerializeField(s, nameof(screenSoftColThresholdLeft));
				SerializeField(s, nameof(screenSoftColThresholdRight));
				SerializeField(s, nameof(screenSoftColForce));
				SerializeField(s, nameof(scratchAnimDuration));
			} else {
				SerializeField(s, nameof(speedMax));
				SerializeField(s, nameof(acceleration));
				SerializeField(s, nameof(friction));
				SerializeField(s, nameof(controlAcceleration));
				SerializeField(s, nameof(controlAngle));
				SerializeField(s, nameof(clampInputMoveMax));
				SerializeField(s, nameof(screenSoftColThresholdUp));
				SerializeField(s, nameof(screenSoftColThresholdDown));
				SerializeField(s, nameof(screenSoftColThresholdLeft));
				SerializeField(s, nameof(screenSoftColThresholdRight));
				SerializeField(s, nameof(screenSoftColForce));
			}
		}
		public override uint? ClassCRC => 0x7ACCEF2A;
	}
}

