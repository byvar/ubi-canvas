using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RLVersion)]
	public partial class Unknown_RL_295_sub_942830 : MusicTreeNode_Template {
		public int looping;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			looping = s.Serialize<int>(looping, name: "looping");
		}
		public override uint? ClassCRC => 0x0D375BB7;
	}
}

