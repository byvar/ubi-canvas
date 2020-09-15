using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayStory_evtTemplate : SequenceEvent_Template {
		public Path baseFilePath;
		public bool isVideo;
		public float alpha;
		public float percent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			baseFilePath = s.SerializeObject<Path>(baseFilePath, name: "baseFilePath");
			isVideo = s.Serialize<bool>(isVideo, name: "isVideo");
			alpha = s.Serialize<float>(alpha, name: "alpha");
			percent = s.Serialize<float>(percent, name: "percent");
		}
		public override uint? ClassCRC => 0xC0884D3F;
	}
}

