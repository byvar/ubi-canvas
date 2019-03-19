using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH)]
	public partial class EventLevelVisited : Event {
		[Serialize("levelName")] public StringID levelName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(levelName));
		}
		public override uint? ClassCRC => 0xD3E9171C;
	}
}

