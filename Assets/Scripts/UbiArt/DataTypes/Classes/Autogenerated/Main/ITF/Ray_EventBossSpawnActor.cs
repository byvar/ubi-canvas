using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion)]
	public partial class Ray_EventBossSpawnActor : Event {
		public uint actorIndex;
		public Vec3d offset;
		public int flipped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			actorIndex = s.Serialize<uint>(actorIndex, name: "actorIndex");
			offset = s.SerializeObject<Vec3d>(offset, name: "offset");
			flipped = s.Serialize<int>(flipped, name: "flipped");
		}
		public override uint? ClassCRC => 0x7AFE9EDA;
	}
}

