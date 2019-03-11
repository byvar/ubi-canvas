using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTreeNodeActivationChange : Event {
		[Serialize("Active"  )] public bool Active;
		[Serialize("NodeName")] public StringID NodeName;
		[Serialize("EventID" )] public StringID EventID;
		[Serialize("Value"   )] public int Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Active));
			SerializeField(s, nameof(NodeName));
			SerializeField(s, nameof(EventID));
			SerializeField(s, nameof(Value));
		}
		public override uint? ClassCRC => 0x76AAA10E;
	}
}

