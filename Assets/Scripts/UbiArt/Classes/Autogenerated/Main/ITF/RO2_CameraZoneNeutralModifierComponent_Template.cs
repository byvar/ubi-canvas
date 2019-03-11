using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_CameraZoneNeutralModifierComponent_Template : ActorComponent_Template {
		[Serialize("zoneNeutral"       )] public Vector2 zoneNeutral;
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

