using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RM)]
	public partial class RLC_CurrencyPoolConfig : CSerializable {
		public uint replenishmentMinutes;
		public uint replenishmentNbMin;
		public uint replenishmentNbMax;
		public uint replenishmentLimitMin;
		public uint replenishmentLimitMax;
		public uint currencyValue;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			replenishmentMinutes = s.Serialize<uint>(replenishmentMinutes, name: "replenishmentMinutes");
			replenishmentNbMin = s.Serialize<uint>(replenishmentNbMin, name: "replenishmentNbMin");
			replenishmentNbMax = s.Serialize<uint>(replenishmentNbMax, name: "replenishmentNbMax");
			replenishmentLimitMin = s.Serialize<uint>(replenishmentLimitMin, name: "replenishmentLimitMin");
			replenishmentLimitMax = s.Serialize<uint>(replenishmentLimitMax, name: "replenishmentLimitMax");
			currencyValue = s.Serialize<uint>(currencyValue, name: "currencyValue");
		}
		public override uint? ClassCRC => 0x26221AA4;
	}
}

