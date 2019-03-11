using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_3DBindTmpComponent : ActorComponent {
		[Serialize("bone")] public StringID bone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(bone));
			}
		}
		public override uint? ClassCRC => 0xCD0C3B4E;
	}
}

