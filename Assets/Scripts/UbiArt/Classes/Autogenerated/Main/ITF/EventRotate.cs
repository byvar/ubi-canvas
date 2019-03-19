using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventRotate : Event {
		[Serialize("RelativeAngle")] public bool RelativeAngle;
		[Serialize("Angle"        )] public Angle Angle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(RelativeAngle));
			SerializeField(s, nameof(Angle));
		}
		public override uint? ClassCRC => 0x2947F503;
	}
}

