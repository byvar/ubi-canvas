using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_BreakableStackElementAIComponent : Ray_AIComponent {
		[Serialize("managerPath"   )] public ObjectPath managerPath;
		[Serialize("countSpawnMax" )] public uint countSpawnMax;
		[Serialize("blockIsDestroy")] public int blockIsDestroy;
		[Serialize("checkPointRow" )] public uint checkPointRow;
		[Serialize("checkPointCol" )] public uint checkPointCol;
		[Serialize("blockState"    )] public uint blockState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(managerPath));
			}
			SerializeField(s, nameof(countSpawnMax));
			if (s.HasFlags(SerializeFlags.Persistent)) {
				SerializeField(s, nameof(blockIsDestroy));
				SerializeField(s, nameof(checkPointRow));
				SerializeField(s, nameof(checkPointCol));
				SerializeField(s, nameof(blockState));
			}
		}
		public override uint? ClassCRC => 0x765FD4DB;
	}
}

