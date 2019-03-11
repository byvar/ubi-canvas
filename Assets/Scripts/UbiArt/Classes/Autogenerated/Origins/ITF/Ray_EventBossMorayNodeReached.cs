using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventBossMorayNodeReached : EventTrigger {
		[Serialize("speed"                 )] public float speed;
		[Serialize("acceleration"          )] public float acceleration;
		[Serialize("disableSpeedMultiplier")] public bool disableSpeedMultiplier;
		[Serialize("startDash"             )] public bool startDash;
		[Serialize("stopDash"              )] public bool stopDash;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
			SerializeField(s, nameof(acceleration));
			SerializeField(s, nameof(disableSpeedMultiplier));
			SerializeField(s, nameof(startDash));
			SerializeField(s, nameof(stopDash));
		}
		public override uint? ClassCRC => 0x1D48A8B5;
	}
}

