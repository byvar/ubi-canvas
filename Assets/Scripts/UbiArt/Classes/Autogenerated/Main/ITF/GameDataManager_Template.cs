using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class GameDataManager_Template : CSerializable {
		public uint dataVersion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dataVersion = s.Serialize<uint>(dataVersion, name: "dataVersion");
		}
		public override uint? ClassCRC => 0xBCC9D5FA;
	}
}

