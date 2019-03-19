using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepWaitForStoryEvent_Template : CSerializable {
		[Serialize("storyEvent"     )] public StringID storyEvent;
		[Serialize("storyEventValue")] public int storyEventValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(storyEvent));
			SerializeField(s, nameof(storyEventValue));
		}
		public override uint? ClassCRC => 0xD600F1EE;
	}
}

