using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionConditionStoryEvent_Template : CSerializable {
		[Serialize("storyEvent")] public StringID storyEvent;
		[Serialize("value"     )] public int value;
		[Serialize("negated"   )] public bool negated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(storyEvent));
			SerializeField(s, nameof(value));
			SerializeField(s, nameof(negated), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x43B849B1;
	}
}

