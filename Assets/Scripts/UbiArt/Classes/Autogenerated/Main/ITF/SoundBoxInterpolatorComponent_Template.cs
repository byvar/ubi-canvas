using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class SoundBoxInterpolatorComponent_Template : BoxInterpolatorComponent_Template {
		public StringID sound;
		public bool stopOnInactive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			sound = s.SerializeObject<StringID>(sound, name: "sound");
			stopOnInactive = s.Serialize<bool>(stopOnInactive, name: "stopOnInactive");
		}
		public override uint? ClassCRC => 0xF716679C;
	}
}

