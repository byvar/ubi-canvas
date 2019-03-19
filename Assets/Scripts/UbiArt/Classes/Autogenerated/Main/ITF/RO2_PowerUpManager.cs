using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_PowerUpManager : CSerializable {
		[Serialize("powerUps")] public CMap<StringID, RO2_PowerUp> powerUps;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(powerUps));
		}
	}
}

