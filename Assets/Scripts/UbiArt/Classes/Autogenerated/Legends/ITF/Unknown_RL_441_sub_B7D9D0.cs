using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class Unknown_RL_441_sub_B7D9D0 : CheckpointComponent {
		[Serialize("SpawnPos")] public CList<Vec2d> SpawnPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(SpawnPos));
			}
		}
		public override uint? ClassCRC => 0x45E5F4C0;
	}
}

