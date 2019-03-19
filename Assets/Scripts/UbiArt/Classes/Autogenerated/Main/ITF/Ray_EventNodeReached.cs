using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventNodeReached : EventTrigger {
		[Serialize("cameraOn"             )] public int cameraOn;
		[Serialize("cameraOff"            )] public int cameraOff;
		[Serialize("cameraZOffset"        )] public float cameraZOffset;
		[Serialize("cameraOffset"         )] public Vector2 cameraOffset;
		[Serialize("cameraZOffsetDuration")] public float cameraZOffsetDuration;
		[Serialize("cameraOffsetDuration" )] public float cameraOffsetDuration;
		[Serialize("cameraEjectMargin"    )] public Margin cameraEjectMargin;
		[Serialize("cameraDeathMargin"    )] public Margin cameraDeathMargin;
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

