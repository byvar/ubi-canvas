using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventLumEjection : Event {
		[Serialize("ejectionForce"       )] public Vec2d ejectionForce;
		[Serialize("ejectionDuration"    )] public float ejectionDuration;
		[Serialize("isAutoPickup"        )] public int isAutoPickup;
		[Serialize("ejectionGravityAngle")] public Angle ejectionGravityAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ejectionForce));
			SerializeField(s, nameof(ejectionDuration));
			SerializeField(s, nameof(isAutoPickup));
			SerializeField(s, nameof(ejectionGravityAngle));
		}
		public override uint? ClassCRC => 0x15FB877D;
	}
}

