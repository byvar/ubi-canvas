using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_AIDeathBehavior_Template : AIDeathBehavior_Template {
		[Serialize("reward"       )] public Placeholder reward;
		[Serialize("soul"         )] public Path soul;
		[Serialize("numRewards"   )] public Placeholder numRewards;
		[Serialize("spawnOnMarker")] public bool spawnOnMarker;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(reward));
			SerializeField(s, nameof(soul));
			SerializeField(s, nameof(numRewards));
			SerializeField(s, nameof(spawnOnMarker));
		}
		public override uint? ClassCRC => 0x7D1F295C;
	}
}

