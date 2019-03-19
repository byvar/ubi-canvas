using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_DarkCloudSpawnPointComponent : CSerializable {
		[Serialize("spawnRadius")] public float spawnRadius;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(spawnRadius));
		}
		public override uint? ClassCRC => 0x4B5D3BDB;
	}
}

