using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR | GameFlags.LegendsAndUp)]
	public partial class SequenceEventWithActor_Template : SequenceEvent_Template {
		public ObjectPath TargetFriendlyName;
		public bool DisableComponentsActor;
		public StringID TargetID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			TargetFriendlyName = s.SerializeObject<ObjectPath>(TargetFriendlyName, name: "TargetFriendlyName");
			DisableComponentsActor = s.Serialize<bool>(DisableComponentsActor, name: "DisableComponentsActor");
			TargetID = s.SerializeObject<StringID>(TargetID, name: "TargetID");
		}
		public override uint? ClassCRC => 0x116CAFC2;
	}
}

