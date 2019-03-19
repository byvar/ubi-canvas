using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class Phys2dImpulseConfig : CSerializable {
		[Serialize("impulseVal"  )] public float impulseVal;
		[Serialize("impulseAngle")] public float impulseAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(impulseVal));
			SerializeField(s, nameof(impulseAngle));
		}
		public override uint? ClassCRC => 0xF6446077;
	}
}

