using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PhysShapeBox : PhysShapePolygon {
		[Serialize("Extent")] public Vec2d Extent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Extent));
		}
		public override uint? ClassCRC => 0xD1DD9FA9;
	}
}

