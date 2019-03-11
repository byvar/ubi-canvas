using UnityEngine;

namespace UbiArt.ITF {
	public partial class PhysShapeBox : PhysShapePolygon {
		[Serialize("Extent")] public Vector2 Extent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Extent));
		}
		public override uint? ClassCRC => 0xD1DD9FA9;
	}
}

