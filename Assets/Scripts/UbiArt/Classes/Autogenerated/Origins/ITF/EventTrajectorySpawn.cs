using UnityEngine;

namespace UbiArt.ITF {
	public partial class EventTrajectorySpawn : CSerializable {
		[Serialize("spawneeIndex")] public uint spawneeIndex;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawneeIndex));
		}
		public override uint? ClassCRC => 0xE54BBD95;
	}
}

