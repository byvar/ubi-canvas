using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class WwiseSoundBoxInterpolatorComponent : BoxInterpolatorComponent {
		public StringID WwiseGUID_sound;
		public bool stopOnInactive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseGUID_sound = s.SerializeObject<StringID>(WwiseGUID_sound, name: "WwiseGUID_sound");
			stopOnInactive = s.Serialize<bool>(stopOnInactive, name: "stopOnInactive");
		}
		public override uint? ClassCRC => 0xFB59254E;
	}
}

