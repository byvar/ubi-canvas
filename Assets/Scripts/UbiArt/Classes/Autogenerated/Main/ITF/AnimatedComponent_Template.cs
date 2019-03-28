using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AnimatedComponent_Template : AnimLightComponent_Template {
		[Serialize("inputs"          )] public CList<InputDesc> inputs;
		[Serialize("tree"            )] public AnimTree_Template tree;
		[Serialize("usefullParameter")] public uint usefullParameter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(inputs));
				SerializeField(s, nameof(tree));
				if (Settings.s.game == Settings.Game.RA) {
					SerializeField(s, nameof(usefullParameter));
				}
			}
		}
		public override uint? ClassCRC => 0x9E401F14;
	}
}

