using UnityEngine;

namespace UbiArt.ITF {
	public partial class WwiseSoundBoxInterpolatorComponent : BoxInterpolatorComponent {
		[Serialize("WwiseGUID_sound")] public StringID WwiseGUID_sound;
		[Serialize("stopOnInactive" )] public bool stopOnInactive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseGUID_sound));
			SerializeField(s, nameof(stopOnInactive));
		}
		public override uint? ClassCRC => 0xFB59254E;
	}
}

