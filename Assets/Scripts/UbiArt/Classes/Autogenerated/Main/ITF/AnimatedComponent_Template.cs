using UnityEngine;

namespace UbiArt.ITF {
	public partial class AnimatedComponent_Template : AnimLightComponent_Template {
		[Serialize("inputs"          )] public CList<InputDesc> inputs;
		[Serialize("tree"            )] public AnimTree_Template tree;
		[Serialize("usefullParameter")] public uint usefullParameter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(inputs));
					SerializeField(s, nameof(tree));
				}
			} else if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(inputs));
					SerializeField(s, nameof(tree));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(inputs));
					SerializeField(s, nameof(tree));
					SerializeField(s, nameof(usefullParameter));
				}
			}
		}
		public override uint? ClassCRC => 0x9E401F14;
	}
}

