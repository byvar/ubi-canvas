using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.VH | GameFlags.COL)]
	public partial class AnimatedComponent_Template : AnimLightComponent_Template {
		public CList<InputDesc> inputs;
		public AnimTree_Template tree;
		public uint usefullParameter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				inputs = s.SerializeObject<CList<InputDesc>>(inputs, name: "inputs");
				tree = s.SerializeObject<AnimTree_Template>(tree, name: "tree");
				if (Settings.s.game == Settings.Game.RA) {
					usefullParameter = s.Serialize<uint>(usefullParameter, name: "usefullParameter");
				}
			}
		}
		public override uint? ClassCRC => 0x9E401F14;
	}
}

