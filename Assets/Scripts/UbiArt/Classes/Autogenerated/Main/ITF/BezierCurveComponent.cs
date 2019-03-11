using UnityEngine;

namespace UbiArt.ITF {
	public partial class BezierCurveComponent : ActorComponent {
		[Serialize("bezier")] public BezierCurve bezier;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bezier));
			}
		}
		public override uint? ClassCRC => 0x75ABD328;
	}
}

