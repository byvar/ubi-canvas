using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PlayerSelectComponent : ShapeComponent {
		[Serialize("playerId")] public StringID playerId;
		[Serialize("disabled")] public bool disabled;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Default)) {
				SerializeField(s, nameof(playerId));
			}
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(disabled));
			}
		}
		public override uint? ClassCRC => 0xB180E03A;
	}
}

