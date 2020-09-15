using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventUnloadWwiseBank : Event {
		public CList<PathRef> WwiseBankList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseBankList = s.SerializeObject<CList<PathRef>>(WwiseBankList, name: "WwiseBankList");
		}
		public override uint? ClassCRC => 0xCB5AA558;
	}
}

