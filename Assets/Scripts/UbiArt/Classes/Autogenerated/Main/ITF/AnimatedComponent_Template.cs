using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AnimatedComponent_Template : AnimLightComponent_Template {
		[Serialize("inputs"              )] public CList<InputDesc> inputs;
		[Serialize("tree"                )] public AnimTree_Template tree;
		[Serialize("usefullParameter"    )] public uint usefullParameter;
		[Serialize("CArray<InputDesc>__0")] public CArray<InputDesc> CArray_InputDesc__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(CArray_InputDesc__0));
				}
			} else if (Settings.s.game == Settings.Game.RO || Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.VH) {
				if (s.HasFlags(SerializeFlags.Flags_xC0)) {
					SerializeField(s, nameof(inputs));
					SerializeField(s, nameof(tree));
				}
			} else if (Settings.s.game == Settings.Game.COL) {
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

