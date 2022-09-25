using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.All)]
	public partial class AnimatedComponent_Template : AnimLightComponent_Template {
		public CListO<InputDesc> inputs;
		public AnimTree_Template tree;
		public uint usefullParameter;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				inputs = s.SerializeObject<CListO<InputDesc>>(inputs, name: "inputs");
				tree = s.SerializeObject<AnimTree_Template>(tree, name: "tree");
				if (s.Settings.game == Settings.Game.RA || s.Settings.game == Settings.Game.RM) {
					usefullParameter = s.Serialize<uint>(usefullParameter, name: "usefullParameter");
				}
			}
		}
		public override uint? ClassCRC => 0x9E401F14;
	}
}

