using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class Phys2dImpulseConfig : CSerializable {
		public float impulseVal;
		public float impulseAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			impulseVal = s.Serialize<float>(impulseVal, name: "impulseVal");
			impulseAngle = s.Serialize<float>(impulseAngle, name: "impulseAngle");
		}
		public override uint? ClassCRC => 0xF6446077;
	}
}

