using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventLumEjection : Event {
		public Vec2d ejectionForce;
		public float ejectionDuration;
		public int isAutoPickup;
		public Angle ejectionGravityAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			ejectionForce = s.SerializeObject<Vec2d>(ejectionForce, name: "ejectionForce");
			ejectionDuration = s.Serialize<float>(ejectionDuration, name: "ejectionDuration");
			isAutoPickup = s.Serialize<int>(isAutoPickup, name: "isAutoPickup");
			ejectionGravityAngle = s.SerializeObject<Angle>(ejectionGravityAngle, name: "ejectionGravityAngle");
		}
		public override uint? ClassCRC => 0x15FB877D;
	}
}

