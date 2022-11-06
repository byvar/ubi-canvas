using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_RewardTrigger_Event : CSerializable {
		public StringID eventID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			eventID = s.SerializeObject<StringID>(eventID, name: "eventID");
		}
		public override uint? ClassCRC => 0xDC301090;
	}
}

