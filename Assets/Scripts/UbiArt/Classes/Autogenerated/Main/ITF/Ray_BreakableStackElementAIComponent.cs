using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_BreakableStackElementAIComponent : Ray_AIComponent {
		public ObjectPath managerPath;
		public uint countSpawnMax;
		public int blockIsDestroy;
		public uint checkPointRow;
		public uint checkPointCol;
		public uint blockState;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				managerPath = s.SerializeObject<ObjectPath>(managerPath, name: "managerPath");
			}
			countSpawnMax = s.Serialize<uint>(countSpawnMax, name: "countSpawnMax");
			if (s.HasFlags(SerializeFlags.Persistent)) {
				blockIsDestroy = s.Serialize<int>(blockIsDestroy, name: "blockIsDestroy");
				checkPointRow = s.Serialize<uint>(checkPointRow, name: "checkPointRow");
				checkPointCol = s.Serialize<uint>(checkPointCol, name: "checkPointCol");
				blockState = s.Serialize<uint>(blockState, name: "blockState");
			}
		}
		public override uint? ClassCRC => 0x765FD4DB;
	}
}

