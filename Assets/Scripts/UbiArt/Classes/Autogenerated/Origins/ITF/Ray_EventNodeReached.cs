using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventNodeReached : EventTrigger {
		[Serialize("cameraOn"             )] public bool cameraOn;
		[Serialize("cameraOff"            )] public bool cameraOff;
		[Serialize("cameraZOffset"        )] public float cameraZOffset;
		[Serialize("cameraOffset"         )] public Vector2 cameraOffset;
		[Serialize("cameraZOffsetDuration")] public float cameraZOffsetDuration;
		[Serialize("cameraOffsetDuration" )] public float cameraOffsetDuration;
		[Serialize("cameraEjectMargin"    )] public Placeholder cameraEjectMargin;
		[Serialize("cameraDeathMargin"    )] public Placeholder cameraDeathMargin;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(cameraOn));
			SerializeField(s, nameof(cameraOff));
			SerializeField(s, nameof(cameraZOffset));
			SerializeField(s, nameof(cameraOffset));
			SerializeField(s, nameof(cameraZOffsetDuration));
			SerializeField(s, nameof(cameraOffsetDuration));
			SerializeField(s, nameof(cameraEjectMargin));
			SerializeField(s, nameof(cameraDeathMargin));
		}
		public override uint? ClassCRC => 0x937550D3;
	}
}

