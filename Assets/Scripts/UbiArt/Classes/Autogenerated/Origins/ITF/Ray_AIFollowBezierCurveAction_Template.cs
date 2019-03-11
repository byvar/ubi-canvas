using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIFollowBezierCurveAction_Template : AIAction_Template {
		[Serialize("speed")] public float speed;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(speed));
		}
		public override uint? ClassCRC => 0x3D78E610;
	}
}

