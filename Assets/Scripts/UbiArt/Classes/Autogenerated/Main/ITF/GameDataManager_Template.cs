using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class GameDataManager_Template : CSerializable {
		[Serialize("dataVersion")] public uint dataVersion;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dataVersion));
		}
		public override uint? ClassCRC => 0xA0CEEDEE;
	}
}

