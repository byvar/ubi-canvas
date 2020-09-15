using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventRotate : Event {
		public bool RelativeAngle;
		public Angle Angle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			RelativeAngle = s.Serialize<bool>(RelativeAngle, name: "RelativeAngle");
			Angle = s.SerializeObject<Angle>(Angle, name: "Angle");
		}
		public override uint? ClassCRC => 0x2947F503;
	}
}

