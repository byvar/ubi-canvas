using UnityEngine;

namespace UbiArt.ITF {
	public partial class ProceduralInputData : CSerializable {
		[Serialize("input"       )] public StringID input;
		[Serialize("min"         )] public float min;
		[Serialize("max"         )] public float max;
		[Serialize("initialValue")] public float initialValue;
		[Serialize("minValue"    )] public float minValue;
		[Serialize("maxValue"    )] public float maxValue;
		[Serialize("mod"         )] public bool mod;
		[Serialize("abs"         )] public bool abs;
		[Serialize("add"         )] public bool add;
		[Serialize("sin"         )] public bool sin;
		[Serialize("curve"       )] public Spline curve;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(input));
			SerializeField(s, nameof(min));
			SerializeField(s, nameof(max));
			SerializeField(s, nameof(initialValue));
			SerializeField(s, nameof(minValue));
			SerializeField(s, nameof(maxValue));
			SerializeField(s, nameof(mod));
			SerializeField(s, nameof(abs));
			SerializeField(s, nameof(add));
			SerializeField(s, nameof(sin));
			SerializeField(s, nameof(curve));
		}
	}
}

