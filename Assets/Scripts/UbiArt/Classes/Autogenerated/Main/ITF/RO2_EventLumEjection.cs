using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EventLumEjection : Event {
		[Serialize("ejectionForce"       )] public Vector2 ejectionForce;
		[Serialize("ejectionDuration"    )] public float ejectionDuration;
		[Serialize("isAutoPickup"        )] public bool isAutoPickup;
		[Serialize("ejectionGravityAngle")] public Angle ejectionGravityAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(ejectionForce));
			SerializeField(s, nameof(ejectionDuration));
			SerializeField(s, nameof(isAutoPickup));
			SerializeField(s, nameof(ejectionGravityAngle));
		}
		public override uint? ClassCRC => 0xABFFA970;
	}
}

