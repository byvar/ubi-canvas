using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_3DBindTmpComponent : ActorComponent {
		public StringID bone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				bone = s.SerializeObject<StringID>(bone, name: "bone");
			}
		}
		public override uint? ClassCRC => 0xCD0C3B4E;
	}
}

