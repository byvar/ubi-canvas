using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepWaitForStoryEvent_Template : CSerializable {
		public StringID storyEvent;
		public int storyEventValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			storyEvent = s.SerializeObject<StringID>(storyEvent, name: "storyEvent");
			storyEventValue = s.Serialize<int>(storyEventValue, name: "storyEventValue");
		}
		public override uint? ClassCRC => 0xD600F1EE;
	}
}

