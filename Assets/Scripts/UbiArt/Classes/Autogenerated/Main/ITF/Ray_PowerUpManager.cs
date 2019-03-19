using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR)]
	public partial class Ray_PowerUpManager : CSerializable {
		[Serialize("CMap<ITF::StringID, Ray_GlobalPowerUpData>__0")] public CMap<ITF::StringID, Ray_GlobalPowerUpData> CMap_ITF_StringID, Ray_GlobalPowerUpData__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(CMap_ITF_StringID, Ray_GlobalPowerUpData__0));
		}
	}
}

