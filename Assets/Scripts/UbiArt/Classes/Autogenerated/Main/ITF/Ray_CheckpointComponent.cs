using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_CheckpointComponent : CSerializable {
		[Serialize("SpawnPos")] public Placeholder SpawnPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(SpawnPos));
			}
		}
		public override uint? ClassCRC => 0x413DDAA2;
	}
}

