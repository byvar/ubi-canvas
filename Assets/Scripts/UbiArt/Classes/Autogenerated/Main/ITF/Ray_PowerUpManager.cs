using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_PowerUpManager : CSerializable {
		public CMap<StringID, Ray_GlobalPowerUpData> globalData;
		public CMap<StringID, CArrayO<Ray_PerPlayerPowerUpData>> perPlayerData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			globalData = s.SerializeObject<CMap<StringID, Ray_GlobalPowerUpData>>(globalData, name: "globalData");
		}
	}
}

