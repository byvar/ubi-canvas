using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventLoadWwiseBank : Event {
		[Serialize("WwiseBankList")] public CList<PathRef> WwiseBankList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(WwiseBankList));
		}
		public override uint? ClassCRC => 0xDA709CC8;
	}
}

