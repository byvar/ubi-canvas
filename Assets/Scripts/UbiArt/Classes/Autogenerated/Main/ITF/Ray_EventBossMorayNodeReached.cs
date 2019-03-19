using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_EventBossMorayNodeReached : EventTrigger {
		[Serialize("speed"                 )] public float speed;
		[Serialize("acceleration"          )] public float acceleration;
		[Serialize("disableSpeedMultiplier")] public int disableSpeedMultiplier;
		[Serialize("startDash"             )] public int startDash;
		[Serialize("stopDash"              )] public int stopDash;
		[Serialize("LeadCam"               )] public int LeadCam;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(acceleration));
				SerializeField(s, nameof(disableSpeedMultiplier));
				SerializeField(s, nameof(startDash));
				SerializeField(s, nameof(stopDash));
				SerializeField(s, nameof(LeadCam));
			} else {
				SerializeField(s, nameof(speed));
				SerializeField(s, nameof(acceleration));
				SerializeField(s, nameof(disableSpeedMultiplier));
				SerializeField(s, nameof(startDash));
				SerializeField(s, nameof(stopDash));
			}
		}
		public override uint? ClassCRC => 0x1D48A8B5;
	}
}

