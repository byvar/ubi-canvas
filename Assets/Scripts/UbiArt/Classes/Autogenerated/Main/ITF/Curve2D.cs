using UnityEngine;

namespace UbiArt.ITF {
	public partial class Curve2D : CSerializable {
		[Serialize("points")] public CList<Curve2DControlPoint> points;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(points));
		}
	}
}

