using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepChoiceDialog_Template : CSerializable {
		public Placeholder titleLocID;
		public Placeholder msgLocID;
		public Placeholder validateLocID;
		public Placeholder declineLocID;
		public StringID storyEventValidate;
		public StringID storyEventDecline;
		public int storyEventValidateValue;
		public int storyEventDeclineValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			titleLocID = s.SerializeObject<Placeholder>(titleLocID, name: "titleLocID");
			msgLocID = s.SerializeObject<Placeholder>(msgLocID, name: "msgLocID");
			validateLocID = s.SerializeObject<Placeholder>(validateLocID, name: "validateLocID");
			declineLocID = s.SerializeObject<Placeholder>(declineLocID, name: "declineLocID");
			storyEventValidate = s.SerializeObject<StringID>(storyEventValidate, name: "storyEventValidate");
			storyEventDecline = s.SerializeObject<StringID>(storyEventDecline, name: "storyEventDecline");
			storyEventValidateValue = s.Serialize<int>(storyEventValidateValue, name: "storyEventValidateValue");
			storyEventDeclineValue = s.Serialize<int>(storyEventDeclineValue, name: "storyEventDeclineValue");
		}
		public override uint? ClassCRC => 0xBA0BE8A2;
	}
}

