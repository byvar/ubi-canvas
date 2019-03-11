using UnityEngine;

namespace UbiArt.ITF {
	public partial class SoundBoxInterpolatorComponent_Template : BoxInterpolatorComponent_Template {
		[Serialize("sound"         )] public StringID sound;
		[Serialize("stopOnInactive")] public bool stopOnInactive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(sound));
			SerializeField(s, nameof(stopOnInactive));
		}
		public override uint? ClassCRC => 0xF716679C;
	}
}

