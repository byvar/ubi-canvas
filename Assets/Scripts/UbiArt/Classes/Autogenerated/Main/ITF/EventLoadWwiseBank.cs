using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventLoadWwiseBank : Event {
		public CListO<PathRef> WwiseBankList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			WwiseBankList = s.SerializeObject<CListO<PathRef>>(WwiseBankList, name: "WwiseBankList");
		}
		public override uint? ClassCRC => 0xDA709CC8;
	}
}

