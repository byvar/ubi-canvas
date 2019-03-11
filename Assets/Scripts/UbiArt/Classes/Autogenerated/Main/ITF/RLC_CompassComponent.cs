using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CompassComponent : ActorComponent {
		[Serialize("maxRange"  )] public float maxRange;
		[Serialize("hysteresis")] public float hysteresis;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(maxRange));
			SerializeField(s, nameof(hysteresis));
		}
		public override uint? ClassCRC => 0xF3D118E2;
	}
}

