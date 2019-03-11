using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventChangeBankId : Event {
		[Serialize("BankId")] public StringID BankId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(BankId));
		}
		public override uint? ClassCRC => 0x6FE7696C;
	}
}

