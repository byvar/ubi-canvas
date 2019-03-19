using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionActionStoryEvent_Template : CSerializable {
		[Serialize("storyEvent")] public StringID storyEvent;
		[Serialize("value"     )] public int value;
		[Serialize("operator"  )] public Enum_operator _operator;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(storyEvent));
			SerializeField(s, nameof(value));
			SerializeField(s, nameof(_operator));
		}
		public enum Enum_operator {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
		}
		public override uint? ClassCRC => 0x3684B4BC;
	}
}

