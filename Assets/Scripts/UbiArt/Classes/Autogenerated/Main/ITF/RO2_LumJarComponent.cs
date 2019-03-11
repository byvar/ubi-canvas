using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_LumJarComponent : ActorComponent {
		[Serialize("shape" )] public EditableShape shape;
		[Serialize("hookUp")] public bool hookUp;
		[Serialize("hookDn")] public bool hookDn;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(shape));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(shape));
					SerializeField(s, nameof(hookUp));
					SerializeField(s, nameof(hookDn));
				}
			}
		}
		public override uint? ClassCRC => 0x3F4B0FFD;
	}
}

