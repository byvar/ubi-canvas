using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicTreeNodePlayMusic_Template : BlendTreeNodeTemplate<Q23ITF14AnimTreeResult> {
		[Serialize("nodeName" )] public StringID nodeName;
		[Serialize("musicName")] public StringID musicName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(musicName));
			} else {
				SerializeField(s, nameof(nodeName));
				SerializeField(s, nameof(musicName));
			}
		}
		public override uint? ClassCRC => 0x6818BD48;
	}
}

