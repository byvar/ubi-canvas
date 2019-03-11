using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_EventBossSpawnActor : Event {
		[Serialize("actorIndex")] public uint actorIndex;
		[Serialize("offset"    )] public Vector3 offset;
		[Serialize("flipped"   )] public bool flipped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(actorIndex));
			SerializeField(s, nameof(offset));
			SerializeField(s, nameof(flipped));
		}
		public override uint? ClassCRC => 0x7AFE9EDA;
	}
}

