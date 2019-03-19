using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_AudioEventManager_Region_Template : CSerializable {
		[Serialize("regionName"      )] public StringID regionName;
		[Serialize("bankGuid"        )] public StringID bankGuid;
		[Serialize("musicStateBattle")] public StringID musicStateBattle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(regionName));
			SerializeField(s, nameof(bankGuid));
			SerializeField(s, nameof(musicStateBattle));
		}
		public override uint? ClassCRC => 0x0172D3E3;
	}
}

