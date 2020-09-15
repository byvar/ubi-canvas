using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class MusicTreeNodePlayMusic_Template : MusicTreeNode_Template {
		public StringID musicName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			musicName = s.SerializeObject<StringID>(musicName, name: "musicName");
		}
		public override uint? ClassCRC => 0x6818BD48;
	}
}

