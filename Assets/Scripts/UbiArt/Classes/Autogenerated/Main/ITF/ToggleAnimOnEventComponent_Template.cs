using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RO | GameFlags.RL | GameFlags.COL | GameFlags.VH)]
	public partial class ToggleAnimOnEventComponent_Template : ActorComponent_Template {
		public StringID openAnim;
		public StringID closeAnim;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			openAnim = s.SerializeObject<StringID>(openAnim, name: "openAnim");
			closeAnim = s.SerializeObject<StringID>(closeAnim, name: "closeAnim");
		}
		public override uint? ClassCRC => 0x639A643E;
	}
}

