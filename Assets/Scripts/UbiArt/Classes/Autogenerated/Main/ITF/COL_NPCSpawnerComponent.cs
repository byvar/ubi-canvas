using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_NPCSpawnerComponent : CSerializable {
		[Serialize("npcPathOverride")] public Path npcPathOverride;
		[Serialize("spawnFlipped"   )] public bool spawnFlipped;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(npcPathOverride));
			SerializeField(s, nameof(spawnFlipped), boolAsByte: true);
		}
		public override uint? ClassCRC => 0x1C0BBDBE;
	}
}

