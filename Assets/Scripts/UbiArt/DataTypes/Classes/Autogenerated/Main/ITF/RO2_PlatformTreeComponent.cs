using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_PlatformTreeComponent : ActorComponent {
		public bool startActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				startActivated = s.Serialize<bool>(startActivated, name: "startActivated");
			}
		}
		public override uint? ClassCRC => 0x7EC341B5;
	}
}

