using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_EventBossSpawnActor : Event {
		[Serialize("actorIndex")] public uint actorIndex;
		[Serialize("offset"    )] public Vec3d offset;
		[Serialize("flipped"   )] public int flipped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorIndex));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(flipped));
		}
		public override uint? ClassCRC => 0x7AFE9EDA;
	}
}

