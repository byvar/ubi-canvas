using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierCurve : CSerializable {
		[Serialize("points")] public CList<BezierCurve.Point> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(points));
			}
		}
		public partial class Point : CSerializable {
			[Serialize("pos" )] public Vector3 pos;
			[Serialize("tanA")] public Vector3 tanA;
			[Serialize("tanB")] public Vector3 tanB;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(pos));
					SerializeField(s, nameof(tanA));
					SerializeField(s, nameof(tanB));
				}
			}
		}
	}
}

