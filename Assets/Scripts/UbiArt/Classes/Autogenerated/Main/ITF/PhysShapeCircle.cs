using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhysShapeCircle : PhysShape {
		public float Radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Radius = s.Serialize<float>(Radius, name: "Radius");
		}
		public override uint? ClassCRC => 0xE9CCE480;
	}
}

