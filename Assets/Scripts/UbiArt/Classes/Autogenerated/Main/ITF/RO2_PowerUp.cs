using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PowerUp : CSerializable {
		[Serialize("dataList")] public CArray<Generic<RO2_BasicPowerUpData>> dataList;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dataList));
		}
	}
}

