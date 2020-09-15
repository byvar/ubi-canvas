using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_CameraZoneNeutralModifierComponent_Template : ActorComponent_Template {
		[Serialize("zoneNeutral"       )] public Vec2d zoneNeutral;
		[Serialize("swipeSpeed"        )] public float swipeSpeed;
		[Serialize("swipeToleranceTime")] public float swipeToleranceTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(zoneNeutral));
			SerializeField(s, nameof(swipeSpeed));
			SerializeField(s, nameof(swipeToleranceTime));
		}
		public override uint? ClassCRC => 0xBE62EA71;
	}
}

