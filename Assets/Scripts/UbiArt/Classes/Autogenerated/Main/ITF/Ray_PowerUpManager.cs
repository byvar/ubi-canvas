using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PowerUpManager : CSerializable {
		[Serialize("globalData")] public CMap<StringID, Ray_GlobalPowerUpData> globalData;
		[Serialize("perPlayerData")] public CMap<StringID, CArray<Ray_PerPlayerPowerUpData>> perPlayerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(globalData));
		}
	}
}

