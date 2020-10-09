using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH | GameFlags.RA)]
	public partial class Curve2D : CSerializable {
		public CListO<Curve2DControlPoint> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			points = s.SerializeObject<CListO<Curve2DControlPoint>>(points, name: "points");
		}
	}
}

