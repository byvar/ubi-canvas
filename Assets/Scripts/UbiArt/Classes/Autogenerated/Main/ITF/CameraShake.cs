using UnityEngine;

namespace UbiArt.ITF {
	public partial class CameraShake : CSerializable {
		[Serialize("name"           )] public StringID name;
		[Serialize("intensity"      )] public float intensity;
		[Serialize("duration"       )] public float duration;
		[Serialize("easeInDuration" )] public float easeInDuration;
		[Serialize("easeOutDuration")] public float easeOutDuration;
		[Serialize("shakeX"         )] public CameraShakeCurveParams shakeX;
		[Serialize("shakeY"         )] public CameraShakeCurveParams shakeY;
		[Serialize("shakeZ"         )] public CameraShakeCurveParams shakeZ;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(name));
			SerializeField(s, nameof(intensity));
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(easeInDuration));
			SerializeField(s, nameof(easeOutDuration));
			SerializeField(s, nameof(shakeX));
			SerializeField(s, nameof(shakeY));
			SerializeField(s, nameof(shakeZ));
		}
	}
}

