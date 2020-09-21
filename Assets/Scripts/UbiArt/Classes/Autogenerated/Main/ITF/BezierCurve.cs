using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class BezierCurve : CSerializable {
		public CListO<BezierCurve.Point> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				points = s.SerializeObject<CListO<BezierCurve.Point>>(points, name: "points");
			}
		}
		[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
		public partial class Point : CSerializable {
			public Vec3d pos;
			public Vec3d tanA;
			public Vec3d tanB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					pos = s.SerializeObject<Vec3d>(pos, name: "pos");
					tanA = s.SerializeObject<Vec3d>(tanA, name: "tanA");
					tanB = s.SerializeObject<Vec3d>(tanB, name: "tanB");
				}
			}
		}
	}
}

