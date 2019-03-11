using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_OnlineEventAnimReset : Event {
		[Serialize("tree"      )] public bool tree;
		[Serialize("transition")] public bool transition;
		[Serialize("curTime"   )] public bool curTime;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tree));
			SerializeField(s, nameof(transition));
			SerializeField(s, nameof(curTime));
		}
		public override uint? ClassCRC => 0xD672B007;
	}
}

