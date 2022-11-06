using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class PhysShapeCircle : PhysShape {
		public float Radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Radius = s.Serialize<float>(Radius, name: "Radius");
		}
		public override uint? ClassCRC => 0xE9CCE480;
	}
}

