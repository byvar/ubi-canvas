using UnityEngine;

namespace UbiArt.ITF {
	public partial class ZInput : CSerializable {
		[Serialize("control"      )] public StringID control;
		[Serialize("query"        )] public StringID query;
		[Serialize("threshold"    )] public float threshold;
		[Serialize("delay"        )] public float delay;
		[Serialize("decreaseSpeed")] public float decreaseSpeed;
		[Serialize("increaseValue")] public float increaseValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(control));
			SerializeField(s, nameof(query));
			SerializeField(s, nameof(threshold));
			SerializeField(s, nameof(delay));
			SerializeField(s, nameof(decreaseSpeed));
			SerializeField(s, nameof(increaseValue));
		}
	}
}

