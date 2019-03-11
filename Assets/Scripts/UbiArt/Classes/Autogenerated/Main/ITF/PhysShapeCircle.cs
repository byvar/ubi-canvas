using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysShapeCircle : PhysShape {
		[Serialize("Radius")] public float Radius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Radius));
		}
		public override uint? ClassCRC => 0xE9CCE480;
	}
}

