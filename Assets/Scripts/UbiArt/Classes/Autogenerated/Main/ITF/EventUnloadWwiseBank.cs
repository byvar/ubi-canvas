using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventUnloadWwiseBank : Event {
		[Serialize("WwiseBankList")] public CList<PathRef> WwiseBankList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseBankList));
		}
		public override uint? ClassCRC => 0xCB5AA558;
	}
}

