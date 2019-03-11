using UnityEngine;

namespace UbiArt.ITF {
	public partial class RLC_CurrencyPoolConfig : CSerializable {
		[Serialize("replenishmentMinutes" )] public uint replenishmentMinutes;
		[Serialize("replenishmentNbMin"   )] public uint replenishmentNbMin;
		[Serialize("replenishmentNbMax"   )] public uint replenishmentNbMax;
		[Serialize("replenishmentLimitMin")] public uint replenishmentLimitMin;
		[Serialize("replenishmentLimitMax")] public uint replenishmentLimitMax;
		[Serialize("currencyValue"        )] public uint currencyValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(replenishmentMinutes));
			SerializeField(s, nameof(replenishmentNbMin));
			SerializeField(s, nameof(replenishmentNbMax));
			SerializeField(s, nameof(replenishmentLimitMin));
			SerializeField(s, nameof(replenishmentLimitMax));
			SerializeField(s, nameof(currencyValue));
		}
		public override uint? ClassCRC => 0x26221AA4;
	}
}

