using UnityEngine;

namespace UbiArt.ITF {
	public partial class PadRumble : CSerializable {
		[Serialize("name"          )] public StringID name;
		[Serialize("intensity"     )] public float intensity;
		[Serialize("lightIntensity")] public float lightIntensity;
		[Serialize("duration"      )] public float duration;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(intensity));
			SerializeField(s, nameof(lightIntensity));
			SerializeField(s, nameof(duration));
		}
	}
}

