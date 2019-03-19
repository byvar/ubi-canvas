using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_MagicCurveComponent_Template : ActorComponent_Template {
		[Serialize("bezierRenderer")] public BezierCurveRenderer_Template bezierRenderer;
		[Serialize("debug"         )] public bool debug;
		[Serialize("useOrientation")] public bool useOrientation;
		[Serialize("distMin"       )] public float distMin;
		[Serialize("uvScrollFactor")] public float uvScrollFactor;
		[Serialize("extraLength"   )] public float extraLength;
		[Serialize("offset"        )] public Vector2 offset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bezierRenderer));
			SerializeField(s, nameof(debug));
			SerializeField(s, nameof(useOrientation));
			SerializeField(s, nameof(distMin));
			SerializeField(s, nameof(uvScrollFactor));
			SerializeField(s, nameof(extraLength));
			SerializeField(s, nameof(offset));
		}
		public override uint? ClassCRC => 0xCC65456C;
	}
}

