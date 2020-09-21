using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_ShooterCheckPointComponent : CheckpointComponent {
		public CArrayO<Vec2d> SpawnPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SpawnPos = s.SerializeObject<CArrayO<Vec2d>>(SpawnPos, name: "SpawnPos");
			}
		}
		public override uint? ClassCRC => 0x159DBDEC;
	}
}

