using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_AIDeathBehavior_Template : AIDeathBehavior_Template {
		[Serialize("reward"       )] public Generic<Ray_EventSpawnReward> reward;
		[Serialize("soul"         )] public Path soul;
		[Serialize("numRewards"   )] public CArray<uint> numRewards;
		[Serialize("spawnOnMarker")] public int spawnOnMarker;
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

