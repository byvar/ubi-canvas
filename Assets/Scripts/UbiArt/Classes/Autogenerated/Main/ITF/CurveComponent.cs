using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class CurveComponent : ActorComponent {
		public CList<CurveComponent.TrajectoryNode> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				points = s.SerializeObject<CList<CurveComponent.TrajectoryNode>>(points, name: "points");
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class TrajectoryNode : CSerializable {
			public Vec3d pos;
			public Vec3d tangA;
			public Vec3d tangB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					pos = s.SerializeObject<Vec3d>(pos, name: "pos");
					tangA = s.SerializeObject<Vec3d>(tangA, name: "tangA");
					tangB = s.SerializeObject<Vec3d>(tangB, name: "tangB");
				}
			}
		}
		public override uint? ClassCRC => 0x4BBCC846;
	}
}

