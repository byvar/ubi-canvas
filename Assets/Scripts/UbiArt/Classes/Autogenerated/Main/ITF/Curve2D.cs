using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class Curve2D : CSerializable {
		public CList<Curve2DControlPoint> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			points = s.SerializeObject<CList<Curve2DControlPoint>>(points, name: "points");
		}
	}
}

