using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventChangeBankId : Event {
		public StringID BankId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			BankId = s.SerializeObject<StringID>(BankId, name: "BankId");
		}
		public override uint? ClassCRC => 0x6FE7696C;
	}
}

