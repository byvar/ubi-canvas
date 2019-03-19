using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_NPCSpawnerComponent_Template : CSerializable {
		[Serialize("npcPath")] public Path npcPath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(npcPath));
		}
		public override uint? ClassCRC => 0xDD9F5C37;
	}
}

