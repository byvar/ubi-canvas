using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PaintBumperComponent : ActorComponent {
		public bool HasBeenDRCified;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				HasBeenDRCified = s.Serialize<bool>(HasBeenDRCified, name: "HasBeenDRCified");
			}
		}
		public override uint? ClassCRC => 0xD6E104C6;
	}
}

