using UnityEngine;

namespace UbiArt.ITF {
	public partial class SequenceEventWithActor_Template : SequenceEvent_Template {
		[Serialize("TargetFriendlyName"    )] public ObjectPath TargetFriendlyName;
		[Serialize("DisableComponentsActor")] public bool DisableComponentsActor;
		[Serialize("TargetID"              )] public StringID TargetID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(TargetFriendlyName));
			SerializeField(s, nameof(DisableComponentsActor));
			SerializeField(s, nameof(TargetID));
		}
		public override uint? ClassCRC => 0x116CAFC2;
	}
}

