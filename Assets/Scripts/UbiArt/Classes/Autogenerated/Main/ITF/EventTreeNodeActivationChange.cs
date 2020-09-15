using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventTreeNodeActivationChange : Event {
		public bool Active;
		public StringID NodeName;
		public StringID EventID;
		public int Value;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Active = s.Serialize<bool>(Active, name: "Active");
			NodeName = s.SerializeObject<StringID>(NodeName, name: "NodeName");
			EventID = s.SerializeObject<StringID>(EventID, name: "EventID");
			Value = s.Serialize<int>(Value, name: "Value");
		}
		public override uint? ClassCRC => 0x76AAA10E;
	}
}

