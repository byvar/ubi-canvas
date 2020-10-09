using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventLevelVisited : Event {
		public StringID levelName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			levelName = s.SerializeObject<StringID>(levelName, name: "levelName");
		}
		public override uint? ClassCRC => 0xD3E9171C;
	}
}

