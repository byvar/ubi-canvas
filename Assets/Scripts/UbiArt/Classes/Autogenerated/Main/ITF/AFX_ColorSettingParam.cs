using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class AFX_ColorSettingParam : CSerializable {
		[Serialize("use"            )] public bool use;
		[Serialize("saturation"     )] public float saturation;
		[Serialize("contrast"       )] public float contrast;
		[Serialize("contrastScale"  )] public float contrastScale;
		[Serialize("bright"         )] public float bright;
		[Serialize("colorCorrection")] public Color colorCorrection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(use));
			SerializeField(s, nameof(saturation));
			SerializeField(s, nameof(contrast));
			SerializeField(s, nameof(contrastScale));
			SerializeField(s, nameof(bright));
			SerializeField(s, nameof(colorCorrection));
		}
	}
}

