using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RAVersion)]
	public partial class EventBreakableBreak : Event {
		public bool Break;
		public bool immediate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Break = s.Serialize<bool>(Break, name: "Break");
			immediate = s.Serialize<bool>(immediate, name: "immediate");
		}
		public override uint? ClassCRC => 0xE98C0AC1;
	}
}

