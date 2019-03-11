using UnityEngine;

namespace UbiArt.ITF {
	public partial class AFX_GlowParam : CSerializable {
		[Serialize("use"            )] public bool use;
		[Serialize("factor"         )] public float factor;
		[Serialize("blurSize"       )] public float blurSize;
		[Serialize("bigBlur"        )] public bool bigBlur;
		[Serialize("threshold"      )] public float threshold;
		[Serialize("thresholdSmooth")] public float thresholdSmooth;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(factor));
			SerializeField(s, nameof(blurSize));
			SerializeField(s, nameof(bigBlur));
			SerializeField(s, nameof(threshold));
			SerializeField(s, nameof(thresholdSmooth));
		}
	}
}

