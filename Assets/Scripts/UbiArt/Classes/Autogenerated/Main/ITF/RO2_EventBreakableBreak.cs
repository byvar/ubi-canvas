using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class RO2_EventBreakableBreak : Event {
		public bool Break;
		public bool immediate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Break = s.Serialize<bool>(Break, name: "Break");
			immediate = s.Serialize<bool>(immediate, name: "immediate");
		}
		public override uint? ClassCRC => 0xE9121171;
	}
}

