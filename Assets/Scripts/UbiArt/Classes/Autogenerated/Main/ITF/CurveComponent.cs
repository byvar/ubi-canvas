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
		[Games(GameFlags.RJR | GameFlags.RFR)]
		public partial class TrajectoryNode : CSerializable {
			[Serialize("Vector3__0")] public Vector3 Vector3__0;
			[Serialize("Vector3__1")] public Vector3 Vector3__1;
			[Serialize("Vector3__2")] public Vector3 Vector3__2;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(Vector3__0));
					SerializeField(s, nameof(Vector3__1));
					SerializeField(s, nameof(Vector3__2));
				}
			}
		}
		public override uint? ClassCRC => 0x4BBCC846;
	}
}

