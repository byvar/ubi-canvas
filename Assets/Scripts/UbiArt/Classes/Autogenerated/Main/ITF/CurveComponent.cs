using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class CurveComponent : ActorComponent {
		[Serialize("points")] public CList<CurveComponent.TrajectoryNode> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(points));
			}
		}
		[Games(GameFlags.ROVersion)]
		public partial class TrajectoryNode : CSerializable {
			[Serialize("pos"  )] public Vector3 pos;
			[Serialize("tangA")] public Vector3 tangA;
			[Serialize("tangB")] public Vector3 tangB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(pos));
					SerializeField(s, nameof(tangA));
					SerializeField(s, nameof(tangB));
				}
			}
		}
		public override uint? ClassCRC => 0x4BBCC846;
	}
}

