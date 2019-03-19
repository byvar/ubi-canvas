using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class PlayStory_evtTemplate : SequenceEvent_Template {
		[Serialize("baseFilePath")] public Path baseFilePath;
		[Serialize("isVideo"     )] public bool isVideo;
		[Serialize("alpha"       )] public float alpha;
		[Serialize("percent"     )] public float percent;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(baseFilePath));
			SerializeField(s, nameof(isVideo));
			SerializeField(s, nameof(alpha));
			SerializeField(s, nameof(percent));
		}
		public override uint? ClassCRC => 0xC0884D3F;
	}
}

