using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudSpawnPointComponent : CSerializable {
		public float spawnRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			spawnRadius = s.Serialize<float>(spawnRadius, name: "spawnRadius");
		}
		public override uint? ClassCRC => 0x4B5D3BDB;
	}
}

