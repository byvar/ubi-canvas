using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PlatformTreeComponent : ActorComponent {
		[Serialize("startActivated")] public int startActivated;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(startActivated));
			}
		}
		public override uint? ClassCRC => 0xF4D18DFC;
	}
}

