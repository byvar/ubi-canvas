using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCheckPointComponent : CheckpointComponent {
		[Serialize("SpawnPos")] public CArray<Vector2> SpawnPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(SpawnPos));
			}
		}
		public override uint? ClassCRC => 0x159DBDEC;
	}
}

