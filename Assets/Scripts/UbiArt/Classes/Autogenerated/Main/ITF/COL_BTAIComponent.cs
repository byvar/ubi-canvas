using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_BTAIComponent : CSerializable {
		[Serialize("defaultFeedbackID")] public StringID defaultFeedbackID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(defaultFeedbackID));
			}
		}
		public override uint? ClassCRC => 0x0E95F48C;
	}
}

