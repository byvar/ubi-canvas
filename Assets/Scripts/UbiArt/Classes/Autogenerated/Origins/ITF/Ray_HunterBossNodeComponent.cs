using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_HunterBossNodeComponent : LinkComponent {
		[Serialize("data")] public Placeholder data;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(data));
			}
		}
		public override uint? ClassCRC => 0xC3B84AD9;
	}
}

