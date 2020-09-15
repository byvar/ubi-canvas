using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTAIComponent : CSerializable {
		public StringID defaultFeedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				defaultFeedbackID = s.SerializeObject<StringID>(defaultFeedbackID, name: "defaultFeedbackID");
			}
		}
		public override uint? ClassCRC => 0x0E95F48C;
	}
}

