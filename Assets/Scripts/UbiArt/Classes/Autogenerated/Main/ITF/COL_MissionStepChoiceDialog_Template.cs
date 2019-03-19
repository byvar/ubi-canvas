using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepChoiceDialog_Template : CSerializable {
		[Serialize("titleLocID"             )] public Placeholder titleLocID;
		[Serialize("msgLocID"               )] public Placeholder msgLocID;
		[Serialize("validateLocID"          )] public Placeholder validateLocID;
		[Serialize("declineLocID"           )] public Placeholder declineLocID;
		[Serialize("storyEventValidate"     )] public StringID storyEventValidate;
		[Serialize("storyEventDecline"      )] public StringID storyEventDecline;
		[Serialize("storyEventValidateValue")] public int storyEventValidateValue;
		[Serialize("storyEventDeclineValue" )] public int storyEventDeclineValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(titleLocID));
			SerializeField(s, nameof(msgLocID));
			SerializeField(s, nameof(validateLocID));
			SerializeField(s, nameof(declineLocID));
			SerializeField(s, nameof(storyEventValidate));
			SerializeField(s, nameof(storyEventDecline));
			SerializeField(s, nameof(storyEventValidateValue));
			SerializeField(s, nameof(storyEventDeclineValue));
		}
		public override uint? ClassCRC => 0xEFAC690A;
	}
}

