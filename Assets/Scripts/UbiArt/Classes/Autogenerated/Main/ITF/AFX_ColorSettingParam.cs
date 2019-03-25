using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.COL | GameFlags.RL)]
	public partial class AFX_ColorSettingParam : CSerializable {
		[Serialize("use"            )] public bool use;
		[Serialize("saturation"     )] public float saturation;
		[Serialize("contrast"       )] public float contrast;
		[Serialize("contrastScale"  )] public float contrastScale;
		[Serialize("bright"         )] public float bright;
		[Serialize("colorCorrection")] public Color colorCorrection;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(use), boolAsByte: true);
			} else {
				SerializeField(s, nameof(use));
			}
			SerializeField(s, nameof(saturation));
			SerializeField(s, nameof(contrast));
			SerializeField(s, nameof(contrastScale));
			SerializeField(s, nameof(bright));
			SerializeField(s, nameof(colorCorrection));
		}
	}
}

