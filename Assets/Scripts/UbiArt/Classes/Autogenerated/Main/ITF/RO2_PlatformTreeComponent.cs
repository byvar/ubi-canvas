using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlatformTreeComponent : ActorComponent {
		[Serialize("startActivated")] public bool startActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startActivated));
			}
		}
		public override uint? ClassCRC => 0x7EC341B5;
	}
}

